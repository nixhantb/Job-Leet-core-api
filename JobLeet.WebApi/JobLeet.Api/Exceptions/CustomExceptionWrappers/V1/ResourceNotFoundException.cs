namespace JobLeet.WebApi.JobLeet.Api.Exceptions.CustomExceptionWrappers.V1
{
    public class ResourceNotFoundException
    {
        private readonly RequestDelegate _next;

        public ResourceNotFoundException(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke (HttpContext context)
        {
            await _next(context);

            if(context.Response.StatusCode == StatusCodes.Status404NotFound  && !context.Response.HasStarted)
            {
                var requestPath = context.Request.Path;
                var requestUri = $"{context.Request.Scheme}://{context.Request.Host}{requestPath}";
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync($"{{\"Message\": \"No HTTP resource was found that matches the request URI '{requestUri}'\"}}");
            }
        }
    }
}

using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.JobLeet.Api.Tests.Models.Employers.V1
{
    public class AddressModelTest
    {
        [Fact]
        public void AddressModel_ShouldCorrectlyValidateAnnotations()
        {
            var Addressmodel = new AddressModel { Street = null, City = null, State = "KA", PostalCode = null, Country = null };

            Assert.NotNull(Addressmodel);
            var validationResults = ValidateAnnotationHelper.ValidateModel(Addressmodel);
           
            // Assert
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("PostalCode") && v.ErrorMessage.Contains("required")), "PostalCode property should be marked as required");
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Country") && v.ErrorMessage.Contains("required")), "Country property should be marked as required");


            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Street") && v.ErrorMessage.Contains("required")), "Country property should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("City") && v.ErrorMessage.Contains("required")), "Country property should be marked as required");
        }

        [Fact]
        public void AddressModel_ShouldInstantiateSuccessfully ()
        {
            var Addressmodel = new AddressModel { Street = "KL", City = "Ktm", State = "KA", PostalCode = "32345", Country = "UAE" };

            Assert.Equal(Addressmodel.Street, "KL");
            Assert.Equal(Addressmodel.City, "Ktm");
            Assert.Equal(Addressmodel.State, "KA");
            Assert.Equal(Addressmodel.PostalCode, "32345");
            Assert.Equal(Addressmodel.Country, "UAE");
        }


       
    }

}

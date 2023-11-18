# Job Leet Database

## Overview

The Job Leet Database is designed to support the Job Leet application, providing a structured storage solution for user roles, job applications, and related information. Below is a comprehensive overview of the main tables in the database.
Feel free to view Graphical table view [Here](https://docs.google.com/spreadsheets/d/1ZpQGDivfdJ0QEQLMkEHwnUsVeYD4APQiLoKkpitPNus/edit?usp=sharing)

## Tables

### Roles Table

- **Table Name:** roles
- **Description:** Stores user roles such as 'admin' and 'users'.

### Users Table

- **Table Name:** users
- **Description:** Manages user information including usernames, email addresses, and passwords.
  
### Admins Table

- **Table Name:** admins
- **Description:** Specific table for admin users.

### Addresses Table

- **Table Name:** addresses
- **Description:** Stores address information, including street, city, state, postal code, and country.

### Educations Table

- **Table Name:** educations
- **Description:** Manages educational background details, including degree, major, institution, graduation date, and CGPA.

### Statuses Table

- **Table Name:** statuses
- **Description:** Tracks various statuses such as 'Active', 'Inactive', 'Pending', 'Completed', and 'Cancelled'.

### Qualifications Table

- **Table Name:** qualifications
- **Description:** Stores qualification-related information.

### Dates Table

- **Table Name:** dates
- **Description:** Manages date-related information used across different tables.

### Person Names Table

- **Table Name:** person_names
- **Description:** Stores personal names, including first name, middle name, and last name.

### Phones Table

- **Table Name:** phones
- **Description:** Manages phone-related information, including country code and phone number.

### Company Profiles Table

- **Table Name:** company_profiles
- **Description:** Stores information about company profiles.

### Industry Types Table

- **Table Name:** industry_types
- **Description:** Categorizes industry types, such as 'Technology', 'Healthcare', 'Finance', 'Manufacturing', and 'Others'.

### Experiences Table

- **Table Name:** experiences
- **Description:** Tracks professional experiences, including experience level and total experience.

### Skills Table

- **Table Name:** skills
- **Description:** Manages information about skills, including title and description.

### Logins Table

- **Table Name:** logins
- **Description:** Tracks login-related information, including account status, creation status, and login time.

### Employers Table

- **Table Name:** employers
- **Description:** Manages information about employers, including user details, address, phone, profile, employer type, and industry type.

### Seekers Table

- **Table Name:** seekers
- **Description:** Stores information about job seekers, including user details, personal information, contact details, skills, education, and experience.

### Applications Table

- **Table Name:** applications
- **Description:** Manages job applications, including seeker, employer, job, status, and date information.

### Jobs Table

- **Table Name:** jobs
- **Description:** Stores information about job positions, including employer, address, qualification, date, title, description, vacancies, experience, basic pay, functional area, industry type, and posting date.

### Application Dates Table

- **Table Name:** application_dates
- **Description:** Manages dates related to job applications, including application date, review date, decision date, and comments.


## Contributing

If you find any issues or have suggestions for improvement, feel free to submit a pull request or open an issue.

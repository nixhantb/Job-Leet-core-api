--
-- PostgreSQL database dump
--

-- Dumped from database version 16.4 (Ubuntu 16.4-0ubuntu0.24.04.2)
-- Dumped by pg_dump version 16.4 (Ubuntu 16.4-0ubuntu0.24.04.2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO leetadmin;

--
-- Name: jblt_company; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_company (
    company_id integer NOT NULL,
    company_name text,
    "ProfileId" integer
);


ALTER TABLE public.jblt_company OWNER TO leetadmin;

--
-- Name: jblt_company_company_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_company ALTER COLUMN company_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_company_company_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_companyprofile; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_companyprofile (
    companyprofile_id integer NOT NULL,
    "ProfileInfo" text,
    "CompanyAddressId" integer,
    "ContactPhoneId" integer,
    "ContactEmailId" integer,
    company_website text,
    "IndustryType" integer
);


ALTER TABLE public.jblt_companyprofile OWNER TO leetadmin;

--
-- Name: jblt_companyprofile_companyprofile_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_companyprofile ALTER COLUMN companyprofile_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_companyprofile_companyprofile_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_education; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_education (
    education_id integer NOT NULL,
    education_degree text NOT NULL,
    education_major text NOT NULL,
    education_nstitution text NOT NULL,
    education_graduationdate date NOT NULL,
    education_cgpa numeric NOT NULL
);


ALTER TABLE public.jblt_education OWNER TO leetadmin;

--
-- Name: jblt_education_education_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_education ALTER COLUMN education_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_education_education_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_email; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_email (
    email_id integer NOT NULL,
    email_type integer NOT NULL,
    email_address text
);


ALTER TABLE public.jblt_email OWNER TO leetadmin;

--
-- Name: jblt_email_email_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_email ALTER COLUMN email_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_email_email_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_experience; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_experience (
    experience_id integer NOT NULL,
    experience_type integer NOT NULL
);


ALTER TABLE public.jblt_experience OWNER TO leetadmin;

--
-- Name: jblt_experience_experience_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_experience ALTER COLUMN experience_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_experience_experience_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_job; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_job (
    job_id integer NOT NULL,
    "CompanyDescriptionId" integer,
    job_title text,
    job_description text,
    job_type text,
    "JobAddressId" integer,
    job_vacancies integer,
    job_basic_pay text,
    job_functional_area text,
    "SkillsRequiredId" integer,
    "RequiredQualificationId" integer,
    "RequiredExperienceId" integer,
    preferred_qualifications text,
    job_responsibility text,
    job_benefits text,
    job_tags text,
    job_workenvironment text,
    job_posting_date timestamp with time zone,
    job_applicationdeadline timestamp with time zone
);


ALTER TABLE public.jblt_job OWNER TO leetadmin;

--
-- Name: jblt_job_job_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_job ALTER COLUMN job_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_job_job_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_loginuser; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_loginuser (
    loginuser_id integer NOT NULL,
    loginuser_address text NOT NULL,
    loginuser_password text NOT NULL,
    "PersonNameId" integer,
    loginuser_accountstatus integer NOT NULL,
    loginuser_accountcreated boolean NOT NULL,
    loginuser_logintime timestamp with time zone NOT NULL,
    loginuser_ipaddress text,
    loginuser_role integer NOT NULL
);


ALTER TABLE public.jblt_loginuser OWNER TO leetadmin;

--
-- Name: jblt_loginuser_loginuser_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_loginuser ALTER COLUMN loginuser_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_loginuser_loginuser_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_personName; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public."jblt_personName" (
    personname_id integer NOT NULL,
    "personName_firstname" text,
    "personName_middlename" text,
    "personName_lastname" text
);


ALTER TABLE public."jblt_personName" OWNER TO leetadmin;

--
-- Name: jblt_personName_personname_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public."jblt_personName" ALTER COLUMN personname_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."jblt_personName_personname_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_phone; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_phone (
    jblt_phoneid integer NOT NULL,
    jblt_countrycode integer NOT NULL,
    jblt_phonenumber text
);


ALTER TABLE public.jblt_phone OWNER TO leetadmin;

--
-- Name: jblt_phone_jblt_phoneid_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_phone ALTER COLUMN jblt_phoneid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_phone_jblt_phoneid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_qualification; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_qualification (
    qualification_id integer NOT NULL,
    qualification_type integer NOT NULL,
    qualification_information text
);


ALTER TABLE public.jblt_qualification OWNER TO leetadmin;

--
-- Name: jblt_qualification_qualification_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_qualification ALTER COLUMN qualification_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_qualification_qualification_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_registerUser; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public."jblt_registerUser" (
    jblt_registerid integer NOT NULL,
    "Salt" text,
    "PersonNameId" integer NOT NULL,
    "UserEmailId" integer NOT NULL,
    jblt_password character varying(101) NOT NULL,
    jblt_confirmpassword character varying(101) NOT NULL
);


ALTER TABLE public."jblt_registerUser" OWNER TO leetadmin;

--
-- Name: jblt_registerUser_jblt_registerid_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public."jblt_registerUser" ALTER COLUMN jblt_registerid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."jblt_registerUser_jblt_registerid_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_role; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_role (
    role_roleid integer NOT NULL,
    role_name integer NOT NULL
);


ALTER TABLE public.jblt_role OWNER TO leetadmin;

--
-- Name: jblt_role_role_roleid_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_role ALTER COLUMN role_roleid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_role_role_roleid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_seeker; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_seeker (
    seeker_id integer NOT NULL,
    "PhoneId" integer,
    "AddressId" integer,
    "SkillsId" integer,
    "EducationId" integer,
    "ExperienceId" integer,
    seeker_dob timestamp with time zone,
    "QualificationsId" integer,
    seeker_profilesummary text,
    seeker_linkedin text,
    "Portfolio" text,
    job_interests text,
    job_achievements text
);


ALTER TABLE public.jblt_seeker OWNER TO leetadmin;

--
-- Name: jblt_seeker_seeker_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_seeker ALTER COLUMN seeker_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_seeker_seeker_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_skill; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public.jblt_skill (
    skill_id integer NOT NULL,
    title text,
    description text
);


ALTER TABLE public.jblt_skill OWNER TO leetadmin;

--
-- Name: jblt_skill_skill_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public.jblt_skill ALTER COLUMN skill_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.jblt_skill_skill_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: jblt_userAddress; Type: TABLE; Schema: public; Owner: leetadmin
--

CREATE TABLE public."jblt_userAddress" (
    address_id integer NOT NULL,
    address_street text,
    address_city text,
    address_state text,
    "address_postalCode" text,
    address_country text NOT NULL
);


ALTER TABLE public."jblt_userAddress" OWNER TO leetadmin;

--
-- Name: jblt_userAddress_address_id_seq; Type: SEQUENCE; Schema: public; Owner: leetadmin
--

ALTER TABLE public."jblt_userAddress" ALTER COLUMN address_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."jblt_userAddress_address_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- Name: jblt_company PK_jblt_company; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_company
    ADD CONSTRAINT "PK_jblt_company" PRIMARY KEY (company_id);


--
-- Name: jblt_companyprofile PK_jblt_companyprofile; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_companyprofile
    ADD CONSTRAINT "PK_jblt_companyprofile" PRIMARY KEY (companyprofile_id);


--
-- Name: jblt_education PK_jblt_education; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_education
    ADD CONSTRAINT "PK_jblt_education" PRIMARY KEY (education_id);


--
-- Name: jblt_email PK_jblt_email; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_email
    ADD CONSTRAINT "PK_jblt_email" PRIMARY KEY (email_id);


--
-- Name: jblt_experience PK_jblt_experience; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_experience
    ADD CONSTRAINT "PK_jblt_experience" PRIMARY KEY (experience_id);


--
-- Name: jblt_job PK_jblt_job; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_job
    ADD CONSTRAINT "PK_jblt_job" PRIMARY KEY (job_id);


--
-- Name: jblt_loginuser PK_jblt_loginuser; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_loginuser
    ADD CONSTRAINT "PK_jblt_loginuser" PRIMARY KEY (loginuser_id);


--
-- Name: jblt_personName PK_jblt_personName; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public."jblt_personName"
    ADD CONSTRAINT "PK_jblt_personName" PRIMARY KEY (personname_id);


--
-- Name: jblt_phone PK_jblt_phone; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_phone
    ADD CONSTRAINT "PK_jblt_phone" PRIMARY KEY (jblt_phoneid);


--
-- Name: jblt_qualification PK_jblt_qualification; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_qualification
    ADD CONSTRAINT "PK_jblt_qualification" PRIMARY KEY (qualification_id);


--
-- Name: jblt_registerUser PK_jblt_registerUser; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public."jblt_registerUser"
    ADD CONSTRAINT "PK_jblt_registerUser" PRIMARY KEY (jblt_registerid);


--
-- Name: jblt_role PK_jblt_role; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_role
    ADD CONSTRAINT "PK_jblt_role" PRIMARY KEY (role_roleid);


--
-- Name: jblt_seeker PK_jblt_seeker; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "PK_jblt_seeker" PRIMARY KEY (seeker_id);


--
-- Name: jblt_skill PK_jblt_skill; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_skill
    ADD CONSTRAINT "PK_jblt_skill" PRIMARY KEY (skill_id);


--
-- Name: jblt_userAddress PK_jblt_userAddress; Type: CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public."jblt_userAddress"
    ADD CONSTRAINT "PK_jblt_userAddress" PRIMARY KEY (address_id);


--
-- Name: IX_jblt_company_ProfileId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_company_ProfileId" ON public.jblt_company USING btree ("ProfileId");


--
-- Name: IX_jblt_companyprofile_CompanyAddressId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_companyprofile_CompanyAddressId" ON public.jblt_companyprofile USING btree ("CompanyAddressId");


--
-- Name: IX_jblt_companyprofile_ContactEmailId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_companyprofile_ContactEmailId" ON public.jblt_companyprofile USING btree ("ContactEmailId");


--
-- Name: IX_jblt_companyprofile_ContactPhoneId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_companyprofile_ContactPhoneId" ON public.jblt_companyprofile USING btree ("ContactPhoneId");


--
-- Name: IX_jblt_job_CompanyDescriptionId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_job_CompanyDescriptionId" ON public.jblt_job USING btree ("CompanyDescriptionId");


--
-- Name: IX_jblt_job_JobAddressId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_job_JobAddressId" ON public.jblt_job USING btree ("JobAddressId");


--
-- Name: IX_jblt_job_RequiredExperienceId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_job_RequiredExperienceId" ON public.jblt_job USING btree ("RequiredExperienceId");


--
-- Name: IX_jblt_job_RequiredQualificationId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_job_RequiredQualificationId" ON public.jblt_job USING btree ("RequiredQualificationId");


--
-- Name: IX_jblt_job_SkillsRequiredId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_job_SkillsRequiredId" ON public.jblt_job USING btree ("SkillsRequiredId");


--
-- Name: IX_jblt_loginuser_PersonNameId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_loginuser_PersonNameId" ON public.jblt_loginuser USING btree ("PersonNameId");


--
-- Name: IX_jblt_registerUser_PersonNameId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_registerUser_PersonNameId" ON public."jblt_registerUser" USING btree ("PersonNameId");


--
-- Name: IX_jblt_registerUser_UserEmailId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_registerUser_UserEmailId" ON public."jblt_registerUser" USING btree ("UserEmailId");


--
-- Name: IX_jblt_seeker_AddressId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_seeker_AddressId" ON public.jblt_seeker USING btree ("AddressId");


--
-- Name: IX_jblt_seeker_EducationId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_seeker_EducationId" ON public.jblt_seeker USING btree ("EducationId");


--
-- Name: IX_jblt_seeker_ExperienceId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_seeker_ExperienceId" ON public.jblt_seeker USING btree ("ExperienceId");


--
-- Name: IX_jblt_seeker_PhoneId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_seeker_PhoneId" ON public.jblt_seeker USING btree ("PhoneId");


--
-- Name: IX_jblt_seeker_QualificationsId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_seeker_QualificationsId" ON public.jblt_seeker USING btree ("QualificationsId");


--
-- Name: IX_jblt_seeker_SkillsId; Type: INDEX; Schema: public; Owner: leetadmin
--

CREATE INDEX "IX_jblt_seeker_SkillsId" ON public.jblt_seeker USING btree ("SkillsId");


--
-- Name: jblt_company FK_jblt_company_jblt_companyprofile_ProfileId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_company
    ADD CONSTRAINT "FK_jblt_company_jblt_companyprofile_ProfileId" FOREIGN KEY ("ProfileId") REFERENCES public.jblt_companyprofile(companyprofile_id);


--
-- Name: jblt_companyprofile FK_jblt_companyprofile_jblt_email_ContactEmailId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_companyprofile
    ADD CONSTRAINT "FK_jblt_companyprofile_jblt_email_ContactEmailId" FOREIGN KEY ("ContactEmailId") REFERENCES public.jblt_email(email_id);


--
-- Name: jblt_companyprofile FK_jblt_companyprofile_jblt_phone_ContactPhoneId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_companyprofile
    ADD CONSTRAINT "FK_jblt_companyprofile_jblt_phone_ContactPhoneId" FOREIGN KEY ("ContactPhoneId") REFERENCES public.jblt_phone(jblt_phoneid);


--
-- Name: jblt_companyprofile FK_jblt_companyprofile_jblt_userAddress_CompanyAddressId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_companyprofile
    ADD CONSTRAINT "FK_jblt_companyprofile_jblt_userAddress_CompanyAddressId" FOREIGN KEY ("CompanyAddressId") REFERENCES public."jblt_userAddress"(address_id);


--
-- Name: jblt_job FK_jblt_job_jblt_company_CompanyDescriptionId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_job
    ADD CONSTRAINT "FK_jblt_job_jblt_company_CompanyDescriptionId" FOREIGN KEY ("CompanyDescriptionId") REFERENCES public.jblt_company(company_id);


--
-- Name: jblt_job FK_jblt_job_jblt_experience_RequiredExperienceId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_job
    ADD CONSTRAINT "FK_jblt_job_jblt_experience_RequiredExperienceId" FOREIGN KEY ("RequiredExperienceId") REFERENCES public.jblt_experience(experience_id);


--
-- Name: jblt_job FK_jblt_job_jblt_qualification_RequiredQualificationId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_job
    ADD CONSTRAINT "FK_jblt_job_jblt_qualification_RequiredQualificationId" FOREIGN KEY ("RequiredQualificationId") REFERENCES public.jblt_qualification(qualification_id);


--
-- Name: jblt_job FK_jblt_job_jblt_skill_SkillsRequiredId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_job
    ADD CONSTRAINT "FK_jblt_job_jblt_skill_SkillsRequiredId" FOREIGN KEY ("SkillsRequiredId") REFERENCES public.jblt_skill(skill_id);


--
-- Name: jblt_job FK_jblt_job_jblt_userAddress_JobAddressId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_job
    ADD CONSTRAINT "FK_jblt_job_jblt_userAddress_JobAddressId" FOREIGN KEY ("JobAddressId") REFERENCES public."jblt_userAddress"(address_id);


--
-- Name: jblt_loginuser FK_jblt_loginuser_jblt_personName_PersonNameId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_loginuser
    ADD CONSTRAINT "FK_jblt_loginuser_jblt_personName_PersonNameId" FOREIGN KEY ("PersonNameId") REFERENCES public."jblt_personName"(personname_id);


--
-- Name: jblt_registerUser FK_jblt_registerUser_jblt_email_UserEmailId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public."jblt_registerUser"
    ADD CONSTRAINT "FK_jblt_registerUser_jblt_email_UserEmailId" FOREIGN KEY ("UserEmailId") REFERENCES public.jblt_email(email_id) ON DELETE CASCADE;


--
-- Name: jblt_registerUser FK_jblt_registerUser_jblt_personName_PersonNameId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public."jblt_registerUser"
    ADD CONSTRAINT "FK_jblt_registerUser_jblt_personName_PersonNameId" FOREIGN KEY ("PersonNameId") REFERENCES public."jblt_personName"(personname_id) ON DELETE CASCADE;


--
-- Name: jblt_seeker FK_jblt_seeker_jblt_education_EducationId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "FK_jblt_seeker_jblt_education_EducationId" FOREIGN KEY ("EducationId") REFERENCES public.jblt_education(education_id);


--
-- Name: jblt_seeker FK_jblt_seeker_jblt_experience_ExperienceId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "FK_jblt_seeker_jblt_experience_ExperienceId" FOREIGN KEY ("ExperienceId") REFERENCES public.jblt_experience(experience_id);


--
-- Name: jblt_seeker FK_jblt_seeker_jblt_phone_PhoneId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "FK_jblt_seeker_jblt_phone_PhoneId" FOREIGN KEY ("PhoneId") REFERENCES public.jblt_phone(jblt_phoneid);


--
-- Name: jblt_seeker FK_jblt_seeker_jblt_qualification_QualificationsId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "FK_jblt_seeker_jblt_qualification_QualificationsId" FOREIGN KEY ("QualificationsId") REFERENCES public.jblt_qualification(qualification_id);


--
-- Name: jblt_seeker FK_jblt_seeker_jblt_skill_SkillsId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "FK_jblt_seeker_jblt_skill_SkillsId" FOREIGN KEY ("SkillsId") REFERENCES public.jblt_skill(skill_id);


--
-- Name: jblt_seeker FK_jblt_seeker_jblt_userAddress_AddressId; Type: FK CONSTRAINT; Schema: public; Owner: leetadmin
--

ALTER TABLE ONLY public.jblt_seeker
    ADD CONSTRAINT "FK_jblt_seeker_jblt_userAddress_AddressId" FOREIGN KEY ("AddressId") REFERENCES public."jblt_userAddress"(address_id);


--
-- PostgreSQL database dump complete
--


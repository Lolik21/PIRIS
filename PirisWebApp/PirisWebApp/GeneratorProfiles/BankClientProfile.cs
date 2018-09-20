using System;
using System.Collections.Generic;
using DataGenerator;
using DataGenerator.Sources;
using PirisWebApp.Models;

namespace PirisWebApp.GeneratorProfiles
{
    public class BankClientProfile : MappingProfile<BankClientViewModel>
    {
        public override void Configure()
        {
            Property(model => model.Name).DataSource<FirstNameSource>();
            Property(model => model.LastName).DataSource<LastNameSource>();
            Property(model => model.Patronymic).DataSource<LastNameSource>();
            Property(model => model.AddressTheActualResidence).DataSource<CitySource>();
            Property(model => model.DateOfBirth).DateTimeSource(DateTime.Now - TimeSpan.FromDays(365 * 100), DateTime.Now);
            Property(model => model.Email).DataSource<EmailSource>();
            Property(model => model.IdentificationNumber).DataSource<GuidSource>();
            Property(model => model.IssueDate).DateTimeSource(DateTime.Now - TimeSpan.FromDays(365 * 100), DateTime.Now);
            Property(model => model.MilitaryService).DataSource(new List<string> {"Yes", "No"});
            Property(model => model.MonthlyIncome).DataSource<DecimalSource>();
            Property(model => model.PassportNumber).DataSource<GuidSource>();
            Property(model => model.PlaceOfBirth).DataSource<CitySource>();
            Property(model => model.Sex).DataSource(new List<string> {"Women", "Men"});
            Property(model => model.ThePost).DataSource<CompanySource>();
            Property(model => model.TheMobilePhone).DataSource<PhoneSource>();
            Property(model => model.TheTelephoneHome).DataSource<PhoneSource>();
            Property(model => model.TheResidenceAddress).DataSource<CitySource>();
            Property(model => model.ThePlaceOfWork).DataSource<CompanySource>();
        }
    }
}
using System;
using System.Security.Cryptography.X509Certificates;
using FluentValidation;
using PirisWebApp.Models.Enums;
using PirisWebApp.Models.Internal;

namespace PirisWebApp.Services
{
    public class BankClientValidator : AbstractValidator<BankClient>
    {
        private const int DaysInYear = 365;
        private const int TheOldestUserAge = 100;
        private const int PassportMaxDuration = 70;
        private const string OnlyTextNotRequiredStringRegexp = "^[a-zA-Zа-яё]*$";

        public BankClientValidator()
        {
            RuleFor(client => client.LastName).NotEmpty()
                .WithMessage("Please specify a clients last name. Field is mandatory");
            RuleFor(client => client.Name).NotEmpty().WithMessage("Please specify a clients name. Field is mandatory");
            RuleFor(client => client.Patronymic).NotEmpty()
                .WithMessage("Please specify a clients patronymic. Field is mandatory");
            RuleFor(client => client.DateOfBirth)
                .ExclusiveBetween(DateTime.Now - TimeSpan.FromDays(DaysInYear * TheOldestUserAge), DateTime.Now)
                .WithMessage($"User cannot be more than {TheOldestUserAge} years old");
            RuleFor(client => client.Sex).NotEmpty().WithMessage("Please specify a clients sex. Field is mandatory");
            RuleFor(client => client.PassportSeries).NotEmpty()
                .WithMessage("Please specify a clients passport series. Field is mandatory");
            RuleFor(client => client.PassportNumber).NotEmpty()
                .WithMessage("Please specify a clients passport number. Field is mandatory");
            RuleFor(client => client.IssuedBy).NotEmpty()
                .WithMessage("Please specify a who issued client passport. Field is mandatory");
            RuleFor(client => client.IssueDate).ExclusiveBetween(DateTime.Now - 
                TimeSpan.FromDays(PassportMaxDuration * DaysInYear), DateTime.Now)
                .WithMessage("Please specify a clients passport number. Field is mandatory");
            RuleFor(client => client.IdentificationNumber).NotEmpty()
                .WithMessage("Please specify a clients identification number. Field is mandatory");
            RuleFor(client => client.PlaceOfBirth).NotEmpty()
                .WithMessage("Please specify a clients place of birth. Field is mandatory");
            RuleFor(client => client.PlaceOfLiving).NotEmpty()
                .WithMessage("Please specify a clients place of living. Field is mandatory");
            RuleFor(client => client.AddressTheActualResidence).NotEmpty()
                .WithMessage("Please specify a clients place of actual residence. Field is mandatory");
            RuleFor(client => client.TheTelephoneHome).Matches("")
                .WithMessage("Invalid home phone.");
            RuleFor(client => client.TheMobilePhone).Matches("")
                .WithMessage("Invalid mobile phone.");
            RuleFor(client => client.Email).EmailAddress().WithMessage("Invalid email address");
            RuleFor(client => client.ThePlaceOfWork).Matches(OnlyTextNotRequiredStringRegexp)
                .WithMessage("Invalid place of work field");
            RuleFor(client => client.ThePost).Matches(OnlyTextNotRequiredStringRegexp)
                .WithMessage("Invalid client position field address");
            RuleFor(client => client.PlaceOfRegistration).NotEmpty()
                .WithMessage("Please specify a clients place of registration. Field is mandatory");
            RuleFor(client => client.TheResidenceAddress).NotEmpty()
                .WithMessage("Please specify a clients residence address. Field is mandatory");
            RuleFor(client => client.Citizenship).NotEmpty()
                .WithMessage("Please specify a clients citizenship. Field is mandatory");
            RuleFor(client => client.Pensioner).NotEmpty()
                .WithMessage("Please specify a if clients is pensioner. Field is mandatory");
            RuleFor(client => client.MonthlyIncome).NotEmpty()
                .WithMessage("Please specify a clients monthly income. Field is mandatory");
            RuleFor(client => client.MilitaryService).NotEmpty()
                .WithMessage("Please specify if clients military service. Field is mandatory");
        }
    }
}
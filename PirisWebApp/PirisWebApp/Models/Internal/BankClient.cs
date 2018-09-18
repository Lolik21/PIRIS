using System;
using PirisWebApp.Models.Enums;

namespace PirisWebApp.Models.Internal
{
    public class BankClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string IssuedBy { get; set; }
        public DateTime IssueDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string PlaceOfBirth { get; set; }
        public string AddressTheActualResidence { get; set; }
        public string TheTelephoneHome { get; set; }
        public string TheMobilePhone { get; set; }
        public string Email { get; set; }
        public string ThePlaceOfWork { get; set; }
        public string ThePost { get; set; }
        public string TheResidenceAddress { get; set; }
        public string Pensioner { get; set; }
        public decimal MonthlyIncome { get; set; }
        public string MilitaryService { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Disability Disability { get; set; }
        public City PlaceOfRegistration { get; set; }
        public City PlaceOfLiving { get; set; }
        public Country Citizenship { get; set; }
    }
}

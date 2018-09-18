using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PirisWebApp.Models.Enums;
using PirisWebApp.Models.Internal;

namespace PirisWebApp.Models
{
    public class BankClientViewModel
    {
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
        public int PlaceOfRegistrationId { get; set; }
        public int PlaceOfLivingId { get; set; }
        public int CitizenshipId { get; set; }
    }
}

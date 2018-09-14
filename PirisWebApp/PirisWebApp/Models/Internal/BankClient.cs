using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PirisWebApp.Models.Enums;

namespace PirisWebApp.Models.Internal
{
    public class BankClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Disability Disability { get; set; }
        public City PlaceOfRegistration { get; set; }
        public City PlaceOfLiving { get; set; }
        public Country Citizenship { get; set; }
    }
}

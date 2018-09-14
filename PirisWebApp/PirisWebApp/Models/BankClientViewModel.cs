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
        public MaritalStatus MaritalStatus { get; set; }
        public Disability Disability { get; set; }
        public int PlaceOfRegistrationId { get; set; }
        public int PlaceOfLivingId { get; set; }
        public int CitizenshipId { get; set; }
    }
}

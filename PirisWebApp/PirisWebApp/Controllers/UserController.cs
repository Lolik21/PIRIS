using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PirisWebApp.Models;
using PirisWebApp.Models.Internal;
using PirisWebApp.Services.Interfaces;

namespace PirisWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AddNewUser()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public string AddNewUser(UserViewModel model)
        {
            var user = _mapper.Map<User>(model);
            _userService.AddUserToDatabase(user);
            return "User was successfully added to database";
        }
    }
}
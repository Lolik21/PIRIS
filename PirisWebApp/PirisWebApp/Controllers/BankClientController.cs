﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataGenerator;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PirisWebApp.GeneratorProfiles;
using PirisWebApp.Models;
using PirisWebApp.Models.Enums;
using PirisWebApp.Models.Internal;
using PirisWebApp.Services;
using PirisWebApp.Services.Interfaces;

namespace PirisWebApp.Controllers
{
    public class BankClientController : Controller
    {
        private readonly IBankClientService _bankClientService;
        private readonly IMapper _mapper;
        private readonly ICityService _cityService;
        private readonly ICountryService _countryService;

        public BankClientController(IBankClientService bankClientService, ICityService cityService, 
            ICountryService countryService, IMapper mapper)
        {
            _bankClientService = bankClientService;
            _mapper = mapper;
            _cityService = cityService;
            _countryService = countryService;
            Generator.Default.Configure(c => c
                .Profile<BankClientProfile>()
            );
        }
        
        [HttpGet]
        public async Task<IActionResult> OpenBankClientList()
        {
            var dbClients = await _bankClientService.GetAllClients();
            var viewClients = dbClients.Select(client => _mapper.Map<OpenClientViewModel>(client));
            return View(viewClients);
        }

        [HttpGet]
        public async Task<IActionResult> AddNewBankClient()
        {
            
            var cities = await _cityService.GetAllCites();
            var countries = await _countryService.GetAllCountries();
            var selectedListCurrentCities = new SelectList(cities, "Id", "Name");
            var selectedListCountries = new SelectList(countries, "Id", "Name");
            var selectedListRegistrationCities = new SelectList(cities, "Id", "Name");
            selectedListCurrentCities.First().Selected = true;
            selectedListCountries.First().Selected = true;
            selectedListRegistrationCities.First().Selected = true;
            ViewBag.PlaceOfLiving = selectedListCurrentCities;
            ViewBag.PlaceOfRegistration = selectedListRegistrationCities;
            ViewBag.Citizenship = selectedListCountries;
            var model = Generator.Default.Single<BankClientViewModel>();
            model.Errors = new List<string>();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBankClient(BankClientViewModel model)
        {
            var validator = new BankClientValidator();
            ValidationResult results = validator.Validate(model);
            if (results.IsValid)
            {
                var user = _mapper.Map<BankClient>(model);
                await _bankClientService.AddClientToDatabase(user);
                return RedirectToAction("OpenBankClientList");
            }

            var cities = await _cityService.GetAllCites();
            var countries = await _countryService.GetAllCountries();
            var selectedListCurrentCities = new SelectList(cities, "Id", "Name");
            var selectedListCountries = new SelectList(countries, "Id", "Name");
            var selectedListRegistrationCities = new SelectList(cities, "Id", "Name");
            selectedListCurrentCities.First().Selected = true;
            selectedListCountries.First().Selected = true;
            selectedListRegistrationCities.First().Selected = true;
            ViewBag.PlaceOfLiving = selectedListCurrentCities;
            ViewBag.PlaceOfRegistration = selectedListRegistrationCities;
            ViewBag.Citizenship = selectedListCountries;
            model.Errors = results.Errors.Select((item) => item.ErrorMessage).ToList();
            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            _bankClientService.DeleteBankClient(Id);
            return RedirectToAction("OpenBankClientList");
        }

    }
}
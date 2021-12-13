﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using project.Data;
using project.Models;
using project.ViewModels;


namespace project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepo;
        private readonly ILogger<ActorController> _logger;

        public CountryController(ICountryRepository countryRepo, ILogger<ActorController> logger)
        {
            _countryRepo = countryRepo?? throw new ArgumentNullException(nameof(countryRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IEnumerable<Country>> GetAll()
        {
            List<Country> countries = await _countryRepo.GetAll();
            return countries;
        }
    }
}

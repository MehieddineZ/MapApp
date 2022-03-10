using MapApp.Models;
using MapApp.Models.MapAppModel;
using MapApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapApp.Controllers
{
    public class MapAppController : Controller
    {
        private readonly IMapAppRepository _MapAppRepository;
        public MapAppController(IMapAppRepository MapAppRepository) 
        {
            _MapAppRepository = MapAppRepository;
        }
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "MapApp", new { city = model.CityName });

            }
            return View(model);
        }
        [HttpGet]
        public IActionResult City(string city)
        {
            MapAppResponse mapappresponse = _MapAppRepository.Getaddress(city);
            City viewModel = new City();
            
            if (mapappresponse != null)
            {
                viewModel.Name = mapappresponse.items[0].title;
                viewModel.countryName = mapappresponse.items[0].address.countryName;
                viewModel.cityName = mapappresponse.items[0].address.city;
                viewModel.street = mapappresponse.items[0].address.street;
                viewModel.lat = mapappresponse.items[0].position.lat;
                viewModel.lng = mapappresponse.items[0].position.lng;

            }
            return View(viewModel);
        }
    }
}

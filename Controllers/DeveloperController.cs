using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstRepository.Domain;
using FirstRepository.Repository;

namespace FirstRepository.Controllers
{
    [ApiController]
    [Route("/developer")]
    public class DeveloperController : ControllerBase
    {

        [HttpGet("ChoiseDistributor")]
        public string ChoiseDistributor(string str)
        {
            return str;// " Метод выбора дистрибьютера";
        }

        [HttpGet("ViewSalesResult")]
        public string ViewSalesResult(string str)
        {
            return str;// "Метод просмотра результата продаж";
        }

        [HttpGet("PlacementPO")]
        public string PlacementPO(string str)
        {
            return str;// "Метод размещение ПО";
        }

        [HttpPut("Create")]
        public Developer Create(Developer developer)
        {
            Storage.DeveloperStorage.Create(developer);
            return Storage.DeveloperStorage.Read(developer.Id);
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;
        }
    }
}

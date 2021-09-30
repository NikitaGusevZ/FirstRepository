using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


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
    }
}

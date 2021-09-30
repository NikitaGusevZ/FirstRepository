using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstRepository.Controllers
{
    [ApiController]
    [Route("/customer")]
    public class CustomerController : ControllerBase
    {

        [HttpGet("SearchPO")]
        public string SearchPO(string str)
        {
            return str; //"Метод поиска ПО";
        }

        [HttpGet("BuyPO")]
        public string BuyPO(string str)
        {
            return str;// "Метод покупки ПО";
        }


        [HttpGet("DownloadPO")]
        public string DownloadPO(string str)
        {
            return str;// "Метод скачивания ПО";
        }

        
        [HttpGet("GradePO")]
        public string GradePO(string str)
        {
            return str;//"Метод оценки ПО";
        }

    }

    [ApiController]
    [Route("/distributor")]
    public class DistributorController : ControllerBase
    {

        [HttpGet("Confirmation")]
        public string Confirmation(string str)
        {
            return str; // "Метод подтверждения размещения ПО";
        }

        [HttpGet("Price_Setting")]
        public string Price_Setting(string str)
        {
            return str;// "Метод установки цен и акций ПО";
        }

        [HttpGet("Transfer")]
        public string Transfer(string str)
        {
            return str;// "Метод перечисления средств разработчику";
        }

        [HttpGet("ViewSales")]
        public string ViewSales(string str)
        {
            return str;// "Метод просмотра продаж";
        }
    }

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

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
            return "Метод поиска ПО";
        }

        [HttpGet("BuyPO")]
        public string BuyPO(string str)
        {
            return "Метод покупки ПО";
        }

        [HttpGet("DownloadPO")]
        public string DownloadPO(string str)
        {
            return "Метод скачивания ПО";
        }

        [HttpGet("GradePO")]
        public string GradePO(string str)
        {
            return "Метод оценки ПО";
        }

    }

    [ApiController]
    [Route("/distributor")]
    public class DistributorController : ControllerBase
    {
        [HttpGet("Confirmation")]
        public string Confirmation(string str)
        {
            return "Метод подтверждения размещения ПО";
        }

        [HttpGet("Price_Setting")]
        public string Price_Setting(string str)
        {
            return "Метод установки цен и акций ПО";
        }

        [HttpGet("Transfer")]
        public string Transfer(string str)
        {
            return "Метод перечисления средств разработчику";
        }

        [HttpGet("ViewSales")]
        public string ViewSales(string str)
        {
            return "Метод просмотра продаж";
        }
    }

    [ApiController]
    [Route("/developer")]
    public class DeveloperController : ControllerBase
    {

        [HttpGet("ChoiseDistributor")]
        public string ChoiseDistributor(string str)
        {
            return "Метод выбора дистрибьютера";
        }

        [HttpGet("ViewSalesResult")]
        public string ViewSalesResult(string str)
        {
            return "Метод просмотра результата продаж";
        }

        [HttpGet("PlacementPO")]
        public string PlacementPO(string str)
        {
            return "Метод размещение ПО";
        }
    }
}

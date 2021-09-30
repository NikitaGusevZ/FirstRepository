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

        [HttpGet]
        [Route("/customer/SearchPO")]
        public string SearchPO(string str)
        {
            return "Метод поиска ПО";
        }

        [HttpGet]
        [Route("/customer/BuyPO")]
        public string BuyPO(string str)
        {
            return "Метод покупки ПО";
        }

        [HttpGet]
        [Route("/customer/DownloadPO")]
        public string DownloadPO(string str)
        {
            return "Метод скачивания ПО";
        }

        [HttpGet]
        [Route("/customer/GradePO")]
        public string GradePO(string str)
        {
            return "Метод оценки ПО";
        }

    }

    [ApiController]
    [Route("/distributor")]
    public class DistributorController : ControllerBase
    {
        [HttpGet]
        [Route("/distributor/Confirmation")]
        public string Confirmation(string str)
        {
            return "Метод подтверждения размещения ПО";
        }

        [HttpGet]
        [Route("/distributor/Price_Setting")]
        public string Price_Setting(string str)
        {
            return "Метод установки цен и акций ПО";
        }

        [HttpGet]
        [Route("/distributor/Transfer")]
        public string Transfer(string str)
        {
            return "Метод перечисления средств разработчику";
        }

        [HttpGet]
        [Route("/distributor/ViewSales")]
        public string ViewSales(string str)
        {
            return "Метод просмотра продаж";
        }
    }

    [ApiController]
    [Route("/Developer")]
    public class DeveloperController : ControllerBase
    {
        [HttpGet]
        [Route("/distributor/ChoiseDistributor")]
        public string ChoiseDistributor(string str)
        {
            return "Метод выбора дистрибьютера";
        }

        [HttpGet]
        [Route("/distributor/ViewSalesResult")]
        public string ViewSalesResult(string str)
        {
            return "Метод просмотра результата продаж";
        }

        [HttpGet]
        [Route("/distributor/PlacementPO")]
        public string PlacementPO(string str)
        {
            return "Метод размещение ПО";
        }
    }
}

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

        [HttpPut("Create")]
        public Distributor Create(Distributor distributor)
        {
            Storage.DistributorStorage.Create(distributor);
            return Storage.DistributorStorage.Read(distributor.Id);
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

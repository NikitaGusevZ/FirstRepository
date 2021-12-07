using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRepository.Domain;
using FirstRepository.Repository;
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

        [HttpPut]
        public Customer Create(Customer customer)
        {
            Storage.CustomerStorage.Create(customer);
            return Storage.CustomerStorage.Read(customer.Id);
        }

        [HttpGet]
        public Customer Read(int Id)
        {
            return Storage.CustomerStorage.Read(Id);
        }

        [HttpPatch]
        public Customer Update(int Id, Customer newCustomer)
        {
            return Storage.CustomerStorage.Update(Id,newCustomer);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.CustomerStorage.Delete(Id);
        }
    }
}

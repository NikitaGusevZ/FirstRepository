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
}

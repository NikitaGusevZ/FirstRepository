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
    [Route("/shoppingBasket")]
    public class ShoppingBasketController : ControllerBase
    {

        [HttpPut("Create")]
        public ShoppingBasket Create(ShoppingBasket shoppingBasket)
        {
            Storage.ShoppingBasketStorage.Create(shoppingBasket);
            return Storage.ShoppingBasketStorage.Read(shoppingBasket.Id);
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

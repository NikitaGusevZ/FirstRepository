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
        public ShoppingBasket Read(int Id)
        {
            return Storage.ShoppingBasketStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public ShoppingBasket Update(int Id, ShoppingBasket newShoppingBasket)
        {
            return Storage.ShoppingBasketStorage.Update(Id,newShoppingBasket);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.ShoppingBasketStorage.Delete(Id);
        }
    }
}

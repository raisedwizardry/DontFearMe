using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DontFearMe.Shared.Models;
using DontFearMe.Server.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DontFearMe.Server.Controllers
{
    public class CoinController : Controller
    {
        CoinOperations objcoin = new CoinOperations();
        // GET: api/<controller>
        [HttpGet]
        [Route("api/Coin/Index")]
        public IEnumerable<Coin> Get()
        {
            return objcoin.GetAllCoins();
        }
        [HttpPost]
        [Route("api/Coin/Create")]
        public void Create([FromBody] Coin coin)
        {
            if (ModelState.IsValid)
                objcoin.AddEmployee(coin);
        }

        [HttpGet]
        [Route("api/Coin/Details/{id}")]
        public Coin Details(int id)
        {

            return objcoin.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Coin/Edit")]
        public void Edit([FromBody]Coin coin)
        {
            if (ModelState.IsValid)
                objcoin.UpdateEmployee(coin);
        }

        [HttpDelete]
        [Route("api/Coin/Delete/{id}")]
        public void Delete(int id)
        {
            objcoin.DeleteEmployee(id);
        }
    }
}

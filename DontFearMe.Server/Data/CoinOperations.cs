using DontFearMe.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DontFearMe.Server.Data
{
    public class CoinOperations
    {
        CoinContext db = new CoinContext();
        public IEnumerable<Coin> GetAllCoins()
        {
             try  
            {
                return db.Coin.ToList();
            }  
            catch  
            {
                throw;
            }
        }

        public void AddEmployee(Coin coin)
        {
            try
            {
                db.Coin.Add(coin);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void UpdateEmployee(Coin coin)
        {
            try
            {
                db.Entry(coin).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public Coin GetEmployeeData(int id)
        {
            try
            {
                Coin coin = db.Coin.Find(id);
                return coin;
            }
            catch
            {
                throw;
            }
        }
        public void DeleteEmployee(int id)
        {
            try
            {
                Coin coin = db.Coin.Find(id);
                db.Coin.Remove(coin);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}

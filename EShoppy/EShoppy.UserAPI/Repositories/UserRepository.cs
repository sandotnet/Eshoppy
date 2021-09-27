using EShoppy.UserAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.UserAPI.Repositories;
using EShoppy.UserAPI.DBContext;
namespace EShoppy.UserAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EShoppyDBContext context;

        public UserRepository(EShoppyDBContext context)
        {
            this.context = context;
        }

        public Item GetItem(string itemName)
        {
            try
            {
                return context.Items.SingleOrDefault(i => i.ItemName == itemName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void OrderItem(Order order)
        {
            try
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AdminAPI.Entities;
namespace EShoppy.AdminAPI.Services
{
   public interface IAdminService
    {
        void AddItem(Item item);
        List<Item> GetItems();
        void UpdateItem(Item item);
        void DeleteItem(string itemId);
    }
}

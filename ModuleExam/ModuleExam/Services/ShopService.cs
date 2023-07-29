using Microsoft.EntityFrameworkCore;
using ModuleExam.Data;

namespace ModuleExam.Services
{
    public class ShopService : IShopService
    {
        private readonly AppDbContext _context;

        public Shop GetShop(int id)
        {
            var shop = _context.Shops.FirstOrDefault(x => x.ShopId == id);
            return shop;
        }

        public ShopService(AppDbContext context)
        {

            _context = context;
        }

        public List<Shop> GetAllShop()
        {
            try
            {
                var shops = _context.Shops.ToList();
                return shops;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteShop(int id)
        {
            var itemToDelete = _context.Shops.FirstOrDefault(x => x.ShopId == id);
            _context.Shops.Remove(itemToDelete);
            _context.SaveChanges();
        }

        public void UpdateShop(int id, Shop shop)
        {

            if (id != shop.ShopId)
            {
                throw new Exception("id not found");
            }


            _context.Entry(shop).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateShop(Shop shop)
        {
            var result = _context.Shops.Add(shop);
            _context.SaveChanges();
        }


    }
}


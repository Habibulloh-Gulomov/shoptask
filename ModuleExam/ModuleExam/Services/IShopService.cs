namespace ModuleExam.Services
{
   
        public interface IShopService
        {
            public void CreateShop(Shop item);
            public List<Shop> GetAllShop();
            public Shop GetShop(int id);
            public void DeleteShop(int id);
            public void UpdateShop(int id, Shop shop);
        }
    
}

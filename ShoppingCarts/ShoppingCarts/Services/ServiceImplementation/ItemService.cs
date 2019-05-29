using ShoppingCarts.Helpers;
using ShoppingCarts.Model;
using ShoppingCarts.Services.ServiceInterface;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShoppingCarts.Services.ServiceImplementation.ItemService))]

namespace ShoppingCarts.Services.ServiceImplementation
{
    public class ItemService : IItemService
    {
        private List<Item> Items;

        public ItemService()
        {
            Items = new List<Item>();
        }

        public async Task<List<Item>> GetItems()
        {
            Items.Clear();

            Items.Add(new Item
            {
                Image = "https://lc-www-live-s.legocdn.com/r/www/r/catalogs/-/media/catalogs/products/nexo%20knights/2016/box%20shot%201488x837/lego_70324_box1_in_1488.png?l.r2=670878192",
                Name = "Item 1",
                Index = 1,
                Status = Settings.ItemStatus1,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "C:/Xamarin-Forms-Shopping-Cart-master/ShoppingCarts/ShoppingCarts/Images/#2.jpg",
                Name = "Item 2",
                Index = 2,
                Status = Settings.ItemStatus2,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://www.shareicon.net/data/128x128/2016/05/04/759712_jar_512x512.png",
                Name = "Item 3",
                Index = 3,
                Status = Settings.ItemStatus3,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });

            Items.Add(new Item
            {
                Image = "https://www.shareicon.net/data/128x128/2016/11/15/853021_jar_512x512.png",
                Name = "Jug",
                Index = 4,
                Status = Settings.ItemStatus4,
                Description = Constants.Description,
                ShortDescription = Constants.ShortDescription
            });
      

            return await Task.FromResult(Items);
        }
    }
}
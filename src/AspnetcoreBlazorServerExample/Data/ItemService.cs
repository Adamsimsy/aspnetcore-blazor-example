using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetcoreBlazorServerExample.Models;

namespace AspnetcoreBlazorServerExample.Data
{
    public class ItemService
    {
        public Task<List<Category>> GetAllCategoriesAsync()
        {
            var items = new List<Item>()
            {
                new Item()
                {
                    Name = "Item 1",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA04LKK_236742_210x210.jpg",
                    Price = 65.23M
                },
                new Item()
                {
                    Name = "Item 2",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA04LKK_236742_210x210.jpg",
                    Price = 23.53M
                },
                new Item()
                {
                    Name = "Item 3",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA04LKK_236742_210x210.jpg",
                    Price = 12.78M
                },
                new Item()
                {
                    Name = "Item 4",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA04LKK_236742_210x210.jpg",
                    Price = 12.78M
                },
                new Item()
                {
                    Name = "Item 5",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA04LKK_236742_210x210.jpg",
                    Price = 12.78M
                },
                new Item()
                {
                    Name = "Item 6",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA04LKK_236742_210x210.jpg",
                    Price = 12.78M
                }                      
            };

            var categories = new List<Category>()
            {
                new Category()
                {
                    Name = "Case",
                    Items = items
                },
                new Category()
                {
                    Name = "Motherboard",
                    Items = items
                },
                new Category()
                {
                    Name = "CPU",
                    Items = items
                },
                new Category()
                {
                    Name = "RAM",
                    Items = items
                },                                                
            };

            return Task.FromResult(categories);
        }
    }
}

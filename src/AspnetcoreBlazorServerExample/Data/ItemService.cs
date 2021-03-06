using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspnetcoreBlazorServerExample.Models;

namespace AspnetcoreBlazorServerExample.Data
{
    public class ItemService
    {
        public Task<List<Category>> GetAllCategoriesAsync()
        {

            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\\store.json");  
            var json = System.IO.File.ReadAllText(folderDetails);  
            var jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Category>>(json);


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
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA03GKK_200907_210x210.jpg",
                    Price = 23.53M
                },
                new Item()
                {
                    Name = "Item 3",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA09BZA_200461_210x210.jpg",
                    Price = 12.78M,
                    Selected = true
                },
                new Item()
                {
                    Name = "Item 4",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB574GI_189798_285x255.png",
                    Price = 12.78M
                },
                new Item()
                {
                    Name = "Item 5",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB57XGI_217170_285x255.png",
                    Price = 12.78M
                },
                new Item()
                {
                    Name = "Item 6",
                    Image = "https://www.overclockers.co.uk/media/image/thumbnail/MY0A9TG_237665_285x255.jpg",
                    Price = 12.78M
                }                      
            };

            var categories = new List<Category>()
            {
                new Category()
                {
                    Name = "Case",
                    Items = new List<Item>()
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
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA03GKK_200907_210x210.jpg",
                            Price = 23.53M
                        },
                        new Item()
                        {
                            Name = "Item 3",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA09BZA_200461_210x210.jpg",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 4",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB574GI_189798_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 5",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB57XGI_217170_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 6",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MY0A9TG_237665_285x255.jpg",
                            Price = 12.78M
                        }                      
                    }
                },
                new Category()
                {
                    Name = "Motherboard",
                    Items = new List<Item>()
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
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA03GKK_200907_210x210.jpg",
                            Price = 23.53M
                        },
                        new Item()
                        {
                            Name = "Item 3",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA09BZA_200461_210x210.jpg",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 4",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB574GI_189798_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 5",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB57XGI_217170_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 6",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MY0A9TG_237665_285x255.jpg",
                            Price = 12.78M
                        }                      
                    }
                },
                new Category()
                {
                    Name = "CPU",
                    Items = new List<Item>()
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
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA03GKK_200907_210x210.jpg",
                            Price = 23.53M
                        },
                        new Item()
                        {
                            Name = "Item 3",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA09BZA_200461_210x210.jpg",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 4",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB574GI_189798_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 5",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB57XGI_217170_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 6",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MY0A9TG_237665_285x255.jpg",
                            Price = 12.78M
                        }                      
                    }
                },
                new Category()
                {
                    Name = "RAM",
                    Items = new List<Item>()
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
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA03GKK_200907_210x210.jpg",
                            Price = 23.53M
                        },
                        new Item()
                        {
                            Name = "Item 3",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/CA09BZA_200461_210x210.jpg",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 4",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB574GI_189798_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 5",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MB57XGI_217170_285x255.png",
                            Price = 12.78M
                        },
                        new Item()
                        {
                            Name = "Item 6",
                            Image = "https://www.overclockers.co.uk/media/image/thumbnail/MY0A9TG_237665_285x255.jpg",
                            Price = 12.78M
                        }                      
                    }
                },                                                
            };

            return Task.FromResult(jsonObj);
        }
    }
}

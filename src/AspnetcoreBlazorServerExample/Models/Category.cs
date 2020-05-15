using System.Collections.Generic;

namespace AspnetcoreBlazorServerExample.Models
{
    public class Category
    {
        public string Name { get; set; }
        
        public List<Item> Items { get; set; }
    }
}
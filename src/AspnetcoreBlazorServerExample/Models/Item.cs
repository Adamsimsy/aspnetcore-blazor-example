using System;

namespace AspnetcoreBlazorServerExample.Models
{
    public class Item
    {
        public Item()
        {
            Id = Guid.NewGuid();            
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public bool Selected { get; set; }
    }
}
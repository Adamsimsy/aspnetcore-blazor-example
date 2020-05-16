using System;
using System.Collections.Generic;
using System.Linq;

namespace AspnetcoreBlazorServerExample.Models
{
    public class Category
    {
        public Category()
        {
            Id = Guid.NewGuid();            
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public List<Item> Items { get; set; }

        public void SetSelected(Guid id)
        {
            Items.ForEach(i => i.Selected = (i.Id == id) ? true : false);
        }

        public void SetRemoved(Guid id)
        {
            Items.SingleOrDefault(i => i.Id == id).Selected = false;
        }
    }
}
using System;
using System.Collections.Generic;

namespace RainbowItemsCodeGenerator.Model
{
    public class Item
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public IEnumerable<Item> Inheritance { get; set; }
            
        public IEnumerable<Field> Fields { get; set; }
    }
}

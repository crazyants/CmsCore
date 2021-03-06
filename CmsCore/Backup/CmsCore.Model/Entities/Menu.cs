﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsCore.Model.Entities
{
    public class Menu:BaseEntity
    {
        public Menu()
        {
            MenuItems = new HashSet<MenuItem>();
        }
        public string Name { get; set; }

        public int? MenuLocationId { get; set; }
        public virtual MenuLocation MenuLocation { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}

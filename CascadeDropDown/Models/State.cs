﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropDown.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
    }

    
}
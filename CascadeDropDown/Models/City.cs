using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropDown.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
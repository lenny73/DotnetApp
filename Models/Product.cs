using System;
using System.Collections.Generic;

namespace Application.Models
{
    public class Product : Entity
    {
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        
        public List<Part> Parts { get; set; }
        public Round Round { get; set; }
    }
}
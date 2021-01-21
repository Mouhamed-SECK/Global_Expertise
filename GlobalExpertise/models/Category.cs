using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GlobalExpertise.models
{
    public class Category
    {
        [Key]
        public int catregoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}

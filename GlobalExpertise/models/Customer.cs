using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GlobalExpertise.models
{
    class Customer 
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string IdCardNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }




    }
}

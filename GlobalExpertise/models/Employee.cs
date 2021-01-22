using System.ComponentModel.DataAnnotations;

namespace GlobalExpertise.models
{



    public class Employee
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
        [StringLength(150)]
        public string Password { get; set; }

        public int DepartementId { get; set; }


        public virtual Departement Departement { get; set; }




    }
}

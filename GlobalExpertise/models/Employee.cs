using System.ComponentModel.DataAnnotations;

namespace GlobalExpertise.models
{

    public enum DEPARTEMENT { Commande, Livraison, Comptable, Admin };

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

        [Required]
        public DEPARTEMENT Departement { get; set; }

      

    }
}

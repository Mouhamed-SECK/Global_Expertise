using System.ComponentModel.DataAnnotations;
using GlobalExpertise.Utils;

namespace GlobalExpertise.models
{
    public class Employee : EntityValidator
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(150), EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        public int DepartementId { get; set; }

        public virtual Departement Departement { get; set; }

    }
}

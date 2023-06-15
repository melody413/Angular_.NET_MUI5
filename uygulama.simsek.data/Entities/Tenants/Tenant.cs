using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using uygulama.simsek.data.Helpers;

namespace uygulama.simsek.data.Entities.Tenants
{
    public class Tenant:BaseEntity
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } // user input
        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string County { get; set; }

        [MaxLength(10)]
        public string Administration { get; set; }
        public int TaxNumber { get; set; }

        [MaxLength(50)]
        public string AuthorizedName { get; set; }
        [MaxLength(50)]
        public string Telephone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(500)]
        public string Explanation { get; set; }

        public bool IsActive { get; set; }
        [MaxLength(500)]
        public string PassiveReason { get; set; }
    }
}

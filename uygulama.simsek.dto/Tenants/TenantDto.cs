using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace uygulama.simsek.dto.Tenants
{
    public class TenantDto
    {
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

        //CreatedBy(userid)
        //CreatedOn(datetime)
        //LastModifiedBy(UserId)
        //LastModifiedOn(datetime)
        //DeletedBy(userId)
        //DeletedOn(datetime)
    }
}

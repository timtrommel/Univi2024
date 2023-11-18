using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univi.Shared
{
    public class Department
    {

        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name = "Naam")]
        public required string Name { get; set; }
        [Display(Name = "Adres")]
        public required string Adress { get; set; }
        [Display(Name = "Postcode")]
        public required string PostalCode { get; set; }
        [Display(Name = "Huisnummer")]
        public required int HouseNumber { get; set; }
        [Display(Name = "Land")]
        public required string Country { get; set; }
        [Display(Name = "Telefoon")]
        public required string Phone { get; set;}
        [Display(Name = "Email")]
        public required string Email { get; set;}
        [Display(Name = "Afdelingshoofd")]
        public string? Departmenthead { get; set; }

    }
}

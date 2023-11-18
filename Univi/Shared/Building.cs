using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univi.Shared
{
    public class Building
    {

        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name="Gebouw")]
        public required string Name { get; set; }
        [Display(Name="Adres")]
        public required string Adress { get; set; }
        [Display(Name="Postcode")]
        public required string PostalCode { get; set; }
        [Display(Name="Plaats")]
        public required string City { get; set; }
        [Display(Name="Provincie")]
        public required string Province { get; set; }
        [Display(Name="Land")]
        public required string Country { get; set; }
    }
}

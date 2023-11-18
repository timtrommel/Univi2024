using System.ComponentModel.DataAnnotations;

namespace Univi.Shared
{
    public class KindOfReport
    {
        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name = "Naam")]
        public required string Name { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Univi.Shared
{
    public class KeyList
    {

        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name="Sleutel")]
        public required string Name { get; set; }
        [Display(Name="Sleutelnummer")]
        public int KeyNumber { get; set; }
        [Display(Name="Retour")]
        public bool IsReturned { get; set; }

    }
}

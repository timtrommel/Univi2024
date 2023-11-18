using System.ComponentModel.DataAnnotations;

namespace Univi.Shared
{
    public class Malfunction
    {
        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name ="Soort")]
        public int KindofMalfunctionId { get; set; }
        [Display(Name = "Gebouw")]
        public int BuildingId { get; set; }
        [Display(Name = "Omschrijving")]
        public required string Description { get; set; }
        [Display(Name = "Afgesloten")]
        public bool IsClosed { get; set; }

        //User information
        [Display(Name = "Toegevoegd door")]
        public int AddedByUserId { get; set; }
        [Display(Name = "Laatst gewijzigd door")]
        public int LastEditByUserId { get; set; }
        [Display(Name = "Afgesloten door")]
        public int ClosedByUserId { get; set; }
        [Display(Name = "Toegewezen aan")]
        public int AssignedToDepartmentId{ get; set; }

        //Date information
        [Display(Name = "Aangemaakt op")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "afgesloten op")]
        public DateTime DateFinished { get; set; }
        [Display(Name = "Datum geupdate")]
        public DateTime DateUpdated { get; set; }

        public KindofMalfunction? kindofmalfunctions { get; set; }
    }
}

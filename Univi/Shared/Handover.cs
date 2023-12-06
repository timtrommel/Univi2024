using System.ComponentModel.DataAnnotations;

namespace Univi.Shared
{
    public class Handover
    {
        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "De titel is verplicht")]
        public string? Title { get; set; }
        [Display(Name = "omschrijving")]
        [Required(ErrorMessage = "De omschrijving is verplicht")]
        public string? Description { get; set; }
        [Display(Name = "Soort")]
        [Required(ErrorMessage = "Het soort is verplicht")]
        public int KindofHandoverId { get; set; }
        [Display(Name = "Gebouw")]
        [Required(ErrorMessage = "Het gebouw is verplicht")]
        public  int BuildingId { get; set; }
        public bool IsActive { get; set; } = true;
        public bool NoStartEnd { get; set; }
        public string? ReportNo { get; set; }

        //Date information
        [Display(Name = "Datum aangemaakt")]
        public  DateTime DateCreated { get; set; }
        [Display(Name = "Datum ")]
        public  DateTime DateHandover { get; set; } // Sets the date on which date the handover is related to.
        [Display(Name = "Laatst gewijzigd")]
        public  DateTime DateLastEdit { get; set; }
        public DateTime DateArchived { get; set; }

        // If the handover has a start and a end date
        [Display(Name = "Startdatum")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Starttijd")]
        public DateTime StartTime { get; set; }
        [Display(Name = "Einddatum")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Eindtijd")]
        public DateTime EndTime { get; set; }

        //User related information
        [Display(Name = "Toegevoegd door")]
        public  string? AddedById { get; set; }
        [Display(Name = "Laatst aangepast door")]
        public string? LastEditById { get; set; }
        [Display(Name = "Geachiveerd door")]
        public string? ArchivedById { get; set; }

        //Information about a related person
        [Display(Name = "Voornaam")]
        public string? FirstName { get; set; }
        [Display(Name = "Achternaam")]
        public string? LastName { get; set; }
        [Display(Name = "Geboortedatum")]
        public string? DateOfBirth { get; set; }
        [Display(Name = "Patiëntennummer")]
        public string? PatiëntNumber { get; set; }
        [Display(Name = "Telefoon")]
        public string? PhoneNumber { get; set;}
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Display(Name = "Overige informatie")]
        public string? OtherInformation { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;

namespace Univi.Shared
{
    public class KeyIssue
    {
        //General information
        [Key]
        public int Id { get; set; }
        public int KeyId { get; set; }
        public bool IsRenturned { get; set; }

        //Date information
        [Display(Name ="Datum aangemaakt")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Datum retour")]
        public DateTime DateReturned { get; set; }

        //User information
        [Display(Name = "Uitgegeven door")]
        public int IssuedByUserId { get; set; }
        [Display(Name = "Retour gemeld door")]
        public int ReturnedByUserId { get; set; }

        //Issue information if not employee

        [Display(Name = "Voornaam")]
        public string? FirstName { get; set; }
        [Display(Name = "Achternaam")]
        public string? LastName { get; set; }
        [Display(Name = "Bedrijf")]
        public string? Company { get; set; }
        [Display(Name = "Telefoon")]
        public string? Phone { get; set; }
        [Display(Name = "Email")]
        public string? Email { get; set; }

        //Issue information for a employee
        [Display(Name = "Personeelsnummer")]
        public int EmployeeId { get; set; }
        [Display(Name = "Naam")]
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
  
        public KeyList? Keylist { get; set; }
        public Department? Department { get; set; }
    }
}

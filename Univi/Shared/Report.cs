using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univi.Shared
{
    public class Report
    {
        //General information
        [Key]
        public int Id { get; set; }
        [Display(Name ="Rapportnummer")]
        public int ReportNumber { get; set; }
        [Display(Name ="Soort")]
        public int KindofReportID { get; set; }
        [Display(Name ="Omschrijving")]
        public int BuildingID { get; set; }
        public required string Description { get; set; }
        [Display(Name ="Afgesloten")]
        public bool IsClosed { get; set; }
        public bool AttentionRequired { get; set; }


        //Date information
        [Display(Name = "Datum aangemaakt")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Datum laatst gewijzigd")]
        public DateTime DateLastEdit { get; set; }
        [Display(Name = "Datum afgesloten")]
        public DateTime DateClosed { get; set; }

        //User related information
        [Display(Name = "Toegevoegd door")]
        public int CreatedById { get; set; }
        [Display(Name = "Laatst gewijzigd door")]
        public int LastEditById { get; set; }
        [Display(Name = "Afgesloten door")]
        public int ClosedById { get; set; }

        //Information about a related person

        //If the person is a empoyee
        [Display(Name = "Naam medewerker")]
        public string? EmpoyeeName { get; set; }
        [Display(Name = "Email medewerker")]
        public string? EmployeeEmail { get; set; }
        [Display(Name = "Telefoon medewerker")]
        public string? EmployeePhone { get; set; }
        [Display(Name = "Personeelsnummer")]
        public string? EmployeeId { get; set; }

        //If the person is not a employee
        //#1
        [Display(Name = "Voornaam")]
        public string? FirstName { get; set; }
        [Display(Name = "Achternaam")]
        public string? LastName { get; set; }
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Display(Name = "Telefoon")]
        public string? Phone { get; set; }
        [Display(Name = "Bedrijf")]
        public string? Company { get; set; }


        //#2
        [Display(Name = "Voornaam")]
        public string? FirstName1 { get; set; }
        [Display(Name = "Achternaam")]
        public string? LastName1 { get; set; }
        [Display(Name = "Email")]
        public string? Email1 { get; set; }
        [Display(Name = "Telefoon")]
        public string? Phone1 { get; set; }
        [Display(Name = "Bedrijf")]
        public string? Company1 { get; set; }


        //#3
        [Display(Name = "Voornaam")]
        public string? FirstName2 { get; set; }
        [Display(Name = "Achternaam")]
        public string? LastName2 { get; set; }
        [Display(Name = "Email")]
        public string? Email2 { get; set; }
        [Display(Name = "Telefoon")]
        public string? Phone2 { get; set; }
        [Display(Name = "Bedrijf")]
        public string? Company2 { get; set; }

        //#4
        [Display(Name = "Voornaam")]
        public string? FirstName3 { get; set; }
        [Display(Name = "Achternaam")]
        public string? LastName3 { get; set; }
        [Display(Name = "Email")]
        public string? Email3 { get; set; }
        [Display(Name = "Telefoon")]
        public string? Phone3 { get; set; }
        [Display(Name = "Bedrijf")]
        public string? Company3 { get; set; }

        public KindOfReport? KindOfReport { get; set; }
        public Building? Building { get; set; }

    }
}

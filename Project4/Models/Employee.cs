using System;
using System.ComponentModel.DataAnnotations;

namespace Project4.Models
{
    public class Employee {

        [Key]
        [Required]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool International { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string ExpectedHours { get; set; }
        //Fall, winter, spring, or summer only
        public string Semester { get; set; }
        public int Year { get; set; }
        public string Phone { get; set; }
        public int ByuId { get; set; }
        //TA, RA, Office, Student Instructor, or Other
        public string PositionType { get; set; }
        public string ClassCode { get; set; }
        //0-3
        public int EmplRecord { get; set; }
        public string Supervisor { get; set; }
        public DateTime HireDate { get; set; }
        public float PayRate { get; set; }
        public DateTime LastPayIncrease { get; set; }
        public float PayIncreaseAmount { get; set; }
        public DateTime IncreaseInputDate { get; set; }
        //MSB Core (IS or other), MISM, MBA, MPA, Macc, Other majors on campus
        public string YearInProgram { get; set; }
        public bool PayGradTuition { get; set; }
        public bool NameChangeCompleted { get; set; }
        public string Notes { get; set; }
        public bool Terminated { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool QualtricsSurveySent { get; set; }
        public bool SubmittedEForm { get; set; }
        public DateTime EFormSubmissionDate { get; set; }
        public bool WorkAuthReceived { get; set; }
        public DateTime AuthToWorkEmailSentDate { get; set; }
        public string ByuName { get; set; }
    }
}


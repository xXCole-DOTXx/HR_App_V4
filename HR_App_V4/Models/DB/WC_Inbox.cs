using ExpressiveAnnotations.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HR_App_V4.Models.DB
{
    public partial class WC_Inbox
    {
        public int ID { get; set; }
        [MaxLength(50), Required]
        public string First_Name { get; set; } = null!;
        [MaxLength(50)]
        public string Last_Name { get; set; } = null!;
        [MaxLength(10)]
        public string? Gender { get; set; }
        [MaxLength(30)]
        public string? Marital_Status { get; set; }
        [MaxLength(50)]
        public string? Employment_Status { get; set; }
        [MaxLength(4)]
        public string? SSN { get; set; }
        public DateTime? DOB { get; set; }
        public decimal? Hourly_Rate { get; set; }
        public decimal? Daily_Rate { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; }
        [MaxLength(12)]
        public string? Phone_Number { get; set; }
        [MaxLength(10)]
        public string? Claim_Number { get; set; }
        [MaxLength(10)]
        public string? EmployeeID { get; set; }
        [MaxLength(4)]
        public string Org_Number { get; set; } = null!;
        public DateTime Hire_Date { get; set; }
        [MaxLength(20)]
        public string Job_Title { get; set; } = null!;
        [MaxLength(50)]
        public string Work_Schedule { get; set; } = null!;
        public DateTime Injury_Date { get; set; }
        [MaxLength(10)]
        public string Injury_Time { get; set; } = null!;
        public bool Hearing_Loss { get; set; }
        public bool OP { get; set; }
        [MaxLength(15)]
        public string DOT_12 { get; set; } = null!;
        [MaxLength(10)]
        public string Start_Time { get; set; } = null!;
        [MaxLength(30)]
        public string Injured_Body_Part { get; set; } = null!;
        [MaxLength(10)]
        public string? Side { get; set; }
        public bool Missing_Work { get; set; }
        public DateTime? Begin_Missing_Date { get; set; }
        [MaxLength(10)]
        public string? Begin_Missing_Time { get; set; }
        public DateTime? Return_To_Work_Date { get; set; }
        public int Number_Days_Missed { get; set; }
        public bool Doctors_Release { get; set; }
        public bool? Treatment { get; set; }
        [RequiredIf("Treatment == true", ErrorMessage = "Treatment Date is required.")]
        public DateTime? Treatment_Date { get; set; }
        [MaxLength(100)]
        [RequiredIf("Treatment == true", ErrorMessage = "Treatment Provider is required.")]
        public string? Treatment_Provider { get; set; }
        [MaxLength(15)]
        [RequiredIf("Treatment == true", ErrorMessage = "Treatment Provider Phone is required.")]
        public string? Treatment_Provider_Phone { get; set; }
        [MaxLength(50)]
        [RequiredIf("Treatment == true", ErrorMessage = "Where first treated is required.")]
        public string? Transport_First_Treatment { get; set; }
        [MaxLength(50)]
        [RequiredIf("Treatment == true", ErrorMessage = "The city of treatment is required.")]
        public string? Transport_City { get; set; }
        public string Injury_Description { get; set; } = null!;
        [MaxLength(250)]
        public string? Equipment { get; set; }
        [MaxLength(50)]
        public string? Witness { get; set; }
        [MaxLength(50)]
        public string? Supervisor_Name { get; set; }
        [MaxLength(15)]
        public string? Supervisor_Phone { get; set; }
        [MaxLength(250)]
        public string? Questioned { get; set; }
        [MaxLength(250)]
        public string? Medical_History { get; set; }
        public bool Inbox_Submitted { get; set; }
        [RequiredIf("Inbox_Submitted == false", ErrorMessage = "The reason is required.")]
        public string? Inbox_Reason { get; set; }
        public string? Comments { get; set; }
        [MaxLength(254)]
        public string User_Email { get; set; } = null!;
        [MaxLength(254)]
        public string Supervisor_Email { get; set; } = null!;
        [MaxLength(254)]
        public string Safety_Specialist_Email { get; set; } = null!;
        [MaxLength(254)]
        public string? Optional_Email { get; set; }
        [MaxLength(254)]
        public string? Optional_Email2 { get; set; }
        [MaxLength(254)]
        public string? Optional_Email3 { get; set; }
        [MaxLength(254), Required]
        public string? HDHR_Manager_Email { get; set; }
        public int TX_EROI_Lag { get; set; }
        public DateTime? EROI_Date {get;set;}
        public string? Claim_Ruling { get; set; }
        public string? Injury_Type { get; set; }
        public DateTime? TTD_Onset_Date { get; set; }
        public DateTime? Restricted_RTW_Date { get; set; }
        public DateTime? Full_Duty_RTW_Date { get; set; }
        public bool Receiving_TTD { get; set; } 
        public DateTime? Date_TTD_Award_Notice { get; set; }
        public DateTime? Claim_Ruling_Date { get; set; }
        public DateTime? Rulling_Rejection_Date { get; set; }
        public DateTime? Tolled_Date { get; set; }
        public DateTime? Med_Excuse_To { get; set; }
        public bool Med_Only { get; set; }
        public string? Doctor { get; set; } 
        public DateTime? RTW_Email_Encova { get; set; }
        public DateTime? Lost_Time_Start1 { get; set; }
        public DateTime? Lost_Time_End1 { get; set; }
        public DateTime? Lost_Time_Start2 { get; set; }
        public DateTime? Lost_Time_End2 { get; set; }
        public DateTime? Lost_Time_Start3 { get; set; }
        public DateTime? Lost_Time_End3 { get; set; }
        public string? Status { get; set; }
        public string? HR_Comments { get; set; }
        public string Add_User { get; set; } = null!;
        public DateTime Date_Added { get; set; }
        public string? HR_User { get; set; }
        public DateTime? Date_Modified { get; set; }
    }
}

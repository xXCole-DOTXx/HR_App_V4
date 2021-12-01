using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HR_App_V4.Models.DB
{
    public partial class WC_Inbox
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string First_Name { get; set; } = null!;
        [MaxLength(50)]
        public string Last_Name { get; set; } = null!;
        [MaxLength(10)]
        public string? Gender { get; set; }
        [MaxLength(10)]
        public string? Marital_Status { get; set; }
        [MaxLength(50)]
        public string? Employment_Status { get; set; }
        [MaxLength(4)]
        public string? SSN { get; set; }
        public DateTime? DOB { get; set; }
        [MaxLength(20)]
        public string? Hourly_Rate { get; set; }
        [MaxLength(20)]
        public string? Daily_Rate { get; set; }
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
        [MaxLength(15)]
        public string DOT_12 { get; set; } = null!;
        [MaxLength(10)]
        public string Start_Time { get; set; } = null!;
        [MaxLength(30)]
        public string Injured_Body_Part { get; set; } = null!;
        [MaxLength(10)]
        public string? Side { get; set; }
        public bool Missing_Work { get; set; }
        public DateTime? Missing_Work_Date { get; set; }
        public DateTime? Begin_Missing_Date { get; set; }
        [MaxLength(5)]
        public string? Begin_Missing_Time { get; set; }
        public DateTime? Return_To_Work_Date { get; set; }
        [MaxLength(25)]
        public string? Doctors_Release { get; set; }
        public bool? Treatment { get; set; }
        public DateTime? Treatment_Date { get; set; }
        [MaxLength(100)]
        public string? Treatment_Provider { get; set; }
        [MaxLength(15)]
        public string? Treatment_Provider_Phone { get; set; }
        [MaxLength(50)]
        public string? Transport_First_Treatment { get; set; }
        [MaxLength(50)]
        public string? Transport_City { get; set; }
        [MaxLength(250)]
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
        [MaxLength(10)]
        public string Inbox_Submitted { get; set; } = null!;
        public string? Inbox_Reason { get; set; }
        [MaxLength(250)]
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
        [MaxLength(254)]
        public string? HDHR_Manager_Email { get; set; }
        public DateTime? TX_EROI_Lag { get; set; }
        public string? Claim_Ruling { get; set; }
        public string? Injury_Type { get; set; }
        public DateTime? TTD_Onset_Date { get; set; }
        public DateTime? Restricted_RTW { get; set; }
        public DateTime? Full_Duty_RTW { get; set; }
        public DateTime? TTD_Award_Notice { get; set; }
        public DateTime? RTW_Notice_Carrier { get; set; }
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

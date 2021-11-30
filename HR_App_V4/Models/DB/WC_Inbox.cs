using System;
using System.Collections.Generic;

namespace HR_App_V4.Models.DB
{
    public partial class WC_Inbox
    {
        public int ID { get; set; }
        public string First_Name { get; set; } = null!;
        public string Last_Name { get; set; } = null!;
        public string? Gender { get; set; }
        public string? Marital_Status { get; set; }
        public string? Employment_Status { get; set; }
        public string? SSN { get; set; }
        public DateTime? DOB { get; set; }
        public string? Hourly_Rate { get; set; }
        public string? Daily_Rate { get; set; }
        public string? Address { get; set; }
        public string? Phone_Number { get; set; }
        public string? EncovaID { get; set; }
        public string EmployeeID { get; set; } = null!;
        public string Org_Number { get; set; } = null!;
        public DateTime Hire_Date { get; set; }
        public string Job_Title { get; set; } = null!;
        public string Work_Schedule { get; set; } = null!;
        public DateTime Injury_Date { get; set; }
        public string Injury_Time { get; set; } = null!;
        public string DOT_12 { get; set; } = null!;
        public string Start_Time { get; set; } = null!;
        public string Injured_Body_Part { get; set; } = null!;
        public string? Side { get; set; }
        public bool Missing_Work { get; set; }
        public DateTime? Missing_Work_Date { get; set; }
        public DateTime? Begin_Missing_Date { get; set; }
        public string? Begin_Missing_Time { get; set; }
        public DateTime? Return_To_Work_Date { get; set; }
        public string? Doctors_Release { get; set; }
        public bool? Treatment { get; set; }
        public DateTime? Treatment_Date { get; set; }
        public string? Treatment_Provider { get; set; }
        public string? Treatment_Provider_Phone { get; set; }
        public string? Transport_First_Treatment { get; set; }
        public string? Transport_City { get; set; }
        public string Injury_Description { get; set; } = null!;
        public string? Equipment { get; set; }
        public string? Witness { get; set; }
        public string? Supervisor_Name { get; set; }
        public string? Supervisor_Phone { get; set; }
        public string? Questioned { get; set; }
        public string? Medical_History { get; set; }
        public string Inbox_Submitted { get; set; } = null!;
        public string? Inbox_Reason { get; set; }
        public string? Comments { get; set; }
        public string User_Email { get; set; } = null!;
        public string Supervisor_Email { get; set; } = null!;
        public string Safety_Specialist_Email { get; set; } = null!;
        public string? Optional_Email { get; set; }
        public string? Optional_Email2 { get; set; }
        public string? Optional_Email3 { get; set; }
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

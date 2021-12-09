using ExpressiveAnnotations.Attributes;
using HR_App_V4.Models.DB;
using System.ComponentModel.DataAnnotations;

namespace HR_App_V4.DTOs
{
    public class ReviewDTO
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string First_Name { get; set; } = null!;
        [MaxLength(50)]
        public string Last_Name { get; set; } = null!;
        [MaxLength(10)]
        public string? Gender { get; set; }
        [MaxLength(30)]
        public string? Marital_Status { get; set; }
        [MaxLength(4)]
        public string? SSN { get; set; }
        public DateTime? DOB { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; }
        [MaxLength(12)]
        public string? Phone_Number { get; set; }
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
        public DateTime? Missing_Work_Date { get; set; }
        public DateTime? Begin_Missing_Date { get; set; }
        [MaxLength(10)]
        public string? Begin_Missing_Time { get; set; }
        public DateTime? Return_To_Work_Date { get; set; }
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
        public bool Inbox_Submitted { get; set; }
        [RequiredIf("Inbox_Submitted == false", ErrorMessage = "The reason is required.")]
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
        public int TX_EROI_Lag { get; set; }
        public DateTime EROI_Date { get; set; }
        [MaxLength(10)]
        public string? Claim_Number { get; set; }
        [MaxLength(10)]
        public string? EmployeeID { get; set; }
        [MaxLength(50)]
        public string? Employment_Status { get; set; }
        public string? Claim_Ruling { get; set; }
        public decimal? Hourly_Rate { get; set; }
        public decimal? Daily_Rate { get; set; }
        public int Number_Days_Missed { get; set; }
        public string? Injury_Type { get; set; }
        public DateTime? TTD_Onset_Date { get; set; }
        public DateTime? Restricted_RTW_Date { get; set; }
        public DateTime? Full_Duty_RTW_Date { get; set; }
        public bool Receiving_TTD { get; set; }
        public DateTime? Date_TTD_Award_Notice { get; set; }
        public DateTime? Claim_Ruling_Date { get; set; }
        public DateTime? Med_Excuse_To { get; set; }
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

        public WC_Inbox ToCompletedWC_Inbox()
        {
            return new WC_Inbox
            {
                ID = this.ID,
                First_Name = this.First_Name,
                Last_Name = this.Last_Name,
                Gender = this.Gender,
                Marital_Status = this.Marital_Status,
                SSN = this.SSN,
                DOB = this.DOB,
                Address = this.Address,
                Phone_Number = this.Phone_Number,
                Org_Number = this.Org_Number,
                Hire_Date = this.Hire_Date,
                Job_Title = this.Job_Title,
                Work_Schedule = this.Work_Schedule,
                Injury_Date = this.Injury_Date,
                Injury_Time = this.Injury_Time,
                Hearing_Loss = this.Hearing_Loss,
                OP = this.OP,
                DOT_12 = this.DOT_12,
                Start_Time = this.Start_Time,
                Injured_Body_Part = this.Injured_Body_Part,
                Side = this.Side,
                Missing_Work = this.Missing_Work,
                Missing_Work_Date = this.Missing_Work_Date,
                Begin_Missing_Date = this.Begin_Missing_Date,
                Begin_Missing_Time = this.Begin_Missing_Time,
                Return_To_Work_Date = this.Return_To_Work_Date,
                Doctors_Release = this.Doctors_Release,
                Treatment = this.Treatment,
                Treatment_Date = this.Treatment_Date,
                Treatment_Provider = this.Treatment_Provider,
                Treatment_Provider_Phone = this.Treatment_Provider_Phone,
                Transport_First_Treatment = this.Transport_First_Treatment,
                Transport_City = this.Transport_City,
                Injury_Description = this.Injury_Description,
                Equipment = this.Equipment,
                Witness = this.Witness,
                Supervisor_Name = this.Supervisor_Name,
                Supervisor_Phone = this.Supervisor_Phone,
                Questioned = this.Questioned,
                Medical_History = this.Medical_History,
                Inbox_Submitted = this.Inbox_Submitted,
                Inbox_Reason = this.Inbox_Reason,
                Comments = this.Comments,
                User_Email = this.User_Email,
                Supervisor_Email = this.Supervisor_Email,
                Safety_Specialist_Email = this.Safety_Specialist_Email,
                Optional_Email = this.Optional_Email,
                Optional_Email2 = this.Optional_Email2,
                Optional_Email3 = this.Optional_Email3,
                HDHR_Manager_Email = this.HDHR_Manager_Email,
                TX_EROI_Lag = this.TX_EROI_Lag,
                EROI_Date = this.EROI_Date,
                Claim_Number = this.Claim_Number,
                EmployeeID = this.EmployeeID,
                Employment_Status = this.Employment_Status,
                Daily_Rate = this.Daily_Rate,
                Hourly_Rate = this.Hourly_Rate,
                Number_Days_Missed = this.Number_Days_Missed,
                Claim_Ruling = this.Claim_Ruling,
                Injury_Type = this.Injury_Type,
                TTD_Onset_Date = this.TTD_Onset_Date,
                Restricted_RTW_Date = this.Restricted_RTW_Date,
                Full_Duty_RTW_Date = this.Full_Duty_RTW_Date,
                Receiving_TTD = this.Receiving_TTD,
                Date_TTD_Award_Notice = this.Date_TTD_Award_Notice,
                Claim_Ruling_Date = this.Claim_Ruling_Date,
                Med_Excuse_To = this.Med_Excuse_To,
                Doctor = this.Doctor,
                RTW_Email_Encova = this.RTW_Email_Encova,
                Lost_Time_Start1 = this.Lost_Time_Start1,
                Lost_Time_End1 = this.Lost_Time_End1,
                Lost_Time_Start2 = this.Lost_Time_Start2,
                Lost_Time_End2 = this.Lost_Time_End2,  
                Lost_Time_Start3 = this.Lost_Time_Start3,
                Lost_Time_End3 = this.Lost_Time_End3,
                Add_User = this.Add_User,
                Date_Added = this.Date_Added,
                HR_User = this.HR_User,
                Date_Modified = this.Date_Modified,
            };
        }
    }
}

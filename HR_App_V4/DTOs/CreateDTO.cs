using ExpressiveAnnotations.Attributes;
using HR_App_V4.Models.DB;
using System.ComponentModel.DataAnnotations;

namespace HR_App_V4.DTOs
{
    public class CreateDTO
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
        public string? Injury_Type { get; set; }
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
        public string Add_User { get; set; } = null!;
        public DateTime Date_Added { get; set; }

        public WC_Inbox ToWC_Inbox()
        {
            return new WC_Inbox
            {
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
                Injury_Type = this.Injury_Type,
                DOT_12 = this.DOT_12,
                Start_Time = this.Start_Time,
                Injured_Body_Part = this.Injured_Body_Part,
                Side = this.Side,
                Missing_Work = this.Missing_Work,
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
                Add_User = this.Add_User,
                Date_Added = this.Date_Added,
            };
        }
    }

}

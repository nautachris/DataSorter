using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSorter
{
    public class DataModel
    {
        public DataModel(string[] vals)
        {
            
            this.CreditUnionName = vals[0];
            this.FirstName = vals[1];
            this.LastName = vals[2];
            this.Email = vals[3];
            this.State = vals[4];
            this.House = vals[5];
            this.Senate = vals[6];
            this.Processing = vals[7].ToLower() == "x";
            this.Confirmed = vals[8].ToLower() == "yes";
            this.Scheduler = vals[9];
            this.Staffer = vals[10];
            this.CongressEmail = vals[11];
            if (!string.IsNullOrEmpty(vals[12]))
            {
                DateTime test;
                if (DateTime.TryParse(vals[12], out test)) this.MeetingDate = test;
            }
            if (!string.IsNullOrEmpty(vals[13]))
            {
                DateTime test;
                if (DateTime.TryParse(vals[13], out test)) this.MeetingTime = test;
            }
            this.Location = vals[14];
        }

        public DateTime CombinedDate
        {
            get
            {
                if (this.MeetingDate.HasValue && this.MeetingTime.HasValue)
                {
                    var dt = new DateTime(this.MeetingDate.Value.Year, this.MeetingDate.Value.Month, this.MeetingDate.Value.Day, this.MeetingTime.Value.Hour, this.MeetingTime.Value.Minute, this.MeetingTime.Value.Second);
                    return dt;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        public string Congressman
        {
            get
            {
                if (!string.IsNullOrEmpty(this.House)) return this.House;
                return this.Senate;
            }
        }
        public DataModel() { }
        public string CreditUnionName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string House { get; set; }
        public string Senate { get; set; }
        public bool Processing { get; set; }
        public bool Confirmed { get; set; }
        public string Scheduler { get; set; }
        public string Staffer { get; set; }
        public string CongressEmail { get; set; }
        public DateTime? MeetingDate { get; set; }
        public DateTime? MeetingTime { get; set; }
        public string Location { get; set; }

    }
}

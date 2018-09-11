using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSorter
{
    public class AppointmentModel
    {
        public AppointmentModel(string[] vals)
        {
            foreach (var prop in this.GetType().GetProperties().Where(x=>x.CanWrite))
            {
                var idx = (prop.GetCustomAttributes(typeof(ColumnMap), false)[0] as ColumnMap).ColumnIndex;
                if (prop.PropertyType.Name.Contains("String"))
                {
                    if (vals.Length > idx && vals[idx] != null) prop.SetValue(this, vals[idx]);

                }
                else if (prop.PropertyType.Name.Contains("Int32"))
                {
                    if (vals.Length > idx && vals[idx] != null) prop.SetValue(this, Convert.ToInt32(vals[idx]));
                }
                else if (prop.PropertyType.Name.Contains("Boolean"))
                {
                    if (vals.Length > idx && vals[idx] != null && !string.IsNullOrEmpty(vals[idx].ToString())) prop.SetValue(this, true);
                    else prop.SetValue(this, false);
                }
                else
                {
                    //null boolean
                    if (vals.Length > idx && vals[idx] != null)
                    {
                        DateTime test;
                        if (DateTime.TryParse(vals[idx].ToString(), out test)) prop.SetValue(this, test);
                    }
                }

            }

        }
        public AppointmentModel(object[] vals)
        {
            foreach (var prop in this.GetType().GetProperties().Where(x=>x.CanWrite))
            {
                var idx = (prop.GetCustomAttributes(typeof(ColumnMap), false)[0] as ColumnMap).ColumnIndex;
                if (prop.PropertyType.Name.Contains("String"))
                {
                    if (vals.Length > idx && vals[idx] != null) prop.SetValue(this, vals[idx].ToString());

                }
                else if (prop.PropertyType.Name.Contains("Int32"))
                {
                    if (vals.Length > idx && vals[idx] != null) prop.SetValue(this, Convert.ToInt32(vals[idx].ToString()));
                }
                else if (prop.PropertyType.Name.Contains("Boolean"))
                {
                    if (vals.Length > idx && vals[idx] != null && !string.IsNullOrEmpty(vals[idx].ToString())) prop.SetValue(this, true);
                    else prop.SetValue(this, false);
                }
                else
                {
                    //null boolean
                    if (vals.Length > idx && vals[idx] != null)
                    {
                        DateTime test;
                        if (DateTime.TryParse(vals[idx].ToString(), out test))
                        {
                            prop.SetValue(this, test);
                        }
                        else if (vals[idx].ToString().Contains(","))
                        {
                            var strp = vals[idx].ToString().Split(',')[1];
                            var dt = Convert.ToDateTime(strp);
                            prop.SetValue(this, dt);
                        }
                    }
                }

            }

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
        public AppointmentModel() { }

        [ColumnMap(0)]
        public string CreditUnionName { get; set; }

        [ColumnMap(1)]
        public string FirstName { get; set; }

        [ColumnMap(2)]
        public string LastName { get; set; }

        [ColumnMap(3)]
        public string Email { get; set; }

        [ColumnMap(4)]
        public string State { get; set; }

        [ColumnMap(5)]
        public string House { get; set; }

        [ColumnMap(6)]
        public string Senate { get; set; }


        [ColumnMap(8)]
        public bool Processing { get; set; }

        [ColumnMap(9)]
        public bool Confirmed { get; set; }

        [ColumnMap(10)]
        public string Scheduler { get; set; }

        [ColumnMap(12)]
        public string Staffer { get; set; }

        [ColumnMap(13)]
        public string CongressEmail { get; set; }

        [ColumnMap(14)]
        public DateTime? MeetingDate { get; set; }

        [ColumnMap(15)]
        public DateTime? MeetingTime { get; set; }

        [ColumnMap(16)]
        public string Location { get; set; }

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnMap : Attribute
    {
        public int ColumnIndex { get; set; }
        public ColumnMap(int idx)
        {
            this.ColumnIndex = idx;
        }
    }
}

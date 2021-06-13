using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    [Serializable]
    public class Event : IComparable<Event>
    {
        public string Title;
        public string Description;
        public bool Important;
        public DateTime starts;
        
        public Event(string title, string description,bool important, DateTime starts)
        {
            this.Title = title;
            this.Description = description;
            this.Important = important;
            this.starts = starts;
        }
        public DateTime getDate()
        {
            return starts.Date;
        }

        public void changeDate(DateTime starts, DateTime ends)
        {
            this.starts = starts;
        }

        public int CompareTo(Event other)
        {
            return this.starts.CompareTo(other.starts);
        }
    }
}

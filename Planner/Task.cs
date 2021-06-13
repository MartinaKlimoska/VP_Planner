using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    [Serializable]
    public class Task : IComparable<Task>
    {
        public string Title;
        public string Description;
        public bool timeRelevant;
        public DateTime dueDate;
        public bool Important;


        public Task(string title, string description, bool timeRelevant, DateTime dueDate, bool important)
        {
            this.Title = title;
            this.Description = description;
            this.timeRelevant = timeRelevant;
            if(timeRelevant)
            this.dueDate = dueDate;
            this.Important = important;
        }

        public int CompareTo(Task other)
        {
            if (this.Important && !other.Important)
            {
                return -1;
            }
            if (!this.Important && other.Important)
            {
                return 1;
            }
            if (this.timeRelevant && other.timeRelevant)
            {
                return this.dueDate.CompareTo(other.dueDate);
            }
            if (this.timeRelevant)
            {
                return -1;
            }
            if (other.timeRelevant)
            {
                return 1;
            }
            return 0;
        }
        
    }
}

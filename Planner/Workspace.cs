using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    [Serializable]
    public class Workspace
    {
        private List<Task> tasks;
        private List<Task> completedTasks;
        private Dictionary<DateTime, List<Event>> events;
        
        public Workspace()
        {
            tasks = new List<Task>();
            completedTasks = new List<Task>();
            events = new Dictionary<DateTime, List<Event>>();
        }

        public void addTask(Task task)
        {
            tasks.Add(task);
        }
        public List<Task> getTasks()
        {
            List<Task> ts = new List<Task>();
            if (tasks.Count>0)
            {
                ts = tasks;
                ts.Sort();
            }
            return ts;
        }
        public List<Task> getCompletedTasks()
        {
            List<Task> ts = new List<Task>();
            if (completedTasks.Count>0)
            {
                ts = completedTasks;
                ts.Reverse();
            }
            return ts;
        }
        public void editTask(Task t, Task x)
        {
            t = x;
        }
        public void deleteTask(Task t)
        {
            tasks.Remove(t);
            completedTasks.Remove(t);
        }
        public void completeTask(Task t)
        {
            completedTasks.Add(t);
            tasks.Remove(t);
        }
        public void addEvent(Event e)
        {
            List<Event> es;
            if (events.TryGetValue(e.getDate(), out es))
            {
                es.Add(e);
            }
            else
            {
                es = new List<Event>();
                es.Add(e);
            }
            events[e.getDate()] = es;
        }
        public List<Event> getDailyEvents()
        {
            DateTime date = DateTime.Today;
            List<Event> todaysEvents;
            if (events.TryGetValue(date, out todaysEvents))
            {
                todaysEvents.Sort();
                return todaysEvents;
            }
            else
            {
                return new List<Event>();
            }
            
        }
        private List<Event> getEvents()
        {
            List<Event> allEvents = new List<Event>();
            foreach (List<Event> list in events.Values.ToList())
            {
                foreach (Event e in list)
                {
                    allEvents.Add(e);
                }
            }
            return allEvents;
        }
        public List<Event> getPastEvents()
        {
            List<Event> list = new List<Event>();
            getEvents().ForEach(e => { if (e.getDate().CompareTo(DateTime.Now) < 0) list.Add(e); });
            return list;
        }
        public List<Event> getCurrentFutureEvents()
        {
            List<Event> list = new List<Event>();
            getEvents().ForEach(e => { if (e.getDate().CompareTo(DateTime.Now) >= 0) list.Add(e); });
            return list;
        }
        public void editEvent(Event e, Event x)
        {
            e = x;
        }
        public void deleteEvent(Event e)
        {
            List<Event> es;
            if (events.TryGetValue(e.getDate(), out es))
            {
                es.Remove(e);
                events[e.getDate()] = es;
            }
        }
    }
}

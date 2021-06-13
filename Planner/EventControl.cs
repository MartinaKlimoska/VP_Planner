using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class EventControl : UserControl
    {
        public Form1 form { get; set; }
        public Event Event { get; set; }
        public EventControl(Event e, Form1 f)
        {
            InitializeComponent();
            Event = e;
            titleLabel.Text = Event.Title;
            descriptionLabel.Text = Event.Description;
            timeLabel.Text = String.Format("{0} {1}", Event.starts.ToShortDateString(), Event.starts.ToShortTimeString());
            form = f;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            form.Workspace.deleteEvent(Event);
            form.display();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            NewEvent newEvent = new NewEvent();
            newEvent.newEvent = Event;
            if (newEvent.ShowDialog() == DialogResult.OK)
            {
                form.Workspace.editEvent(Event, newEvent.newEvent);
            }
            form.display();
        }
    }
}

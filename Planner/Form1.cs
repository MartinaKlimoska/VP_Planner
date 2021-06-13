using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class Form1 : Form
    {
        public ViewType currentView { get; set; }
        public Workspace Workspace { get; set; }
        public enum ViewType
        {
            AllEvents,
            AllTasks,
            DailyView
        }
        public Form1()
        {
            InitializeComponent();
            open();
            timer1.Interval = 1000;
            timer1.Start();
            currentView = ViewType.DailyView;
            dayofweeklabel.Text = DateTime.Now.DayOfWeek.ToString();
            timelabel.Text = String.Format("{0:00}:{1:00}", DateTime.Now.Hour, DateTime.Now.Minute);
            datelabel.Text = String.Format("{0:00}/{1:00}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            display();
        }

        private void open()
        {
            if (!File.Exists("Workspace.bin"))
            {
                Workspace = new Workspace();
            }
            else
            {
                using (FileStream str = File.OpenRead("Workspace.bin"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    if (str.Length != 0)
                    {
                        Workspace = (Workspace)bf.Deserialize(str);
                    }
                    else
                    {
                        Workspace = new Workspace();
                    }

                    str.Close();
                }
            }
        }
        private void serialize()
        {
            if (!File.Exists("Workspace.bin"))
            {
                File.Create("Workspace.bin");
            }

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream str = File.OpenWrite("Workspace.bin"))
            {
                if (str.Length != 0)
                    bf.Serialize(str, Workspace);
                str.Close();
            }
        }

        private void DisplayTasks(List<Task> ts, Panel panel)
        {
            int i= 0;
            panel.Controls.Clear();
            if (ts.Count>0)
            {
                foreach (Task t in ts)
                {
                    TaskControl c = new TaskControl(t, this);
                    c.Location = new Point(0, 100 * i);
                    c.BackColor = Color.FromArgb(196, 219, 224);
                    if (i % 2 == 0)
                        c.BackColor = Color.FromArgb(196, 204, 224);
                    panel.Controls.Add(c);
                    i++;
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "No tasks";
                panel.Controls.Add(label);
            }
        }
        private void DisplayEvents(List<Event> es, Panel panel)
        {
            int i = 0;
            panel.Controls.Clear();
            if (es.Count>0)
            {
                foreach (Event e in es)
                {
                    EventControl c = new EventControl(e, this);
                    c.Location = new Point(0, 100 * i);
                    c.BackColor = Color.FromArgb(196, 219, 224);
                    if (i % 2 == 0)
                        c.BackColor = Color.FromArgb(196, 204, 224);
                    panel.Controls.Add(c);
                    i++;
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "No events";
                panel.Controls.Add(label);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            if (newTask.ShowDialog() == DialogResult.OK)
            {
                Workspace.addTask(newTask.newTask);
            }
            DisplayTasks(Workspace.getTasks(), rightPanel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewEvent newEvent = new NewEvent();
            if (newEvent.ShowDialog() == DialogResult.OK)
            {
                Workspace.addEvent(newEvent.newEvent);
            }
            DisplayEvents(Workspace.getDailyEvents(), leftPanel);
        }

        public void display()
        {
            if (currentView == ViewType.DailyView)
            {
                DisplayTasks(Workspace.getTasks(), rightPanel);
                DisplayEvents(Workspace.getDailyEvents(), leftPanel);
            }
            if (currentView == ViewType.AllTasks)
            {
                DisplayTasks(Workspace.getCompletedTasks(), leftPanel);
                DisplayTasks(Workspace.getTasks(), rightPanel);
            }
            if (currentView == ViewType.AllEvents)
            {
                DisplayEvents(Workspace.getPastEvents(), rightPanel);
                DisplayEvents(Workspace.getCurrentFutureEvents(), leftPanel);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (datelabel.Text != String.Format("{0:00}/{1:00}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year))
            {
                display();
            }
            dayofweeklabel.Text = DateTime.Now.DayOfWeek.ToString();
            timelabel.Text = String.Format("{0:00}:{1:00}", DateTime.Now.Hour, DateTime.Now.Minute);
            datelabel.Text = String.Format("{0:00}/{1:00}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentView == ViewType.DailyView)
            {
                currentView = ViewType.AllEvents;
                button1.Text = "Daily View";
            }
            else if (currentView == ViewType.AllTasks)
            {
                currentView = ViewType.AllEvents;
                button1.Text = "Daily View";
                button2.Text = "All Tasks";
            }
            else if (currentView == ViewType.AllEvents)
            {
                currentView = ViewType.DailyView;
                button1.Text = "All Events";
            }
            setView();
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentView == ViewType.DailyView)
            {
                currentView = ViewType.AllTasks;
                button2.Text = "Daily View";
            }
            else if (currentView == ViewType.AllTasks)
            {
                currentView = ViewType.DailyView;
                button2.Text = "All Tasks";
            }
            else if (currentView == ViewType.AllEvents)
            {
                currentView = ViewType.AllTasks;
                button2.Text = "Daily View";
                button1.Text = "All Events";
            }
            setView();
            display();
        }
        private void setView()
        {
            if (currentView == ViewType.DailyView)
            {
                leftLabel.Text = "Events";
                rightLabel.Text = "Tasks";
                button5.Visible = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button6.Visible = true;
            }
            if (currentView == ViewType.AllTasks)
            {
                leftLabel.Text = "Completed Tasks";
                rightLabel.Text = "Tasks";
                button5.Visible = true;
                button5.Enabled = true;
                button6.Visible = false;
                button6.Enabled = false;
            }
            if (currentView == ViewType.AllEvents)
            {
                leftLabel.Text = "Events";
                rightLabel.Text = "Past Events";
                button5.Enabled = false;
                button5.Visible = false;
                button6.Enabled = true;
                button6.Visible = true;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            serialize();
        }
    }
}

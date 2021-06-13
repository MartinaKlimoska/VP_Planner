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
    public partial class TaskControl : UserControl
    {
        public Form1 form { get; set; }
        public Task Task { get; set; }
        public TaskControl(Task t, Form1 f)
        {
            InitializeComponent();
            Task = t;
            titleLabel.Text = Task.Title;
            descriptionLabel.Text = Task.Description;
            if (Task.Important)
            {
                titleLabel.ForeColor = Color.Red;
            }
            if (Task.timeRelevant)
            {
                dueDateLabel.Text = Task.dueDate.ToShortDateString();
            }
            form = f;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            form.Workspace.completeTask(Task);
            form.display();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.newTask = Task;
            if (newTask.ShowDialog() == DialogResult.OK)
            {
                form.Workspace.editTask(Task, newTask.newTask);
            }
            form.display();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            form.Workspace.deleteTask(Task);
            form.display();
        }
    }
}

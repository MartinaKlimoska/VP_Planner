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
    public partial class NewTask : Form
    {
        public Task newTask { get; set; }
        public NewTask()
        {
            InitializeComponent();
            textBox1.Focus();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "d'/'M'/'yyyy HH':'mm";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                newTask = new Task(textBox1.Text, richTextBox1.Text, checkBox2.Checked, dateTimePicker2.Value, checkBox1.Checked);
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

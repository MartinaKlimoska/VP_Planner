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
    public partial class NewEvent : Form
    {
        public Event newEvent { get; set; }
        public NewEvent()
        {
            InitializeComponent();
            textBox1.Focus();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d'/'M'/'yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH':'mm";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                DateTime dateTime = new DateTime(dateTimePicker1.Value.Year,
                                                dateTimePicker1.Value.Month,
                                                dateTimePicker1.Value.Day,
                                                dateTimePicker2.Value.Hour,
                                                dateTimePicker2.Value.Minute, 0);
                newEvent = new Event(textBox1.Text, richTextBox1.Text, checkBox1.Checked, dateTime);
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

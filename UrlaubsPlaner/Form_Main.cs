using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner
{
    public partial class Form_Main : Form
    {
        public DataBaseContext DbContext { get; set; }

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_MainLoad(object sender, EventArgs e)
        {
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            // SELECT a.AbsenceTypeId FROM a AS DbContext.AbsenceTypes WHERE a.Label == combobox_reason.SelectedText;
            var absenceQuery = from a in DbContext.AbsenceType
                               where a.Label == combobox_absencetype.SelectedText
                               select a;

            var employeeQuery = from employee in DbContext.Employees
                                where employee.EmployeeNumber == int.Parse(textbox_employeeNumber.Text)
                                select employee;

            DbContext.Absence.Add(new Absence()
            {
                AbsenceID = new Guid(),
                AbsenceType = absenceQuery.First(),
                Employee = employeeQuery.First(),
                Reason = richtextbox_reason.Text,
                FromDate = monthCalendar.SelectionRange.Start,
                ToDate = monthCalendar.SelectionRange.End
            });
        }

        private void Label1_Click_2(object sender, EventArgs e)
        {
        }

        private void Combobox_absencetype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
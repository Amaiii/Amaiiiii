using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class FormMain : Form
    {
        DataTable dt = new DataTable();

        private School _school;
        int studentDisplayed = 0;

        public FormMain()
        {
            _school = DataGenerator.GetSchool();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DisplayStudent(studentDisplayed);
        }

        void DisplayStudent(int studentDisplayed)
        {
            txtID.Text = Convert.ToString(_school.Students.ToArray()[studentDisplayed].StudentID);
            txtForename.Text = _school.Students.ToArray()[studentDisplayed].Forename;
            txtSurname.Text = _school.Students.ToArray()[studentDisplayed].Surname;
            txtAge.Text = Convert.ToString(_school.Students.ToArray()[studentDisplayed].Age());
            txtDOB.Text = _school.Students.ToArray()[studentDisplayed].DisplayDOB();
            txtCourse.Text = _school.Students.ToArray()[studentDisplayed].Course.Name;
            listUnits.Items.Add(_school.Students.ToArray()[studentDisplayed].Course.Units);
        }
    }
}


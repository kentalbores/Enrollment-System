using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectEnrollmentEntry : Form
    {
        public SubjectEnrollmentEntry()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kent Albores\OneDrive\Desktop\AppsDev\Enrollment-System\Albores.accdb";
        private void IDNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM STUDENTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;

                string name = "";
                string course = "";
                string year = "";

                while (thisDataReader.Read())
                {

                    if (thisDataReader["SFSTUDIDNO"].ToString().Trim().ToUpper() == IDNoTextBox.Text.Trim().ToUpper())
                    {
                        found = true;

                        name = thisDataReader["SFSTUDLNAME"].ToString() + " " +
                               thisDataReader["SFSTUDFNAME"].ToString() + " " +
                               thisDataReader["SFSTUDMNAME"].ToString().Substring(0, 1);
                        course = thisDataReader["SFSTUDCOURSE"].ToString();
                        year = thisDataReader["STFSTUDYEAR"].ToString();
                        break;

                    }

                }


                if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                else
                {
                    NameLabel.Text = name;
                    CourseLabel.Text = course;
                    YearLabel.Text = year;
                }
            }
        }

        int totalUnits = 0;
        private void EDPCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                OleDbCommand command = new OleDbCommand();
                // command.CommandText = "Select * from SubjectFile where SFSUBJCODE= Textbox +" " ";
                MessageBox.Show("Test");
                int row = SubjectDataGridView.Rows.Add();
                int units = Convert.ToInt16(SubjectDataGridView.Rows[row].Cells["UnitsColumn"].Value);
                totalUnits = totalUnits + units;
            }
        }
    }
}

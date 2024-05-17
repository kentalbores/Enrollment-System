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
using static System.Collections.Specialized.BitVector32;

namespace Enrollment_System
{
    public partial class SubjectScheduleEntry : Form
    {
        public SubjectScheduleEntry()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kent Albores\OneDrive\Desktop\AppsDev\Enrollment-System\Albores.accdb";

        private void NextButton_Click(object sender, EventArgs e)
        {
            SubjectEnrollmentEntry entry = new SubjectEnrollmentEntry();
            entry.Show();
            this.Hide();
        }
        bool subjectSearch = false;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool conflict = false;
            if (subjectSearch == true)
            {
                try
                {


                    OleDbConnection thisConnection2 = new OleDbConnection(connectionString);
                    thisConnection2.Open();

                    string commandText2 = "SELECT * FROM SUBJECTSCHEDFILE";
                    OleDbCommand thisCommand2 = thisConnection2.CreateCommand();
                    thisCommand2.CommandText = commandText2;

                    OleDbDataReader thisReader2 = thisCommand2.ExecuteReader();
                    if (conflict == false)
                    {
                        OleDbConnection thisConnection = new OleDbConnection(connectionString);
                        thisConnection.Open();

                        string commandText = "SELECT * FROM SUBJECTSCHEDFILE";
                        OleDbDataAdapter thisAdapter = new OleDbDataAdapter(commandText, thisConnection);
                        OleDbCommandBuilder thisCommandBuilder = new OleDbCommandBuilder(thisAdapter);
                        DataSet thisDataSet = new DataSet();
                        thisAdapter.Fill(thisDataSet, "SUBJECTSCHEDFILE");
                        DataColumn[] keys = new DataColumn[2];

                        keys[0] = thisDataSet.Tables["SUBJECTSCHEDFILE"].Columns["SFEDPCODE"];
                        thisDataSet.Tables["SUBJECTSCHEDFILE"].PrimaryKey = keys;

                        String[] valuesToSearch = new string[1];
                        valuesToSearch[0] = EDPCodeTextBox.Text;

                        DataRow findRow = thisDataSet.Tables["SUBJECTSCHEDFILE"].Rows.Find(valuesToSearch);

                        DataRow thisRow = thisDataSet.Tables["SUBJECTSCHEDFILE"].NewRow();
                        thisRow["SFEDPCODE"] = EDPCodeTextBox.Text;
                        thisRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
                        thisRow["SFSTARTTIME"] = StartTimePicker.Value.ToString("hh:mm tt");
                        thisRow["SFENDTIME"] = EndTimePicker.Value.ToString("hh:mm tt");
                        thisRow["SFDAYS"] = DaysTextBox.Text;
                        thisRow["SFROOM"] = RoomTextBox.Text;
                        thisRow["SFSECTION"] = SectionTextBox.Text;
                        thisRow["SFSCHOOLYEAR"] = SchoolYearTextBox.Text;


                        thisDataSet.Tables["SUBJECTSCHEDFILE"].Rows.Add(thisRow);
                        thisAdapter.Update(thisDataSet, "SUBJECTSCHEDFILE");
                        MessageBox.Show("Schedule Recorded!", "Subject Schedule");


                    }
                    else
                    {
                        MessageBox.Show("Schedule Conflict!", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Search Subject First", "Information Message");
            }

        }

        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {



                    OleDbConnection thisConnection = new OleDbConnection(connectionString);
                    thisConnection.Open();

                    string commandText = "SELECT * FROM SUBJECTFILE";
                    OleDbCommand thisCommand = thisConnection.CreateCommand();
                    thisCommand.CommandText = commandText;

                    OleDbDataReader thisReader = thisCommand.ExecuteReader();
                    while (thisReader.Read())
                    {
                        if (thisReader["SFSUBJCODE"].ToString().ToLower() == SubjectCodeTextBox.Text.ToLower())
                        {
                            DescriptionLabel.Text = thisReader["SFSUBJDESC"].ToString();
                            subjectSearch = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information Message");
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EDPCodeTextBox.Text = "";
            SubjectCodeTextBox.Text = "";
            DescriptionLabel.Text = "";
            DaysTextBox.Text = "";
            SectionTextBox.Text = "";
            RoomTextBox.Text = "";
            SchoolYearTextBox.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SubjectEntry entry = new SubjectEntry();
            entry.Show();
            this.Hide();
        }
    }
}

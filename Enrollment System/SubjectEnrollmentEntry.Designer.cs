namespace Enrollment_System
{
    partial class SubjectEnrollmentEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IDNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EDPCodeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.EncoderTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.TotalUnitsLabel = new System.Windows.Forms.Label();
            this.EDPCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(184, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject Enrollment Entry";
            // 
            // IDNoTextBox
            // 
            this.IDNoTextBox.Location = new System.Drawing.Point(325, 82);
            this.IDNoTextBox.Name = "IDNoTextBox";
            this.IDNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDNoTextBox.TabIndex = 3;
            this.IDNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDNoTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(233, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID No.";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(485, 82);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(269, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(269, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(269, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // EDPCodeTextBox
            // 
            this.EDPCodeTextBox.Location = new System.Drawing.Point(172, 241);
            this.EDPCodeTextBox.Name = "EDPCodeTextBox";
            this.EDPCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EDPCodeTextBox.TabIndex = 12;
            this.EDPCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDPCodeTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(55, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "EDP Code";
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.AllowUserToAddRows = false;
            this.SubjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCodeCol,
            this.StartTimeCol,
            this.EndTimeCol,
            this.DaysCol,
            this.RoomCol,
            this.UnitsCol,
            this.SubjectCodeCol});
            this.SubjectDataGridView.Location = new System.Drawing.Point(60, 269);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SubjectDataGridView.RowHeadersVisible = false;
            this.SubjectDataGridView.Size = new System.Drawing.Size(662, 150);
            this.SubjectDataGridView.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(288, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Units";
            // 
            // EncoderTextBox
            // 
            this.EncoderTextBox.Location = new System.Drawing.Point(191, 495);
            this.EncoderTextBox.Name = "EncoderTextBox";
            this.EncoderTextBox.Size = new System.Drawing.Size(100, 20);
            this.EncoderTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(74, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Encoded By";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(477, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(522, 492);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 19;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(522, 537);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(350, 537);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(172, 537);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.MintCream;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameLabel.Location = new System.Drawing.Point(338, 122);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 23);
            this.NameLabel.TabIndex = 23;
            // 
            // CourseLabel
            // 
            this.CourseLabel.BackColor = System.Drawing.Color.MintCream;
            this.CourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CourseLabel.Location = new System.Drawing.Point(338, 154);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(100, 23);
            this.CourseLabel.TabIndex = 24;
            // 
            // YearLabel
            // 
            this.YearLabel.BackColor = System.Drawing.Color.MintCream;
            this.YearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YearLabel.Location = new System.Drawing.Point(338, 187);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(100, 23);
            this.YearLabel.TabIndex = 25;
            // 
            // TotalUnitsLabel
            // 
            this.TotalUnitsLabel.BackColor = System.Drawing.Color.MintCream;
            this.TotalUnitsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalUnitsLabel.Location = new System.Drawing.Point(371, 447);
            this.TotalUnitsLabel.Name = "TotalUnitsLabel";
            this.TotalUnitsLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalUnitsLabel.TabIndex = 26;
            // 
            // EDPCodeCol
            // 
            this.EDPCodeCol.HeaderText = "EDP Code";
            this.EDPCodeCol.Name = "EDPCodeCol";
            // 
            // StartTimeCol
            // 
            this.StartTimeCol.HeaderText = "Start Time";
            this.StartTimeCol.Name = "StartTimeCol";
            // 
            // EndTimeCol
            // 
            this.EndTimeCol.HeaderText = "End Time";
            this.EndTimeCol.Name = "EndTimeCol";
            // 
            // DaysCol
            // 
            this.DaysCol.HeaderText = "Days";
            this.DaysCol.Name = "DaysCol";
            // 
            // RoomCol
            // 
            this.RoomCol.HeaderText = "Room";
            this.RoomCol.Name = "RoomCol";
            // 
            // UnitsCol
            // 
            this.UnitsCol.HeaderText = "Units";
            this.UnitsCol.Name = "UnitsCol";
            // 
            // SubjectCodeCol
            // 
            this.SubjectCodeCol.HeaderText = "Subject Code";
            this.SubjectCodeCol.Name = "SubjectCodeCol";
            // 
            // SubjectEnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.TotalUnitsLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EncoderTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.EDPCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IDNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubjectEnrollmentEntry";
            this.Text = "SubjectEnrollmentEntry";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EDPCodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EncoderTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label TotalUnitsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeCol;
    }
}
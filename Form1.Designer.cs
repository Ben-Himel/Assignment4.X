namespace Assignment4._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lableResults = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMonthofAdmin = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addresss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthofAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInputStu = new System.Windows.Forms.Button();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxMonthAdmin = new System.Windows.Forms.TextBox();
            this.buttonSaveForm = new System.Windows.Forms.Button();
            this.buttonClearRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lableResults
            // 
            this.lableResults.AutoSize = true;
            this.lableResults.Location = new System.Drawing.Point(320, 24);
            this.lableResults.Name = "lableResults";
            this.lableResults.Size = new System.Drawing.Size(31, 15);
            this.lableResults.TabIndex = 3;
            this.lableResults.Text = "        ";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(20, 15);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(59, 15);
            this.labelStudentID.TabIndex = 4;
            this.labelStudentID.Text = "StudentID";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 45);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(64, 15);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 74);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(63, 15);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(95, 7);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 23);
            this.textBoxStudentID.TabIndex = 7;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(95, 36);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(95, 66);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(95, 95);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 23);
            this.textBoxAddress.TabIndex = 10;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(20, 103);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(49, 15);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // labelMonthofAdmin
            // 
            this.labelMonthofAdmin.AutoSize = true;
            this.labelMonthofAdmin.Location = new System.Drawing.Point(227, 69);
            this.labelMonthofAdmin.Name = "labelMonthofAdmin";
            this.labelMonthofAdmin.Size = new System.Drawing.Size(116, 15);
            this.labelMonthofAdmin.TabIndex = 14;
            this.labelMonthofAdmin.Text = "Month of Admission";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(227, 15);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(38, 15);
            this.labelGrade.TabIndex = 15;
            this.labelGrade.Text = "Grade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.First,
            this.Last,
            this.Addresss,
            this.Grade,
            this.MonthofAdmin});
            this.dataGridView1.Location = new System.Drawing.Point(20, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 330);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            // 
            // First
            // 
            this.First.HeaderText = "First";
            this.First.Name = "First";
            // 
            // Last
            // 
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            // 
            // Addresss
            // 
            this.Addresss.HeaderText = "Address";
            this.Addresss.Name = "Addresss";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // MonthofAdmin
            // 
            this.MonthofAdmin.HeaderText = "Month of Admin";
            this.MonthofAdmin.Name = "MonthofAdmin";
            // 
            // buttonInputStu
            // 
            this.buttonInputStu.Location = new System.Drawing.Point(367, 74);
            this.buttonInputStu.Name = "buttonInputStu";
            this.buttonInputStu.Size = new System.Drawing.Size(75, 44);
            this.buttonInputStu.TabIndex = 17;
            this.buttonInputStu.Text = "Input Student";
            this.buttonInputStu.UseVisualStyleBackColor = true;
            this.buttonInputStu.Click += new System.EventHandler(this.buttonInputStu_Click);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(227, 37);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxGrade.TabIndex = 18;
            // 
            // textBoxMonthAdmin
            // 
            this.textBoxMonthAdmin.Location = new System.Drawing.Point(227, 95);
            this.textBoxMonthAdmin.Name = "textBoxMonthAdmin";
            this.textBoxMonthAdmin.Size = new System.Drawing.Size(100, 23);
            this.textBoxMonthAdmin.TabIndex = 19;
            // 
            // buttonSaveForm
            // 
            this.buttonSaveForm.Location = new System.Drawing.Point(460, 74);
            this.buttonSaveForm.Name = "buttonSaveForm";
            this.buttonSaveForm.Size = new System.Drawing.Size(75, 44);
            this.buttonSaveForm.TabIndex = 20;
            this.buttonSaveForm.Text = "Save Form";
            this.buttonSaveForm.UseVisualStyleBackColor = true;
            this.buttonSaveForm.Click += new System.EventHandler(this.buttonSaveForm_Click);
            // 
            // buttonClearRows
            // 
            this.buttonClearRows.Location = new System.Drawing.Point(590, 94);
            this.buttonClearRows.Name = "buttonClearRows";
            this.buttonClearRows.Size = new System.Drawing.Size(75, 23);
            this.buttonClearRows.TabIndex = 21;
            this.buttonClearRows.Text = "Clear Rows";
            this.buttonClearRows.UseVisualStyleBackColor = true;
            this.buttonClearRows.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 488);
            this.Controls.Add(this.buttonClearRows);
            this.Controls.Add(this.buttonSaveForm);
            this.Controls.Add(this.textBoxMonthAdmin);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.buttonInputStu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelMonthofAdmin);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.lableResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lableResults;
        private Label labelStudentID;
        private Label labelFirstName;
        private Label labelLastName;
        private TextBox textBoxStudentID;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Label labelMonthofAdmin;
        private Label labelGrade;
        private DataGridView dataGridView1;
        private Button buttonInputStu;
        private TextBox textBoxGrade;
        private TextBox textBoxMonthAdmin;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn First;
        private DataGridViewTextBoxColumn Last;
        private DataGridViewTextBoxColumn Addresss;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn MonthofAdmin;
        private Button buttonSaveForm;
        private Button buttonClearRows;
    }
}
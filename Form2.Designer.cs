namespace TeacherManagmentSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtStudentId = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            btnTopGPA = new Button();
            btnDelete = new Button();
            txtGPA = new TextBox();
            btnAdd = new Button();
            dgvStudents = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtStudentId
            // 
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.Location = new Point(6, 35);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 0;
            txtStudentId.TextChanged += txtStudentId_TextChanged;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(6, 76);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 3;
            txtFName.TextChanged += txtFName_TextChanged;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(6, 120);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 23);
            txtLName.TabIndex = 4;
            txtLName.TextChanged += txtLName_TextChanged;
            // 
            // btnTopGPA
            // 
            btnTopGPA.Location = new Point(163, 115);
            btnTopGPA.Name = "btnTopGPA";
            btnTopGPA.Size = new Size(75, 23);
            btnTopGPA.TabIndex = 5;
            btnTopGPA.Text = "Top GPA";
            btnTopGPA.UseVisualStyleBackColor = true;
            btnTopGPA.Click += btnTopGPA_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(163, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(6, 162);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 7;
            txtGPA.TextChanged += txtGPA_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(163, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 253);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.Size = new Size(683, 191);
            dgvStudents.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtStudentId);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(btnTopGPA);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(txtGPA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 218);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Delete/Filter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 144);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 12;
            label4.Text = "GPA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 102);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 58);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 10;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Student ID";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(707, 456);
            Controls.Add(groupBox1);
            Controls.Add(dgvStudents);
            Name = "Form2";
            Text = "Admin Menu";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtStudentId;
        private TextBox txtFName;
        private TextBox txtLName;
        private Button btnTopGPA;
        private Button btnDelete;
        private TextBox txtGPA;
        private Button btnAdd;
        private DataGridView dgvStudents;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
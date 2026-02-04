using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeacherManagmentSystem
{
    public partial class Form2 : Form
    {
        BindingList<Student> students = new BindingList<Student>();


        public Form2()
        {
            InitializeComponent();
            dgvStudents.DataSource = students;

            students.Add(new Student { StudentId = 1, FirstName = "Miguel", LastName = "Doe", GPA = 3 });
            students.Add(new Student { StudentId = 2, FirstName = "Meatball", LastName = "Doe", GPA = 2 });
            students.Add(new Student { StudentId = 3, FirstName = "Kimberly", LastName = "Doe", GPA = 4 });
            students.Add(new Student { StudentId = 4, FirstName = "Hot", LastName = "Dog", GPA = 1 });



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int StudentId))
            {
                MessageBox.Show("Student ID required to continue");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("First Name required to continue");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Last Name required to continue");
                return;
            }
            if (!double.TryParse(txtGPA.Text,out double gpa))
            {
                MessageBox.Show("GPA required to continue");
                return;
            }
            else
            {

                Student student = new Student()
                {
                    StudentId = StudentId,
                    FirstName = txtFName.Text,
                    LastName = txtLName.Text,
                    GPA = gpa
                };

                students.Add(student);
                MessageBox.Show("Student Added!");

            }
            
            
        }


        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("No student selected");
            }
            else
            {
                Student selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
                students.Remove(selectedStudent);
            }

        }

        // really struggled with top gpa 
        private void btnTopGPA_Click(object sender, EventArgs e)
        {
            Student topstudent = students[0];

            foreach (Student student in students)
            {
                if (student.GPA > topstudent.GPA)
                {
                    topstudent = student;
                }
            }
            string output =
            $"StudentId: {topstudent.StudentId}\n" +
            $"Name: {topstudent.FirstName} {topstudent.LastName}\n" +
            $"GPA: {topstudent.GPA}";

            //saving to same folder as exe 
            string filePath = Path.Combine(Application.StartupPath, "TopStudent.txt");
            File.WriteAllText(filePath, output);

            MessageBox.Show($"Top student saved to:\n{filePath}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Lab1Dayrit
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get Information
            string StudentNo = txtStudentNo.Text;
            string LastName = txtLastName.Text;
            string FirstName = txtFirstName.Text;
            string Age = txtAge.Text;
            string BDay = datePickerBirthday.Text;
            string Program = cbProgram.SelectedItem.ToString();
            string Initial = txtInitial.Text;
            string Gender = cbGender.SelectedItem.ToString();
            string ContactNo = txtContactNo.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            StudentNo + ".txt")))
            {
                outputFile.WriteLine("Student No: " + StudentNo);
                outputFile.WriteLine("Full Name: " + LastName + ", " + FirstName + "," + Initial + ".");
                outputFile.WriteLine("Program: " + Program);
                outputFile.WriteLine("Gender: " + Gender);
                outputFile.WriteLine("Age: " + Age);
                outputFile.WriteLine("Birthday: " + BDay);
                outputFile.WriteLine("Contact No.: " + ContactNo);
            }

            MessageBox.Show("Student Registered", "Success!");
        }
    }
}

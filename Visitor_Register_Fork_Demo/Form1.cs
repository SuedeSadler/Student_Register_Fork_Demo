using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Register_Fork_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //SR 3.5 Format validation: creating regex object
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //SR3.3 Empty validation
            //using if-else-if (other conditional statements are allowed)
            if (FirstNameTxt.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK);
                FirstNameTxt.Focus();
            }
            else if (LastNameTxt.Text == "")
            {
                MessageBox.Show("Please enter your last name.", "Error", MessageBoxButtons.OK);
                LastNameTxt.Focus();
            }
            else if (genderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose your gender.");
                genderComboBox.Focus();
            }
            else if (PhoneTxt.Text == "")
            {
                MessageBox.Show("Please enter your phone number.", "Error", MessageBoxButtons.OK);
                PhoneTxt.Focus();
            }
            //SR 3.4 Numeric validation
            else if (!int.TryParse(PhoneTxt.Text, out var x))
            {
                MessageBox.Show("Phone number should be numeric only.", "Error", MessageBoxButtons.OK);
                PhoneTxt.Focus();
            }
            else if (EmailTxt.Text == "")
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK);
                EmailTxt.Focus();
            }
            //SR 3.5 Format validation
            else if (!regex.IsMatch(EmailTxt.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK);
                EmailTxt.Focus();
            }
            else if (courseComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.OK);
                courseComboBox.Focus();
            }
            //SR 3.6: Information display
            else
            {
                string dob = DOB_Dtp.Value.ToShortDateString();
                string gender = genderComboBox.SelectedItem.ToString();
                string course = courseComboBox.SelectedItem.ToString();

                FinalOutputListBox.Items.Add("======Student Enrollment Info======");
                FinalOutputListBox.Items.Add($"Full name: {FirstNameTxt.Text} {LastNameTxt.Text}");
                FinalOutputListBox.Items.Add($"DOB: {dob}");
                FinalOutputListBox.Items.Add($"Gender: {gender}");
                FinalOutputListBox.Items.Add($"Phone: {PhoneTxt.Text}");
                FinalOutputListBox.Items.Add($"Email: {EmailTxt.Text}");
                FinalOutputListBox.Items.Add($"Course: {course}");
                FinalOutputListBox.Items.Add("================================");

                ClearFields();
            }
        }

        //SR 3.8 reset all fields after pressing submit button
        private void ClearFields()
        {
            FirstNameTxt.Clear();
            LastNameTxt.Clear();
            DOB_Dtp.Value = DateTime.Now;
            genderComboBox.SelectedIndex = -1;
            PhoneTxt.Clear();
            EmailTxt.Clear();
            courseComboBox.SelectedIndex = -1;
        }

        //SR 3.9 delete function
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //DeleteAll();
            DeleteSelectedItem();
            //DeleteStudentInfo();
        }

        private void DeleteAll()
        {
            /*first way: clearing everything*/
            FinalOutputListBox.Items.Clear();
        }

        private void DeleteSelectedItem()
        {
            /*second way: index-based*/
            if (FinalOutputListBox.SelectedIndex != -1)
            {
                FinalOutputListBox.Items.RemoveAt(FinalOutputListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an information to delete.", "Error", MessageBoxButtons.OK);
            }
        }

        private void DeleteStudentInfo()
        {
            /*third way: selecting any item related to a student will delete all their info*/
            if (FinalOutputListBox.SelectedIndex != -1)
            {
                int selectedIndex = FinalOutputListBox.SelectedIndex;

                int startIndex = selectedIndex; //find start index of the student's info block
                while (startIndex >= 0 && !FinalOutputListBox.Items[startIndex].ToString().StartsWith("======"))
                {
                    startIndex--;
                }

                int endIndex = selectedIndex; //find end index of the info block
                while (endIndex < FinalOutputListBox.Items.Count && !FinalOutputListBox.Items[endIndex].ToString().StartsWith("======"))
                {
                    endIndex++;
                }

                // Ensure the endIndex includes the ending delimiter of the block
                if (endIndex < FinalOutputListBox.Items.Count)
                {
                    endIndex++;
                }

                // Remove the block of items from the ListBox
                for (int i = endIndex - 1; i >= startIndex; i--)
                {
                    FinalOutputListBox.Items.RemoveAt(i);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }
    
}

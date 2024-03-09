using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectA_199.validations;
using ProjectA_199.Persons;
using ProjectA_199.Lookups;
using ProjectA_199.Students;


namespace ProjectA_199
{
    public partial class StudentManage : Form
    {
        public StudentManage()
        {
            InitializeComponent();
            panel2.Hide();
            dateTimePicker1.Value = DateTime.Now;

            //// Clear existing items if needed
            //comboBox1.Items.Clear();

            //// Populate the ComboBox with gender values
            //foreach (string gender in Lookup.getGenders())
            //{
            //    comboBox1.Items.Add(gender);
            //}

            //// Select the first gender option by default
            //comboBox1.SelectedIndex = 0;
        }

        

        private void label9_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Show();
            button6.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
            button7.Hide();
        }

        //add student 
        private void button6_Click(object sender, EventArgs e)
        {

            if (Validate())
            {
                try
                {
                    Person.addPerson(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value, Lookup.getIndexFromValue(comboBox1.SelectedValue.ToString()));
                    Student.addStudent(Lookup.getIndexFromValue(comboBox1.SelectedValue.ToString()), regtextBox.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error Adding the record " + ex, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }

            
        }

        //update student
        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private bool validate()
        {
            if(!validation.name(textBox1.Text) || !validation.name(textBox2.Text))
            {
                MessageBox.Show("Name should be less than 100 characters", "Alert" , MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            else if(!validation.contact(textBox3.Text))
            {
                MessageBox.Show("Contact must be 11 digits and can only contain numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            else if(!validation.email(textBox4.Text))
            {
                MessageBox.Show("Please enter a valid email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            else if(!validation.DOB(dateTimePicker1.Value))
            {
                MessageBox.Show("Age is Below 18", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            return true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

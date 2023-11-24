using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace Libriary
{
    public partial class Form1 : Form
    {
        
        private string UserLog = "Nick";
        private string UserPass = "1232";
        private string StaffLog = "Monkey";
        private string StaffPass = "228";
        
        bool Us = false;
        bool Staff = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Us = true;
            Staff = false;
            label4.Text = "[USER]";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff = true;
            Us = false;
            label4.Text = "[STAFF]";
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Us == true)
            {
                if (textBox1.Text == UserLog && textBox2.Text == UserPass)
                {
                    MessageBox.Show("God Daaaamn bro!! Welcome to the Library ");
                    Form2 newForm = new Form2();
                    newForm.Show();
                    


                }
                else 
                {
                    MessageBox.Show("Damn, bro try agin pls!! thx >3");
                }
            }
            if(Staff == true)
            {
                if (textBox1.Text == StaffLog && textBox2.Text == StaffPass)
                {
                    MessageBox.Show("Welcome to Libriary!!");
                    Form3 newForm3 = new Form3();
                    newForm3.Show();
                    
                }
                else 
                {
                    MessageBox.Show("Try again :(");
                }
            }
            
            

        }

        
    }
}
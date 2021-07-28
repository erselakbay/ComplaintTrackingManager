using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            januaryToolStripMenuItem_Click(sender,e);
            label5.Text = "Compaint Types Description\n\nC1:Login Problem\nC2: Email Problem\nC3: Printer Problem\nC4: Hardware Problem\nC5: Software Problem";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                { throw new Exception("Please Write A Number On Box 1"); }
                if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                { throw new Exception("Please Write A Number On Box 2"); }
                if (string.IsNullOrEmpty(textBox3.Text.Trim()))
                { throw new Exception("Please Write A Number On Box 3"); }
                if (string.IsNullOrEmpty(textBox4.Text.Trim()))
                { throw new Exception("Please Write A Number On Box 4"); }
                if (string.IsNullOrEmpty(textBox5.Text.Trim()))
                { throw new Exception("Please Write A Number On Box 5"); }

            

                if (string.IsNullOrEmpty(label6.Text.Trim()))
                { throw new Exception("Please Select A Month"); } //calısmayacak

                Complaint cmp = new Complaint(label6.Text, int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                Complaintrepository cmpr = new Complaintrepository();
                cmpr.savedata(label6.Text,cmp);  //yaz

                var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
                textBox6.Text = total.ToString();

                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void januaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = januaryToolStripMenuItem.Text;


            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }


        }

        private void februaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = februaryToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            { 
            textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void marchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = marchToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void aprilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = aprilToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void mayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = mayToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void juneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = juneToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void julyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = julyToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void augustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = augustToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void septemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = septemberToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void octoberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = octoberToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void novemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = novemberToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void decemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = decemberToolStripMenuItem.Text;

            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)  //clear button
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            /*
             Or
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            */

           
        }

        private void button3_Click(object sender, EventArgs e) //reload button 
        {
            Complaintrepository cmpr = new Complaintrepository();
            Complaint cmp = cmpr.getdata(label6.Text); //oku

            textBox1.Text = cmp.c1.ToString();
            textBox2.Text = cmp.c2.ToString();
            textBox3.Text = cmp.c3.ToString();
            textBox4.Text = cmp.c4.ToString();
            textBox5.Text = cmp.c5.ToString();

            var total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text);
            textBox6.Text = total.ToString();

            if (int.Parse(textBox6.Text) == 0)
            {
                textBox11.Text = "0";
                textBox10.Text = "0";
                textBox9.Text = "0";
                textBox8.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                textBox11.Text = (int.Parse(textBox1.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox10.Text = (int.Parse(textBox2.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox9.Text = (int.Parse(textBox3.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox8.Text = (int.Parse(textBox4.Text) * 100 / int.Parse(textBox6.Text)).ToString();
                textBox7.Text = (int.Parse(textBox5.Text) * 100 / int.Parse(textBox6.Text)).ToString();
            }
        }
    }
}

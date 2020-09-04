using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mattson_AddressBookGUI
{
    public partial class Form1 : Form
    {
        ContactS con = new ContactS();
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // DISPLAY CONTACT INFO
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show(con.addressBook[0].fName + "\n"
                    + con.addressBook[0].lName + "\n"
                    + con.addressBook[0].Address + "\n"
                    + con.addressBook[0].City + "\n"
                    + con.addressBook[0].State + "\n"
                    + con.addressBook[0].Zip + "\n"
                    + con.addressBook[0].phoneNum + "\n"
                    + con.addressBook[0].Email);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show(con.addressBook[1].fName + "\n"
                    + con.addressBook[1].lName + "\n"
                    + con.addressBook[1].Address + "\n"
                    + con.addressBook[1].City + "\n"
                    + con.addressBook[1].State + "\n"
                    + con.addressBook[1].Zip + "\n"
                    + con.addressBook[1].phoneNum + "\n"
                    + con.addressBook[1].Email);
            }
            else 
            { MessageBox.Show("No contact selected"); }

        }

        //POPULATE COMBO BOX
        private void button2_Click(object sender, EventArgs e) 
        {
            comboBox1.Items.Add(con.addressBook[0].lName);
            comboBox1.Items.Add(con.addressBook[1].lName);
        }
    }
}

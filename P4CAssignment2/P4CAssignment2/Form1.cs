using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4CAssignment2
{
    public partial class MiniKeyboard : Form
    {
        int letternumber = -1; // global vairiable 

        bool firsttime = true; 

        public MiniKeyboard()
        {
            InitializeComponent();
        }

        private void btn_button7_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 7 into the global listbox
                lb_global.Items.AddRange(lb_button7.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void MiniKeyboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_button8_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 8 into the global listbox
                lb_global.Items.AddRange(lb_button8.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void btn_button9_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 9 into the global listbox
                lb_global.Items.AddRange(lb_button9.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_button7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_button2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer off
            lettertimer.Enabled = false; 

            // building the word
            txtb_multipress.AppendText(lb_global.Items[letternumber].ToString());
            letternumber = -1; //Resets the leter number variable

            firsttime = true; 

        }

        private void btn_button1_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 1 into the global listbox
                lb_global.Items.AddRange(lb_button1.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void btn_button2_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 2 into the global listbox
                lb_global.Items.AddRange(lb_button2.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void btn_button3_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 3 into the global listbox
                lb_global.Items.AddRange(lb_button3.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void btn_button6_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 6 into the global listbox
                lb_global.Items.AddRange(lb_button6.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true; 
        }

        private void btn_button5_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 5 into the global listbox
                lb_global.Items.AddRange(lb_button5.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true;
        }
    }
}

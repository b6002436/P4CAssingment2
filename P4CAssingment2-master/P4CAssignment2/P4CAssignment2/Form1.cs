using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;
using System.IO;

namespace P4CAssignment2
{
    public partial class MiniKeyboard : Form
    {
       // global vairiables
        int letternumber = -1; 

        bool firsttime = true;

        bool addword = false; 

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
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button hash into the global listbox
                lb_global.Items.AddRange(lb_zero.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
            // Moves the text onto a new line on the notepad textbox
            txt_notepad.AppendText(Environment.NewLine); 
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

        private void btn_mode_Click(object sender, EventArgs e)
        {
          //Changes mode status to multipess or prediction 
            if (btn_multipress.Text == "Multi-Press")
            {
                btn_multipress.Text = "Prediction";
            }
            else
            {
                btn_multipress.Text = "Multi-Press"; 
            }
        }

        private void btn_multipress_Click(object sender, EventArgs e)
        {

        }

        private void btn_button4_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button 4 into the global listbox
                lb_global.Items.AddRange(lb_button4.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true;
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                //Clears the global list box 
                lb_global.Items.Clear();

                //Adds contents of list box button star into the global listbox
                lb_global.Items.AddRange(lb_buttonstar.Items);
            }

            // Turns timer off
            lettertimer.Enabled = false;
            //Adds one onto the letter number variabe
            letternumber++;
            //turns the timer back on
            lettertimer.Enabled = true;
        }

        private void btn_space_Click(object sender, EventArgs e)
        {
            addword = true;

            if (addword == true)
            {
               // takes whats in multipress line and puts it in the notepad with a space before each word 
                txt_notepad.AppendText(" " + txtb_multipress.Text); 

                // clear the multipress textbox so its clear for the user to use next time 
                txtb_multipress.Clear(); //


            }
        }

        private void txtb_multipress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void txt_notepad_TextChanged(object sender, EventArgs e)
        {
            // shows the user where the cursor is on the notepad
            txt_notepad.Focus(); // shows the user where the cursor is on the notepad
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //brings up message box asking user to add new delay
            int letterInt = Convert.ToInt32(My_Dialogs.InputBox("Please enter the 'Delay Value' you require, 1000 is equal to a 1 second delay. At present the delay value is worth 500.")); 
           // sets the interval to 500
            lettertimer.Interval = 500;
           // makes timer interval equal the amount they put in the inputbox
            lettertimer.Interval = letterInt; 

        }

        private void lb_global_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C\\:"; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                MessageBox.Show("You opened this file : " + openFileDialog1.FileName);
            }
        }
    }
}

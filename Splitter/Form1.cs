using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splitter
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            input_textbox.ScrollBars = ScrollBars.Vertical;
            
        }

        private void split_button_Click(object sender, EventArgs e)
        {
            SplitAndAdd();
        }

        void SplitAndAdd()
        {
            string[] sentences = input_textbox.Text.Split('.', '!', '?');

            foreach (string i in sentences)
            {
                if (i != "")
                {
                    string j;

                    if (i[0] == ' ')
                    {
                        j = i.Substring(1);
                    }


                    else
                    {
                        j = i;
                    }

                    display_listbox.Items.Add(j[0].ToString().ToUpper() + j.Substring(1));
                }
            }
        }
    }
}

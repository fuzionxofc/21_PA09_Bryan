using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_PA09_Bryan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_value_Click(object sender, EventArgs e)
        {

        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_convertedAmt.Text = string.Empty;
            txt_amount.Text = string.Empty;
            rdb_JapaneseYen.Checked = false;
            rdb_USdollars.Checked = false;
            txt_error.Text = string.Empty;

        }

        private void Btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedvalue;

            if (rdb_USdollars.Checked == false || rdb_JapaneseYen.Checked == false)
            {
                txt_error.Text = "Select at least one type of currency to convert";
            }
            try
            {
                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }
                else if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }
            }
            catch(FormatException)
            {
                txt_error.Text = "Please enter a valid amount";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carPayLabel.Text = "";
            whyLabel.Text = "";
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            string input = resultTextBox.Text;
            try
            {
                int years = GetYears(input);
                string gender = GetGender();
                if (years <= 3)
                {
					carPayLabel.Text = "0元";
					whyLabel.Text = "三歲以下不用錢";
				}
                else if (gender == "男性" && years >= 70) 
                {
					carPayLabel.Text = "2元";
					whyLabel.Text = "七十歲以上男性";
				}
                else if (gender == "女性" && years >= 60)
                {
					carPayLabel.Text = "3元";
					whyLabel.Text = "六十歲以上女性";
				}
                else
                {
					carPayLabel.Text = "15元";
					whyLabel.Text = "全票";
				}
                //carPayLabel.Text = years.ToString();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetGender()
        {
            if (maleRadioButton.Checked)
            {
                return "男性";
            }else if (femaleRadioButton.Checked)
            {
                return "女性";
            }
            else
            {
                throw new Exception("請選擇性別");
            }

        }

        private int GetYears(string input)
        {
            bool isInt = int.TryParse(input, out int result);
            if (isInt == false)
            {
                throw new Exception("年齡必須為數字");
            }else if(result  < 0)
            {
                throw new Exception("年齡必須為正整數");
            }
            return result;

        }
    }
}

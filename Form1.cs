using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment_02
{
    public partial class Form1 : Form
    {
        string output;

        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };




        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_09_Click(object sender, EventArgs e)
        {
            try
            {


                string input = txtInput_09.Text;
                txtOutput_09.Text = "";


                for (int j = 0; j < input.Length; j++)
                {
                    char c = input[j];



                    if (char.IsLetter(c))
                    {
                        c = char.ToLower(c);
                        char replace = c;



                        if (vowels.Contains(c))
                        {
                            for (int i = 0; i < vowels.Length; i++)

                            {
                                if (vowels[i] == c)
                                {
                                    replace = vowels[i + 2];
                                   break;
                                }

                                output += replace;

                                break;
                            }




                           
                        }
                        else if (consonants.Contains(c))
                        {
                            for (int i = 0; i < consonants.Length; i++)
                            {
                                if (consonants[i] == c)
                                {
                                    if (i - 4 < 0)
                                    {
                                        replace = consonants[consonants.Length + (i - 4)];
                                        break;
                                    }

                                    else
                                    {
                                        replace = consonants[i - 4];
                                        
                                    }
                                    output += replace;

                                    break;
                                }

                            }


                        }

                        output += replace;
                    }



                    else if (char.IsDigit(c))
                    {                     
                        string replace = string.Empty;
                        int total = 0;
                        int Number = int.Parse(c.ToString());
                        int Reverse = 0;
                        int result = 0;
                        while (Number > 0)
                        {
                            int remainder = Number % 10;

                            Reverse = (Reverse * 10) + remainder;
                            Number = Number / 10;
                        }
                        result = Reverse;
                        total = result * 2;
                        replace = total.ToString();
                        txtOutput_09.Text = replace.ToString();

                        output += replace;


                    }



                    else 
                    {
                        string replace = string.Empty;
                        if (c == '.' || c == '!' || c == '?')
                        {

                            replace = ("#");

                            output += replace;

                        }

                    }

                }


                txtOutput_09.Text = output +"";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnClear_09_Click(object sender, EventArgs e)
        {
            txtInput_09.Clear();
            txtOutput_09.Clear();
            txtInput_09.Focus();





        }
    }
}

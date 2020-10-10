using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enteredPass_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // Conditions
                bool tamangHaba = false;
                bool upperCaseLowerCase = false;
                bool mayDigitSaGitna = false;
                bool letterAtNumber = false;
                // Getting LEngth
                string password = enteredPass.Text;
                int length = password.Length;
                // Condition of length
                if (length >= 3 && length <= 8)
                {
                    tamangHaba = true;
                }
                else
                {
                    tamangHaba = false;
                }
                // IF TRUE 
                if (tamangHaba)
                {
                    unlock.Visible = false;
                    locked.Visible = true;
             
                }
                else if (!tamangHaba)
                {
                    unlock.Visible = true;
                    locked.Visible = false;
                }
                // Dapat uppercase si first last character lower
                // Getting the first character in the entered pass
                int unangLetra = length - length;
                int hulingLetra = length - 1;
                // Sinave ko sa char yung last letter
                char last = password[hulingLetra];
                // Save sa first na char yung firstletter
                char first = password[unangLetra];
                // Convert sa ascii
                int firstAscii = (int)first;
                int lastAscii = (int)last;
                if ((firstAscii >= 65 && firstAscii <= 90) && (lastAscii >= 97 && lastAscii <= 122))
                {
                    upperCaseLowerCase = true;
                }
                else
                {
                    upperCaseLowerCase = false;
                }
                if (upperCaseLowerCase)
                {
                    unlock2.Visible = false;
                    locked2.Visible = true;
                }
                else if (!upperCaseLowerCase)
                {
                    locked2.Visible = false;
                    unlock2.Visible = true;
                }
                // THIRD CONDITION MAY NUMBER SA GITNA NI FIRST AT LAST
                if (length >= 3)
                {
                    int pangalawa = length - length + 1;
                    int pangalawaSaHuli = length - 2;
                    for (int i = pangalawa; i <= pangalawaSaHuli; i++)
                    {
                        char test = password[i];
                        int testInt = (int)test;
                        if (testInt >= 48 && testInt <=57)
                        {
                            mayDigitSaGitna = true;
                            break;
                        }
                        else
                        {
                            mayDigitSaGitna = false;
                        }
                    }
                    if (mayDigitSaGitna)
                    {
                        unlock3.Visible = false;
                        locked3.Visible = true;
                    }
                    else if (!mayDigitSaGitna)
                    {
                        locked3.Visible = false;
                        unlock3.Visible = true;
                    }
                  
                }
                // Fourth Condition
                
                for (int i = 0; i <= hulingLetra; i++)
                {
                    char numberLetter = password[i];
                    int numberLetterInt = (int)numberLetter;
                    if ((numberLetterInt >= 65 && numberLetterInt <=90) || (numberLetterInt >= 97&& numberLetterInt <= 122 ) || (numberLetterInt >= 48 && numberLetterInt <=57 ))
                    {
                        letterAtNumber = true;
                       
                    }
                    else
                    {
                        letterAtNumber = false;
                        break;
                    }
                }
                //Chcker
                if (letterAtNumber)
                {
                    unlock4.Visible = false;
                    locked4.Visible = true;
                }
                else if (!letterAtNumber)
                {
                    locked4.Visible = false;
                    unlock4.Visible = true;
                }
            }
            catch
            {
                
            }

        }
    }
}

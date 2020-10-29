using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        int r1 = 100;
        int r2 = 100;
        int[,] mat = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int z = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mat[0, 0] = rnd1.Next(1, 7);
            mat[0, 1] = rnd1.Next(1, 7);
            mat[0, 2] = rnd1.Next(1, 7);
            mat[0, 3] = rnd1.Next(1, 7);
            mat[0, 4] = rnd1.Next(1, 7);
            mat[1, 0] = rnd1.Next(1, 7);
            mat[1, 1] = rnd1.Next(1, 7);
            mat[1, 2] = rnd1.Next(1, 7);
            mat[1, 3] = rnd1.Next(1, 7);
            mat[1, 4] = rnd1.Next(1, 7);
            for(int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (mat[0, i] < mat[0, j]) 
                    {
                        z = mat[0, i];
                        mat[0, i] = mat[0, j];
                        mat[0, j] = z;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (mat[1, i] < mat[1, j])
                    {
                        z = mat[1, i];
                        mat[1, i] = mat[1, j];
                        mat[1, j] = z;
                    }
                }
            }
            if (mat[0, 0] == 1)
                pictureBox1.Image = Properties.Resources.kub1;
            if (mat[0, 0] == 2)
                pictureBox1.Image = Properties.Resources.kub2;
            if (mat[0, 0] == 3)
                pictureBox1.Image = Properties.Resources.kub3;
            if (mat[0, 0] == 4)
                pictureBox1.Image = Properties.Resources.kub4;
            if (mat[0, 0] == 5)
                pictureBox1.Image = Properties.Resources.kub5;
            if (mat[0, 0] == 6)
                pictureBox1.Image = Properties.Resources.kub6;
            if (mat[0, 1] == 1)
                pictureBox2.Image = Properties.Resources.kub1;
            if (mat[0, 1] == 2)
                pictureBox2.Image = Properties.Resources.kub2;
            if (mat[0, 1] == 3)
                pictureBox2.Image = Properties.Resources.kub3;
            if (mat[0, 1] == 4)
                pictureBox2.Image = Properties.Resources.kub4;
            if (mat[0, 1] == 5)
                pictureBox2.Image = Properties.Resources.kub5;
            if (mat[0, 1] == 6)
                pictureBox2.Image = Properties.Resources.kub6;
            if (mat[0, 2] == 1)
                pictureBox3.Image = Properties.Resources.kub1;
            if (mat[0, 2] == 2)
                pictureBox3.Image = Properties.Resources.kub2;
            if (mat[0, 2] == 3)
                pictureBox3.Image = Properties.Resources.kub3;
            if (mat[0, 2] == 4)
                pictureBox3.Image = Properties.Resources.kub4;
            if (mat[0, 2] == 5)
                pictureBox3.Image = Properties.Resources.kub5;
            if (mat[0, 2] == 6)
                pictureBox3.Image = Properties.Resources.kub6;
            if (mat[0, 3] == 1)
                pictureBox4.Image = Properties.Resources.kub1;
            if (mat[0, 3] == 2)
                pictureBox4.Image = Properties.Resources.kub2;
            if (mat[0, 3] == 3)
                pictureBox4.Image = Properties.Resources.kub3;
            if (mat[0, 3] == 4)
                pictureBox4.Image = Properties.Resources.kub4;
            if (mat[0, 3] == 5)
                pictureBox4.Image = Properties.Resources.kub5;
            if (mat[0, 3] == 6)
                pictureBox4.Image = Properties.Resources.kub6;
            if (mat[0, 4] == 1)
                pictureBox5.Image = Properties.Resources.kub1;
            if (mat[0, 4] == 2)
                pictureBox5.Image = Properties.Resources.kub2;
            if (mat[0, 4] == 3)
                pictureBox5.Image = Properties.Resources.kub3;
            if (mat[0, 4] == 4)
                pictureBox5.Image = Properties.Resources.kub4;
            if (mat[0, 4] == 5)
                pictureBox5.Image = Properties.Resources.kub5;
            if (mat[0, 4] == 6)
                pictureBox5.Image = Properties.Resources.kub6;
            if (mat[1, 0] == 1)
                pictureBox6.Image = Properties.Resources.kub1;
            if (mat[1, 0] == 2)
                pictureBox6.Image = Properties.Resources.kub2;
            if (mat[1, 0] == 3)
                pictureBox6.Image = Properties.Resources.kub3;
            if (mat[1, 0] == 4)
                pictureBox6.Image = Properties.Resources.kub4;
            if (mat[1, 0] == 5)
                pictureBox6.Image = Properties.Resources.kub5;
            if (mat[1, 0] == 6)
                pictureBox6.Image = Properties.Resources.kub6;
            if (mat[1, 1] == 1)
                pictureBox7.Image = Properties.Resources.kub1;
            if (mat[1, 1] == 2)
                pictureBox7.Image = Properties.Resources.kub2;
            if (mat[1, 1] == 3)
                pictureBox7.Image = Properties.Resources.kub3;
            if (mat[1, 1] == 4)
                pictureBox7.Image = Properties.Resources.kub4;
            if (mat[1, 1] == 5)
                pictureBox7.Image = Properties.Resources.kub5;
            if (mat[1, 1] == 6)
                pictureBox7.Image = Properties.Resources.kub6;
            if (mat[1, 2] == 1)
                pictureBox8.Image = Properties.Resources.kub1;
            if (mat[1, 2] == 2)
                pictureBox8.Image = Properties.Resources.kub2;
            if (mat[1, 2] == 3)
                pictureBox8.Image = Properties.Resources.kub3;
            if (mat[1, 2] == 4)
                pictureBox8.Image = Properties.Resources.kub4;
            if (mat[1, 2] == 5)
                pictureBox8.Image = Properties.Resources.kub5;
            if (mat[1, 2] == 6)
                pictureBox8.Image = Properties.Resources.kub6;
            if (mat[1, 3] == 1)
                pictureBox9.Image = Properties.Resources.kub1;
            if (mat[1, 3] == 2)
                pictureBox9.Image = Properties.Resources.kub2;
            if (mat[1, 3] == 3)
                pictureBox9.Image = Properties.Resources.kub3;
            if (mat[1, 3] == 4)
                pictureBox9.Image = Properties.Resources.kub4;
            if (mat[1, 3] == 5)
                pictureBox9.Image = Properties.Resources.kub5;
            if (mat[1, 3] == 6)
                pictureBox10.Image = Properties.Resources.kub6;
            if (mat[1, 4] == 1)
                pictureBox10.Image = Properties.Resources.kub1;
            if (mat[1, 4] == 2)
                pictureBox10.Image = Properties.Resources.kub2;
            if (mat[1, 4] == 3)
                pictureBox10.Image = Properties.Resources.kub3;
            if (mat[1, 4] == 4)
                pictureBox10.Image = Properties.Resources.kub4;
            if (mat[1, 4] == 5)
                pictureBox10.Image = Properties.Resources.kub5;
            if (mat[1, 4] == 6)
                pictureBox10.Image = Properties.Resources.kub6;
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Text = Convert.ToString(r1);
            textBox2.Text = Convert.ToString(r2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            if (checkBox1.Checked == true)
            {
                mat[0, 0] = rnd1.Next(1, 7);
            }
            if (checkBox2.Checked == true)
            {
                mat[0, 1] = rnd1.Next(1, 7);
            }
            if (checkBox3.Checked == true)
            {
                mat[0, 2] = rnd1.Next(1, 7);
            }
            if (checkBox4.Checked == true)
            {
                mat[0, 3] = rnd1.Next(1, 7);
            }
            if (checkBox5.Checked == true)
            {
                mat[0, 4] = rnd1.Next(1, 7);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (mat[0, i] < mat[0, j])
                    {
                        z = mat[0, i];
                        mat[0, i] = mat[0, j];
                        mat[0, j] = z;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (mat[1, i] < mat[1, j])
                    {
                        z = mat[1, i];
                        mat[1, i] = mat[1, j];
                        mat[1, j] = z;
                    }
                }
            }
            if ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] > mat[1, 4])) 
            {
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] > mat[1, 3]) && (mat[1, 3] > mat[1, 4]))
            {
                mat[1, 4] = rnd1.Next(1, 7);
                mat[1, 3] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] > mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] > mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
                mat[1, 1] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] > mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] > mat[1, 4]))
            {
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] > mat[1, 2]) && (mat[1, 2] > mat[1, 3]) && (mat[1, 3] == mat[1, 4]))
            {
                mat[1, 2] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] > mat[1, 3]) && (mat[1, 3] == mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] > mat[1, 2]) && (mat[1, 2] > mat[1, 3]) && (mat[1, 3] != mat[1, 4]))
            {
                mat[1, 2] = rnd1.Next(1, 7);
                mat[1, 3] = rnd1.Next(1, 7);
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] > mat[1, 3]) && (mat[1, 3] > mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
                mat[1, 3] = rnd1.Next(1, 7);
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] > mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] > mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
                mat[1, 1] = rnd1.Next(1, 7);
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] > mat[1, 1]) && (mat[1, 1] > mat[1, 2]) && (mat[1, 2] > mat[1, 3]) && (mat[1, 3] == mat[1, 4]))
            {
                mat[1, 0] = rnd1.Next(1, 7);
                mat[1, 1] = rnd1.Next(1, 7);
                mat[1, 2] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == 6) && (mat[1, 1] == 5) && (mat[1, 2] == 4) && (mat[1, 3] == 3) && (mat[1, 4] == 1))
            {
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == 6) && (mat[1, 1] == 5) && (mat[1, 2] == 4) && (mat[1, 3] == 2) && (mat[1, 4] == 1))
            {
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == 6) && (mat[1, 1] == 5) && (mat[1, 2] == 3) && (mat[1, 3] == 2) && (mat[1, 4] == 1))
            {
                mat[1, 4] = rnd1.Next(1, 7);
            }
            if ((mat[1, 0] == 6) && (mat[1, 1] == 4) && (mat[1, 2] == 3) && (mat[1, 3] == 3) && (mat[1, 4] == 1))
            {
                mat[1, 4] = rnd1.Next(1, 7);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (mat[1, i] < mat[1, j])
                    {
                        z = mat[1, i];
                        mat[1, i] = mat[1, j];
                        mat[1, j] = z;
                    }
                }
            } 
            if (mat[0, 0] == 1)
                pictureBox1.Image = Properties.Resources.kub1;
            if (mat[0, 0] == 2)
                pictureBox1.Image = Properties.Resources.kub2;
            if (mat[0, 0] == 3)
                pictureBox1.Image = Properties.Resources.kub3;
            if (mat[0, 0] == 4)
                pictureBox1.Image = Properties.Resources.kub4;
            if (mat[0, 0] == 5)
                pictureBox1.Image = Properties.Resources.kub5;
            if (mat[0, 0] == 6)
                pictureBox1.Image = Properties.Resources.kub6;
            if (mat[0, 1] == 1)
                pictureBox2.Image = Properties.Resources.kub1;
            if (mat[0, 1] == 2)
                pictureBox2.Image = Properties.Resources.kub2;
            if (mat[0, 1] == 3)
                pictureBox2.Image = Properties.Resources.kub3;
            if (mat[0, 1] == 4)
                pictureBox2.Image = Properties.Resources.kub4;
            if (mat[0, 1] == 5)
                pictureBox2.Image = Properties.Resources.kub5;
            if (mat[0, 1] == 6)
                pictureBox2.Image = Properties.Resources.kub6;
            if (mat[0, 2] == 1)
                pictureBox3.Image = Properties.Resources.kub1;
            if (mat[0, 2] == 2)
                pictureBox3.Image = Properties.Resources.kub2;
            if (mat[0, 2] == 3)
                pictureBox3.Image = Properties.Resources.kub3;
            if (mat[0, 2] == 4)
                pictureBox3.Image = Properties.Resources.kub4;
            if (mat[0, 2] == 5)
                pictureBox3.Image = Properties.Resources.kub5;
            if (mat[0, 2] == 6)
                pictureBox3.Image = Properties.Resources.kub6;
            if (mat[0, 3] == 1)
                pictureBox4.Image = Properties.Resources.kub1;
            if (mat[0, 3] == 2)
                pictureBox4.Image = Properties.Resources.kub2;
            if (mat[0, 3] == 3)
                pictureBox4.Image = Properties.Resources.kub3;
            if (mat[0, 3] == 4)
                pictureBox4.Image = Properties.Resources.kub4;
            if (mat[0, 3] == 5)
                pictureBox4.Image = Properties.Resources.kub5;
            if (mat[0, 3] == 6)
                pictureBox4.Image = Properties.Resources.kub6;
            if (mat[0, 4] == 1)
                pictureBox5.Image = Properties.Resources.kub1;
            if (mat[0, 4] == 2)
                pictureBox5.Image = Properties.Resources.kub2;
            if (mat[0, 4] == 3)
                pictureBox5.Image = Properties.Resources.kub3;
            if (mat[0, 4] == 4)
                pictureBox5.Image = Properties.Resources.kub4;
            if (mat[0, 4] == 5)
                pictureBox5.Image = Properties.Resources.kub5;
            if (mat[0, 4] == 6)
                pictureBox5.Image = Properties.Resources.kub6;
            if (mat[1, 0] == 1)
                pictureBox6.Image = Properties.Resources.kub1;
            if (mat[1, 0] == 2)
                pictureBox6.Image = Properties.Resources.kub2;
            if (mat[1, 0] == 3)
                pictureBox6.Image = Properties.Resources.kub3;
            if (mat[1, 0] == 4)
                pictureBox6.Image = Properties.Resources.kub4;
            if (mat[1, 0] == 5)
                pictureBox6.Image = Properties.Resources.kub5;
            if (mat[1, 0] == 6)
                pictureBox6.Image = Properties.Resources.kub6;
            if (mat[1, 1] == 1)
                pictureBox7.Image = Properties.Resources.kub1;
            if (mat[1, 1] == 2)
                pictureBox7.Image = Properties.Resources.kub2;
            if (mat[1, 1] == 3)
                pictureBox7.Image = Properties.Resources.kub3;
            if (mat[1, 1] == 4)
                pictureBox7.Image = Properties.Resources.kub4;
            if (mat[1, 1] == 5)
                pictureBox7.Image = Properties.Resources.kub5;
            if (mat[1, 1] == 6)
                pictureBox7.Image = Properties.Resources.kub6;
            if (mat[1, 2] == 1)
                pictureBox8.Image = Properties.Resources.kub1;
            if (mat[1, 2] == 2)
                pictureBox8.Image = Properties.Resources.kub2;
            if (mat[1, 2] == 3)
                pictureBox8.Image = Properties.Resources.kub3;
            if (mat[1, 2] == 4)
                pictureBox8.Image = Properties.Resources.kub4;
            if (mat[1, 2] == 5)
                pictureBox8.Image = Properties.Resources.kub5;
            if (mat[1, 2] == 6)
                pictureBox8.Image = Properties.Resources.kub6;
            if (mat[1, 3] == 1)
                pictureBox9.Image = Properties.Resources.kub1;
            if (mat[1, 3] == 2)
                pictureBox9.Image = Properties.Resources.kub2;
            if (mat[1, 3] == 3)
                pictureBox9.Image = Properties.Resources.kub3;
            if (mat[1, 3] == 4)
                pictureBox9.Image = Properties.Resources.kub4;
            if (mat[1, 3] == 5)
                pictureBox9.Image = Properties.Resources.kub5;
            if (mat[1, 3] == 6)
                pictureBox10.Image = Properties.Resources.kub6;
            if (mat[1, 4] == 1)
                pictureBox10.Image = Properties.Resources.kub1;
            if (mat[1, 4] == 2)
                pictureBox10.Image = Properties.Resources.kub2;
            if (mat[1, 4] == 3)
                pictureBox10.Image = Properties.Resources.kub3;
            if (mat[1, 4] == 4)
                pictureBox10.Image = Properties.Resources.kub4;
            if (mat[1, 4] == 5)
                pictureBox10.Image = Properties.Resources.kub5;
            if (mat[1, 4] == 6)
                pictureBox10.Image = Properties.Resources.kub6;
            if (((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4]))||((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
            {
                if ((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4]))
                {
                    if ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4]))
                    {
                        if(mat[0,0]==mat[1,0])
                        {
                            textBox1.Text = Convert.ToString(r1);
                            textBox2.Text = Convert.ToString(r2);
                        }
                        if(mat[0,0]>mat[1,0])
                        {
                            r1 += 10;
                            r2 -= 10;
                            textBox1.Text = Convert.ToString(r1);
                            textBox2.Text = Convert.ToString(r2);
                        }
                        if (mat[0, 0] > mat[1, 0])
                        {
                            r2 += 10;
                            r1 -= 10;
                            textBox1.Text = Convert.ToString(r1);
                            textBox2.Text = Convert.ToString(r2);
                        }
                    }
                    else
                    {
                        r1 += 10;
                        r2 -= 10;
                        textBox1.Text = Convert.ToString(r1);
                        textBox2.Text = Convert.ToString(r2);
                    }
                }
                else 
                {
                    r2 += 10;
                    r1 -= 10;
                    textBox1.Text = Convert.ToString(r1);
                    textBox2.Text = Convert.ToString(r2);
                }
            }
            else 
            {
                if(((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3])) || ((mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]))|| ((mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                {
                    if(((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3])) || ((mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])))
                    {
                        if(((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3])) || ((mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                        {
                            if (mat[0, 2] == mat[1, 2])
                            {
                                textBox1.Text = Convert.ToString(r1);
                                textBox2.Text = Convert.ToString(r2);
                            }
                            if (mat[0, 2] < mat[1, 2])
                            {
                                r2 += 10;
                                r1 -= 10;
                                textBox1.Text = Convert.ToString(r1);
                                textBox2.Text = Convert.ToString(r2);
                            }
                            if (mat[0, 2] > mat[1, 2])
                            {
                                r1 += 10;
                                r2 -= 10;
                                textBox1.Text = Convert.ToString(r1);
                                textBox2.Text = Convert.ToString(r2);                           
                            }
                        }
                        else
                        {
                            r1 += 10;
                            r2 -= 10;
                            textBox1.Text = Convert.ToString(r1);
                            textBox2.Text = Convert.ToString(r2);
                        }
                    }
                    else
                    {
                        r2 += 10;
                        r1 -= 10;
                        textBox1.Text = Convert.ToString(r1);
                        textBox2.Text = Convert.ToString(r2);
                    }
                }
                else
                {
                    if (((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 3] == mat[0, 4])) || ((mat[0, 0] == mat[0, 1]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 3] == mat[1, 4])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                    {
                        if (((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 3] == mat[0, 4])) || ((mat[0, 0] == mat[0, 1]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])))
                        {
                            if (((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 3] == mat[1, 4])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                            {
                                if (((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 3] == mat[0, 4])) & ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 3] == mat[1, 4])))
                                {
                                    if (mat[0, 0] == mat[1, 0])
                                    {
                                        if (mat[0, 3] == mat[1, 3])
                                        {
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 3] > mat[1, 3])
                                        {
                                            r1 += 10;
                                            r2 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 3] < mat[1, 3])
                                        {
                                            r2 += 10;
                                            r1 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                    }
                                    if (mat[0, 0] < mat[1, 0])
                                    {
                                        r2 += 10;
                                        r1 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                    if (mat[0, 0] > mat[1, 0])
                                    {
                                        r1 += 10;
                                        r2 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                                if (((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2]) && (mat[0, 3] == mat[0, 4])) & ((mat[1, 0] == mat[1, 1]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                                {
                                    if (mat[0, 0] == mat[1, 2])
                                    {
                                        if (mat[0, 3] == mat[1, 0])
                                        {
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 3] > mat[1, 0])
                                        {
                                            r1 += 10;
                                            r2 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 3] < mat[1, 0])
                                        {
                                            r2 += 10;
                                            r1 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                    }
                                    if (mat[0, 0] < mat[1, 2])
                                    {
                                        r2 += 10;
                                        r1 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                    if (mat[0, 0] > mat[1, 2])
                                    {
                                        r1 += 10;
                                        r2 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                                if (((mat[0, 0] == mat[0, 1]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])) & ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2]) && (mat[1, 3] == mat[1, 4])))
                                {
                                    if (mat[0, 2] == mat[1, 0])
                                    {
                                        if (mat[0, 0] == mat[1, 3])
                                        {
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 0] > mat[1, 3])
                                        {
                                            r1 += 10;
                                            r2 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 0] < mat[1, 3])
                                        {
                                            r2 += 10;
                                            r1 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                    }
                                    if (mat[0, 2] < mat[1, 0])
                                    {
                                        r2 += 10;
                                        r1 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                    if (mat[0, 2] > mat[1, 0])
                                    {
                                        r1 += 10;
                                        r2 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                                if (((mat[0, 0] == mat[0, 1]) && (mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])) & ((mat[1, 0] == mat[1, 1]) && (mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                                {
                                    if (mat[0, 2] == mat[1, 2])
                                    {
                                        if (mat[0, 0] == mat[1, 0])
                                        {
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 0] > mat[1, 0])
                                        {
                                            r1 += 10;
                                            r2 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 0] < mat[1, 0])
                                        {
                                            r2 += 10;
                                            r1 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                    }
                                    if (mat[0, 2] < mat[1, 2])
                                    {
                                        r2 += 10;
                                        r1 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                    if (mat[0, 2] > mat[1, 2])
                                    {
                                        r1 += 10;
                                        r2 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                            }
                            else
                            {
                                r1 += 10;
                                r2 -= 10;
                                textBox1.Text = Convert.ToString(r1);
                                textBox2.Text = Convert.ToString(r2);
                            }
                        }
                        else
                        {
                            r2 += 10;
                            r1 -= 10;
                            textBox1.Text = Convert.ToString(r1);
                            textBox2.Text = Convert.ToString(r2);
                        }
                    }
                    else
                    {
                        if (((mat[0, 0]==5) && (mat[0, 1] == 4) && (mat[0, 2] == 3) && (mat[0, 3] == 2) && (mat[0, 4] == 1)) || ((mat[0, 0] == 6) && (mat[0, 1] == 5) && (mat[0, 2] == 4) && (mat[0, 3] == 3) && (mat[0, 4] == 2)) || ((mat[1, 0] == 5) && (mat[1, 1] == 4) && (mat[1, 2] == 3) && (mat[1, 3] == 2) && (mat[1, 4] == 1)) || ((mat[1, 0] == 6) && (mat[1, 1] == 5) && (mat[1, 2] == 4) && (mat[1, 3] == 3) && (mat[1, 4] == 2)))
                        {
                            if(((mat[0, 0] == 5) && (mat[0, 1] == 4) && (mat[0, 2] == 3) && (mat[0, 3] == 2) && (mat[0, 4] == 1)) || ((mat[0, 0] == 6) && (mat[0, 1] == 5) && (mat[0, 2] == 4) && (mat[0, 3] == 3) && (mat[0, 4] == 2)))
                            {
                                if(((mat[1, 0] == 5) && (mat[1, 1] == 4) && (mat[1, 2] == 3) && (mat[1, 3] == 2) && (mat[1, 4] == 1)) || ((mat[1, 0] == 6) && (mat[1, 1] == 5) && (mat[1, 2] == 4) && (mat[1, 3] == 3) && (mat[1, 4] == 2)))
                                {
                                    if(mat[1,0]==mat[1,0])
                                    {
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                    if (mat[1, 0] < mat[1, 0])
                                    {
                                        r2 += 10;
                                        r1 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                    if (mat[1, 0] > mat[1, 0])
                                    {
                                        r1 += 10;
                                        r2 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }

                                }
                                else
                                {
                                    r1 += 10;
                                    r2 -= 10;
                                    textBox1.Text = Convert.ToString(r1);
                                    textBox2.Text = Convert.ToString(r2);
                                }
                            }
                            else
                            {
                                r2 += 10;
                                r1 -= 10;
                                textBox1.Text = Convert.ToString(r1);
                                textBox2.Text = Convert.ToString(r2);
                            }
                        }
                        else
                        {
                            if(((mat[0,0]==mat[0,1]) && (mat[0, 1] == mat[0, 2])) || ((mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3])) || ((mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2])) || ((mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3]))|| ((mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                            {
                                if(((mat[0, 0] == mat[0, 1]) && (mat[0, 1] == mat[0, 2])) || ((mat[0, 1] == mat[0, 2]) && (mat[0, 2] == mat[0, 3])) || ((mat[0, 2] == mat[0, 3]) && (mat[0, 3] == mat[0, 4])))
                                {
                                    if(((mat[1, 0] == mat[1, 1]) && (mat[1, 1] == mat[1, 2])) || ((mat[1, 1] == mat[1, 2]) && (mat[1, 2] == mat[1, 3])) || ((mat[1, 2] == mat[1, 3]) && (mat[1, 3] == mat[1, 4])))
                                    {
                                        if (mat[0, 2] == mat[1, 2])
                                        {
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 2] > mat[1, 2])
                                        {
                                            r1 += 10;
                                            r2 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                        if (mat[0, 2] < mat[1, 2])
                                        {
                                            r2 += 10;
                                            r1 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }                          
                                    }
                                    else
                                    {
                                        r1 += 10;
                                        r2 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                                else
                                {
                                    r2 += 10;
                                    r1 -= 10;
                                    textBox1.Text = Convert.ToString(r1);
                                    textBox2.Text = Convert.ToString(r2);
                                }
                            }
                            else 
                            {
                                if(((mat[0,0]==mat[0,1]) && (mat[0, 2] == mat[0, 3]))|| ((mat[0, 0] == mat[0, 1]) && (mat[0, 3] == mat[0, 4]))|| ((mat[0, 1] == mat[0, 2]) && (mat[0, 3] == mat[0, 4]))|| ((mat[1, 0] == mat[1, 1]) && (mat[1, 2] == mat[1, 3])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 3] == mat[1, 4])) || ((mat[1, 1] == mat[1, 2]) && (mat[1, 3] == mat[1, 4])))
                                {
                                    if(((mat[0, 0] == mat[0, 1]) && (mat[0, 2] == mat[0, 3])) || ((mat[0, 0] == mat[0, 1]) && (mat[0, 3] == mat[0, 4])) || ((mat[0, 1] == mat[0, 2]) && (mat[0, 3] == mat[0, 4])))
                                    {
                                        if(((mat[1, 0] == mat[1, 1]) && (mat[1, 2] == mat[1, 3])) || ((mat[1, 0] == mat[1, 1]) && (mat[1, 3] == mat[1, 4])) || ((mat[1, 1] == mat[1, 2]) && (mat[1, 3] == mat[1, 4])))
                                        {
                                            if((mat[0,1]+mat[0,3])== (mat[0, 1] + mat[0, 3]))
                                            {
                                                textBox1.Text = Convert.ToString(r1);
                                                textBox2.Text = Convert.ToString(r2);
                                            }
                                            if ((mat[0, 1] + mat[0, 3]) > (mat[0, 1] + mat[0, 3]))
                                            {
                                                r1 += 10;
                                                r2 -= 10;
                                                textBox1.Text = Convert.ToString(r1);
                                                textBox2.Text = Convert.ToString(r2);
                                            }
                                            if ((mat[0, 1] + mat[0, 3]) < (mat[0, 1] + mat[0, 3]))
                                            {
                                                r2 += 10;
                                                r1 -= 10;
                                                textBox1.Text = Convert.ToString(r1);
                                                textBox2.Text = Convert.ToString(r2);
                                            }
                                        }
                                        else
                                        {
                                            r1 += 10;
                                            r2 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                    }
                                    else
                                    {
                                        r2 += 10;
                                        r1 -= 10;
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                                else
                                {
                                    if ((mat[0, 0] == mat[0,1])|| (mat[0, 1] == mat[0, 2]) || (mat[0, 2] == mat[0, 3]) || (mat[0, 3] == mat[0, 4]) || (mat[1, 0] == mat[1, 1]) || (mat[1, 1] == mat[1, 2]) || (mat[1, 2] == mat[1, 3]) || (mat[1, 3] == mat[1, 4]))
                                    {
                                        if((mat[0, 0] == mat[0, 1]) || (mat[0, 1] == mat[0, 2]) || (mat[0, 2] == mat[0, 3]) || (mat[0, 3] == mat[0, 4]))
                                        {
                                            if((mat[1, 0] == mat[1, 1]) || (mat[1, 1] == mat[1, 2]) || (mat[1, 2] == mat[1, 3]) || (mat[1, 3] == mat[1, 4]))
                                            {
                                                if((mat[0, 0] == mat[0, 1]) && (mat[1, 0] == mat[1, 1]))
                                                {
                                                    if (mat[0, 0] == mat[1, 1]) 
                                                    {                                                       
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] > mat[1, 1]) 
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if(mat[0, 0] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 0] == mat[0, 1]) && (mat[1, 1] == mat[1, 2]))
                                                {
                                                    if (mat[0, 0] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 0] == mat[0, 1]) && (mat[1, 2] == mat[1, 3]))
                                                {
                                                    if (mat[0, 0] == mat[1, 2])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] > mat[1, 2])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] < mat[1, 2])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 0] == mat[0, 1]) && (mat[1, 3] == mat[1, 4]))
                                                {
                                                    if (mat[0, 0] == mat[1, 3])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] > mat[1, 3])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 0] < mat[1, 3])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 1] == mat[0, 2]) && (mat[1, 0] == mat[1, 1]))
                                                {
                                                    if (mat[0, 2] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 1] == mat[0, 2]) && (mat[1, 1] == mat[1, 2]))
                                                {
                                                    if (mat[0, 2] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 1] == mat[0, 2]) && (mat[1, 2] == mat[1, 3]))
                                                {
                                                    if (mat[0, 2] == mat[1, 2])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 2])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 2])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 1] == mat[0, 2]) && (mat[1, 3] == mat[1, 4]))
                                                {
                                                    if (mat[0, 2] == mat[1, 4])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 4])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 4])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 2] == mat[0, 3]) && (mat[1, 0] == mat[1, 1]))
                                                {
                                                    if (mat[0, 2] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 2] == mat[0, 3]) && (mat[1, 1] == mat[1, 2]))
                                                {
                                                    if (mat[0, 2] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 2] == mat[0, 3]) && (mat[1, 2] == mat[1, 3]))
                                                {
                                                    if (mat[0, 2] == mat[1, 3])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 3])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 3])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 2] == mat[0, 3]) && (mat[1, 3] == mat[1, 4]))
                                                {
                                                    if (mat[0, 2] == mat[1, 3])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] > mat[1, 3])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 2] < mat[1, 3])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 3] == mat[0, 4]) && (mat[1, 0] == mat[1, 1]))
                                                {
                                                    if (mat[0, 3] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 3] == mat[0, 4]) && (mat[1, 1] == mat[1, 2]))
                                                {
                                                    if (mat[0, 3] == mat[1, 1])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] > mat[1, 1])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] < mat[1, 1])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 3] == mat[0, 4]) && (mat[1, 2] == mat[1, 3]))
                                                {
                                                    if (mat[0, 3] == mat[1, 3])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] > mat[1, 3])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] < mat[1, 3])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                                if ((mat[0, 3] == mat[0, 4]) && (mat[1, 3] == mat[1, 4]))
                                                {
                                                    if (mat[0, 3] == mat[1, 3])
                                                    {
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] > mat[1, 3])
                                                    {
                                                        r1 += 10;
                                                        r2 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                    if (mat[0, 3] < mat[1, 3])
                                                    {
                                                        r2 += 10;
                                                        r1 -= 10;
                                                        textBox1.Text = Convert.ToString(r1);
                                                        textBox2.Text = Convert.ToString(r2);
                                                    }
                                                }
                                            }   
                                            else
                                            {
                                                r1 += 10;
                                                r2 -= 10;
                                                textBox1.Text = Convert.ToString(r1);
                                                textBox2.Text = Convert.ToString(r2);
                                            }
                                        }    
                                        else
                                        {
                                            r2 += 10;
                                            r1 -= 10;
                                            textBox1.Text = Convert.ToString(r1);
                                            textBox2.Text = Convert.ToString(r2);
                                        }
                                    }
                                    else
                                    {
                                        textBox1.Text = Convert.ToString(r1);
                                        textBox2.Text = Convert.ToString(r2);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}

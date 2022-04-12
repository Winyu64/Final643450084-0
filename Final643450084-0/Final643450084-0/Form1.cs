namespace Final643450084_0
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                string data = File.ReadAllText(filepath);
                this.textBox1.Text = data;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 1;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        double a2, a3, a4, a5, a6,a7,a8,a9,a10,a11, b2, b3, b4, b5, b6,b7,b8,b9,b10,b11, sum2, sum3, sum4, sum5, sum6,sum7,sum8,sum9,sum10,sum11, alltotal, alltotal1, alltotal2, alltotal3, alltotal4, alltotal5, alltotal6;

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // textBox13.Text=

            alltotal4 = int.Parse(textBox13.Text);
            //int aaa2 = int.Parse(textBox12.Text);
            alltotal5 = alltotal4 - alltotal3;
            textBox14.Text = alltotal5.ToString();
            //alltotal4 = aa1 - aa2;
            //textBox14.Text = alltotal4.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "1234")
                MessageBox.Show("กรุณาใส่ ส่วนลดให้ถูกต้อง");
            else
            {
                MessageBox.Show("ใช่ส่วนลด 5%");
                alltotal2 = alltotal * 5 / 100;
                alltotal3 = alltotal - alltotal2;

                textBox10.Text = alltotal3.ToString();

                textBox11.Text = alltotal2.ToString();
                textBox12.Text = textBox10.Text;

            }


            //alltotal2 = 
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                numericUpDown5.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown5.Value = 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ซื้อขั้นต่ำ 50 บาท คุญได้รับส่วนลด 5%");
            MessageBox.Show("หรัสส่วนลดคือ >>1234<<");
            a2 = 0;
            a3 = 0;
            a4 = 0;
            a5 = 0;
            a6 = 0;
            a7 = 0;
            a8 = 0;
            a9 = 0;
            a10 = 0;
            a11 = 0;
            //a22 = 0;
            //a33 = 0;
            //a44 = 0;
            //a55 = 0;
            //a66 = 0;

            textBox2.Text = numericUpDown5.Value.ToString();
            textBox3.Text = numericUpDown4.Value.ToString();
            textBox4.Text = numericUpDown3.Value.ToString();
            textBox5.Text = numericUpDown2.Value.ToString();
            textBox6.Text = numericUpDown1.Value.ToString();
            textBox15.Text = numericUpDown10.Value.ToString();
            textBox16.Text = numericUpDown9.Value.ToString();
            textBox17.Text = numericUpDown7.Value.ToString();
            textBox18.Text = numericUpDown8.Value.ToString();
            textBox19.Text = numericUpDown6.Value.ToString();

            if (checkBox1.Checked)
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 150;
                sum6 = b6 * a6;
            }
            else
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 150;
                sum6 = b6 * a6;
            }

            if (checkBox2.Checked)
            {
                b5 = double.Parse(textBox5.Text);
                a5 = 60;
                sum5 = b5 * a5;
            }
            else
            {
                b5 = double.Parse(textBox5.Text);
                a5 = 60;
                sum5 = b5 * a5;
            }

            if (checkBox3.Checked)
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 250;
                sum4 = b4 * a4;
            }
            else
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 360;
                sum4 = b4 * a4;
            }

            if (checkBox4.Checked)
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 350;
                sum3 = b3 * a3;
            }
            else
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 350;
                sum3 = b3 * a3;
            }

            if (checkBox5.Checked)
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 380;
                sum2 = b2 * a2;
            }
            else
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 380;
                sum2 = b2 * a2;
            }

            if (checkBox6.Checked)
            {
                b11 = double.Parse(textBox19.Text);
                a11 = 550;
                sum11 = b11 * a11;
            }
            else
            {
                b11 = double.Parse(textBox19.Text);
                a11 = 550;
                sum11 = b11 * a11;
            }

            if (checkBox5.Checked)
            {
                b10 = double.Parse(textBox18.Text);
                a10 = 120;
                sum10 = b10 * a10;
            }
            else
            {
                b10 = double.Parse(textBox18.Text);
                a10 = 120;
                sum10 = b10 * a10;
            }

            if (checkBox7.Checked)
            {
                b7 = double.Parse(textBox15.Text);
                a7 = 120;
                sum7 = b7 * a7;
            }
            else
            {
                b7 = double.Parse(textBox15.Text);
                a7 = 800;
                sum7 = b7 * a7;
            }

            if (checkBox9.Checked)
            {
                b8 = double.Parse(textBox16.Text);
                a8 = 180;
                sum8 = b8 * a8;
            }
            else
            {
                b8 = double.Parse(textBox16.Text);
                a8 = 180;
                sum8 = b8 * a8;
            }

            if (checkBox10.Checked)
            {
                b9 = double.Parse(textBox17.Text);
                a9 = 80;
                sum9 = b9 * a9;
            }
            else
            {
                b9 = double.Parse(textBox17.Text);
                a9 = 80;
                sum9 = b9 * a9;
            }


            alltotal = sum2 + sum3 + sum4 + sum5 + sum6 + sum7 + sum8 + sum9 + sum10 + sum11;
            textBox8.Text = alltotal.ToString();

            alltotal1 = b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10 + b11;
            textBox7.Text = alltotal1.ToString();

            //int a2 = int.Parse(textBox2.Text);
            //int a3 = int.Parse(textBox3.Text);
            //int a4 = int.Parse(textBox4.Text);
            //int a5 = int.Parse(textBox5.Text);
            //int a6 = int.Parse(textBox6.Text);
            //int sumall= a2 + a3 + a4 + a5 + a6;
            //textBox7.Text = sumall.ToString();
            //int a22 = a2 * 380;
            //int a33 = a3 * 350;
            //int a44 = a4 * 250;
            //int a55 = a5 * 60;
            //int a66 = a6 * 150;
            //int sumall1= a22 + a33 + a44 + a55 + a66;
            //textBox8.Text = sumall1.ToString();




            ///   textBox7.Text = textBox2.Text+ textBox3.Text+ textBox4.Text+ textBox5.Text+ textBox6.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox7.Text = "";
            //textBox6.Text = "";
            //textBox5.Text = "";
            //textBox4.Text = "";
            //textBox3.Text = "";
            //textBox2.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ปิดการทำงาน");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
             {
                Form2 f2 = new Form2();
                f2.Show();
                //f2.textBox1.Text = textBox15.Text;
             }
        }
    }
}
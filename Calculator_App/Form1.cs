namespace Calculator_App
{
    public partial class Form1 : Form
    {

        private int? num1;
        private int? num2;
        private int? result;
        private String? sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            sign = "/";

            label1.Text = textBox1.Text;
            label3.Text = sign;
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            sign = "*";

            label1.Text = textBox1.Text;
            label3.Text = sign;

            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            sign = "%";
            label1.Text = textBox1.Text;
            label3.Text = sign;
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            sign = "+";

            label1.Text = textBox1.Text ;
            label3.Text = sign;

            textBox1.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {   
            num2 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text;
            if (sign =="+")
            {
                result = num1 + num2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = num1 * num2;
                textBox1.Text = Convert.ToString(result);
            }
           else if (sign == "-")
            {
                result = num1 - num2;
                textBox1.Text = Convert.ToString(result);
            }
           else if (sign == "/")
            {
                result = num1 / num2;
                textBox1.Text = Convert.ToString(result);
            }

            else if (sign == "%")
            {
                result = num1 % num2;
                textBox1.Text = Convert.ToString(result);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);

            sign = "-";

            label1.Text = textBox1.Text ;
            label3.Text = sign;

            textBox1.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
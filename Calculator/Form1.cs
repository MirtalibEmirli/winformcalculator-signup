namespace Calculator
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int y = 0;
        string cem;
        bool clear ;
        char op ;
        public Form1()
        {
            InitializeComponent();
        }

        private void bol_Click(object sender, EventArgs e)
        {

            op = '/';

            clear = true;
            x = Convert.ToInt32(label1.Text);
            label1.Text = "0";
        }

        private void vur_Click(object sender, EventArgs e)
        {
            op = '*';

            clear = true;
            x = Convert.ToInt32(label1.Text);
            label1.Text = "0";
        }

        private void cx_Click(object sender, EventArgs e)
        {
            op = '-';

            clear = true;
            x = Convert.ToInt32(label1.Text);
            label1.Text = "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op = '+';
            clear = true;
           x = Convert.ToInt32(label1.Text);
            label1.Text = "0"; 

          
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            y = Convert.ToInt32(label1.Text);
           
            switch (op)
            {

                case '+':
                    cem = (x + y).ToString();

                    break;
                case '*':

                    cem = (x * y).ToString();



                    break;

                case '-':
                    cem = (x - y).ToString();



                    break;
                case '/':

                    cem = (x / y).ToString();

                    break;

                default:
                    break;
            }





            label1.Text = cem;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (clear) { label1.Text = "";
                clear = false;
            } 
            if (label1.Text == "0") label1.Text = ""; 
            
            label1.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";
        }

        private void dord_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";
        }

        private void yeddi_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";
        }

        private void sekkiz_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";
        }

        private void doqquz_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                label1.Text = "";
                clear = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            if (clear) label1.Text = "";

            label1.Text += "0";

        }
    }
}

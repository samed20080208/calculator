using System.Media;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        int num1 , num2;
        int netice;
        char op;
        public Form1()
        {
            InitializeComponent();
        }
        protected void check(int num)
        {
            if (screen.Text.Length <= 24)
            {
                screen.Text += num;
            }
            else
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.Play();
            }
        }
        protected void check_op(char op)
        {
            if (this.op == '+' || this.op == '-' || this.op == '/' || this.op == '*' || this.op == '%')
            {
                MessageBox.Show(" Artıq operator seçmisiniz ");
            }
            this.op = op;
            if (screen.Text == "" || screen.Text == " ")
            {
                SoundPlayer sound = new SoundPlayer();
                sound.Play();
                
            }
            else
            {
                num1 = int.Parse(screen.Text);
                screen.Text = "";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            check(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            check(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            check(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            check(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            check(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            check(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            check(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            check(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            check(9);
        }
        private void toplama_Click(object sender, EventArgs e)
        {
            check_op('+');
        }
        private void cixma_Click(object sender, EventArgs e)
        {
            check_op('-');
        }
        private void bolme_Click(object sender, EventArgs e)
        {
            check_op('/');
        }
        private void vurma_Click(object sender, EventArgs e)
        {
            check_op('*');
        }
        private void faiz_Click(object sender, EventArgs e)
        {
            check_op('%');
        }
        private void equales_Click(object sender, EventArgs e)
        {
            num2 =int.Parse(screen.Text.ToString());
            if (this.op == '+')
            {
                netice = num2 + num1;
                screen.Text = netice.ToString();
            }
            else if (this.op == '-')
            {
                netice = num2 - num1;
                screen.Text = netice.ToString();
            }
            else if (this.op == '/')
            {
                netice = num2 / num1;
                screen.Text = netice.ToString();
            }
            else if (this.op == '*')
            {
                netice = num2 * num1;
                screen.Text = netice.ToString();
            }
            else if (this.op == '%')
            {
                netice = num1 * num2 / 100;
                screen.Text = netice.ToString();
            }
            this.op = ' ';
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            screen.Text = "";
        }
        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (screen.Text.EndsWith(' '))
            {
               screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
               screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
               screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
            }
            else if (screen.Text == "" || screen.Text == " ")
            {
                SoundPlayer sound = new SoundPlayer();
                sound.Play();
            }
            else
                screen.Text.Remove(Text.Length - 1, 1);
                
        }
    }
}

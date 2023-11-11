namespace HW_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxFirst.Text = "0";
            textBoxSecond.Text = "0";
            timer1.Start();
            comboBoxDo.SelectedIndex = 0;
        }

        private void buttonCanculate_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxFirst.Text, out int first);
            int.TryParse(textBoxSecond.Text, out int second);
            if (comboBoxDo.SelectedIndex == 0)
            {
                textBoxResult.Text = Convert.ToString((first + second));
            }
            else if (comboBoxDo.SelectedIndex == 1)
            {
                textBoxResult.Text = Convert.ToString((first - second));
            }
            else if (comboBoxDo.SelectedIndex == 2)
            {
                textBoxResult.Text = Convert.ToString((first * second));
            }
            else if (comboBoxDo.SelectedIndex == 3)
            {
                textBoxResult.Text = Convert.ToString((first / second));
            }
            else if (comboBoxDo.SelectedIndex == 4)
            {
                textBoxResult.Text = Convert.ToString((first % second));
            }
            else if (comboBoxDo.SelectedIndex == 5)
            {
                textBoxResult.Text = Convert.ToString(((int)Math.Pow(first, second)));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.Text = $"Canculator {date}";
        }
    }
}
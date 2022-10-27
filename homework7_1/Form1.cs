namespace homework7_1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public int num;
        private int randNum;
        public Form1()
        {
            InitializeComponent();
            GuessNum(num, random.Next(1, 100));
        }
        private void GuessNum(int num)
        {
            this.num = num;
        }
        private void GuessNum(int userNum, int randNum)
        {
            GuessNum(userNum);
            this.randNum = randNum;
        }
        private void Win()
        {
            if (num == randNum)
            {
                textBox1.Clear();
                label1.Text = "";
                MessageBox.Show("Вы Победили!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OneMoreTime();
            }
            else if (randNum > num)
            {
                label1.Text = "Ну вот! Ваше число меньше загаданного!";
            }
            else if (randNum < num)
            {
                label1.Text = "Ну вот! Ваше число больше загаданного!";
            }
        }
        private void OneMoreTime()
        {
            if (MessageBox.Show("Хотите сыграть еще разок?", "Может Вы..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuessNum(num, random.Next(1, 100));
            }
            else
            {
                Close();
            }
        }
        private void buttonUser_Click(object sender, EventArgs e)
        {
            var result = int.TryParse(textBox1.Text, out num); //трай парс, чтобы при вводе НЕ числа программа не шла дальше
            if (result)
            {
                GuessNum(num);
                Win();
            }
            else
                MessageBox.Show("Вы ввели не число! Так нельзя!", "Ай-яй-яй", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }

}
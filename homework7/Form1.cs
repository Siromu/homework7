
using System;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {

        private Random random = new Random();
        private int userNum;
        private int randNum;
        int count;

        


    public Form1()
        {
            InitializeComponent();
            ResetGame(userNum, random.Next(1, 40), count);
        }

        private void ResetGame(int userNum) //��������� ������ ����� ������������, � ������� �� ��������
        {
            labelUser.Text = $"���� �����: {userNum}"; 
        }

        private void ResetGame(int userNum, int randNum, int count) //��������� ��� ����� ��� ������ ����� ����, ���������� ����
        {
            ResetGame(userNum);
            this.randNum = randNum;
            this.count = count;
            labelCount.Text = $"����� �������: {count}";
            labelRandom.Text = $"�������� �����: {randNum}";
        }

        private void OneMoreTime()
        {
            if (MessageBox.Show("������ ������� ��� �����?", "����� ��..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userNum = 0;
                ResetGame(userNum, random.Next(40), 0);
            }
            else
            {
                Close();
            }
        }

        private void CheckWin()
        {
            if (userNum == randNum)
            {
                MessageBox.Show("�� ��������!", "�����������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OneMoreTime();
            }
            else if (randNum < userNum)
            {
                MessageBox.Show("�� ���������..", "��� ������� :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OneMoreTime();
            }


        }

        private void Count()
        {
                count++;
                labelCount.Text = $"����� �������: {count}";
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            userNum = 0;
            count = 0;
            ResetGame(userNum, random.Next(40), count);
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            ResetGame(userNum *= 2);
            Count();
            CheckWin();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPLus_Click(object sender, EventArgs e)
        {
            ResetGame(++userNum);
            Count();
            CheckWin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
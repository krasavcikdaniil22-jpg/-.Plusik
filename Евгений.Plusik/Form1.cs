namespace Евгений.Plusik
{
    public partial class FormMain : Form
    {
        Random rnd = new Random();

        int TargetNum;
        int UserNum = 1;
        int StepsCount = 0;

        public FormMain()
        {
            InitializeComponent();
            Generate();
        }

        private void Generate()
        {
            UserNum = 1;
            StepsCount = 0;
            TargetNum = rnd.Next(15, 101);


            labelUserNumber.Text = UserNum.ToString();
            labelUserSteps.Text = StepsCount.ToString();
            labelTargetNumber.Text = TargetNum.ToString();

        }

        int Optimum(int k)
        {
            int steps = 0;
            while (k != 1)
            {
                if (k % 2 == 0)
                    k = k / 2;
                else
                    k = k - 1;
                steps++;
            }
            return steps;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            UserNum++;
            StepsCount++;
            labelUserNumber.Text = UserNum.ToString();
            labelUserSteps.Text = StepsCount.ToString();

            if (UserNum == TargetNum)
            {
                if (StepsCount == Optimum(TargetNum))
                    MessageBox.Show("Вы выиграли))!");
                else
                    MessageBox.Show("Вы выиграли, однако можно было быстрее!");

                UserNum = 1;
                StepsCount = 0;
                labelUserNumber.Text = UserNum.ToString();
                labelUserSteps.Text = StepsCount.ToString();
            }
            else if (UserNum > TargetNum)
            {
                MessageBox.Show("Вы проиграли((!");
                UserNum = 1;
                StepsCount = 0;
                labelUserNumber.Text = UserNum.ToString();
                labelUserSteps.Text = StepsCount.ToString();
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            UserNum *= 2;
            StepsCount++;
            labelUserNumber.Text = UserNum.ToString();
            labelUserSteps.Text = StepsCount.ToString();

            if (UserNum == TargetNum)
            {
                if (StepsCount == Optimum(TargetNum))
                    MessageBox.Show("Вы выиграли))!");
                else
                    MessageBox.Show("Вы выиграли, однако можно было быстрее!");

                UserNum = 1;
                StepsCount = 0;
                labelUserNumber.Text = UserNum.ToString();
                labelUserSteps.Text = StepsCount.ToString();
            }
            else if (UserNum > TargetNum)
            {
                MessageBox.Show("Вы проиграли((!");
                UserNum = 1;
                StepsCount = 0;
                labelUserNumber.Text = UserNum.ToString();
                labelUserSteps.Text = StepsCount.ToString();
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            UserNum = 1;
            StepsCount = 0;         

            labelUserNumber.Text = UserNum.ToString();
            labelUserSteps.Text = StepsCount.ToString();
        }

        private void buttonSpecifyNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum.Text))
            {
                MessageBox.Show("Пожалуйста, введите число!");
                return;
            }

            int enteredNumber;
            if (!int.TryParse(textBoxNum.Text, out enteredNumber))
            {
                MessageBox.Show("Это не число! Введите только цифры.");
                return;
            }

            TargetNum = enteredNumber;
            labelTargetNumber.Text = TargetNum.ToString();


            UserNum = 1;
            StepsCount = 0;
            labelUserNumber.Text = UserNum.ToString();
            labelUserSteps.Text = StepsCount.ToString();
        }


        private void buttonRandomNumber_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            //Случайно нажал >:()
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Та же история
        }
    }
}

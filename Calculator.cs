using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // okay honestly idk how this part works.... but it works so f*ck it
        // dragg form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //..  


        public decimal answer = 0;
        bool shouldClear = true;
        bool afterSym = false;
        decimal num1 = 0;      
        string symbol;

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + sevenBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + sevenBtn.Text;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + eightBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + eightBtn.Text;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + nineBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + nineBtn.Text;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + fourBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + fourBtn.Text;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + fiveBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + fiveBtn.Text;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + sixBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + sixBtn.Text;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + oneBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + oneBtn.Text;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + twoBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + twoBtn.Text;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + threeBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + threeBtn.Text;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (afterSym == true && shouldClear == true)
            {
                bigLabel.Text = "";
                bigLabel.Text = bigLabel.Text + zeroBtn.Text;
                shouldClear = false;
            }
            else
                bigLabel.Text = bigLabel.Text + zeroBtn.Text;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!bigLabel.Text.Contains(","))
            {
                if (bigLabel.Text == string.Empty)
                {
                    if (afterSym == true && shouldClear == true)
                    {
                        bigLabel.Text = "";
                        bigLabel.Text = bigLabel.Text + zeroBtn.Text + dotBtn.Text;
                        shouldClear = false;
                    }
                    else
                        bigLabel.Text = bigLabel.Text + zeroBtn.Text + dotBtn.Text;
                }
                else
                {
                    if (afterSym == true && shouldClear == true)
                    {
                        bigLabel.Text = "";
                        bigLabel.Text = bigLabel.Text + zeroBtn.Text + dotBtn.Text;
                        shouldClear = false;
                    }
                    else
                        bigLabel.Text = bigLabel.Text + dotBtn.Text;
                }

            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterSym == true)
                {
                    num1 = Convert.ToDecimal(bigLabel.Text);
                    switch (symbol)
                    {
                        case "%":
                            answer = Decimal.Round(answer % num1, 0);
                            break;
                        case "+":
                            answer = Decimal.Round(answer + num1, 4);
                            break;
                        case "-":
                            answer = Decimal.Round(answer - num1, 4);
                            break;
                        case "/":
                            answer = Decimal.Round(answer / num1, 4);
                            break;
                        case "*":
                            answer = Decimal.Round(answer * num1, 4);
                            break;
                        case "=":
                            answer = Convert.ToDecimal(bigLabel.Text);

                            smallLabel.Text = bigLabel.Text;
                            bigLabel.Text = "";
                            break;
                    }
                    smallLabel.Text = smallLabel.Text + bigLabel.Text + addBtn.Text;
                    bigLabel.Text = answer.ToString();
                }
                else
                {
                    smallLabel.Text = bigLabel.Text + addBtn.Text;
                    answer = Convert.ToDecimal(bigLabel.Text);
                    bigLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            symbol = "+";
            afterSym = true;
            shouldClear = true;

        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterSym == true)
                {
                    num1 = Convert.ToDecimal(bigLabel.Text);
                    switch (symbol)
                    {
                        case "%":
                            answer = Decimal.Round(answer % num1, 0);
                            break;
                        case "+":
                            answer = Decimal.Round(answer + num1, 4);
                            break;
                        case "-":
                            answer = Decimal.Round(answer - num1, 4);
                            break;
                        case "/":
                            answer = Decimal.Round(answer / num1, 4);
                            break;
                        case "*":
                            answer = Decimal.Round(answer * num1, 4);
                            break;
                        case "=":
                            answer = Convert.ToDecimal(bigLabel.Text);

                            smallLabel.Text = bigLabel.Text;
                            bigLabel.Text = "";
                            break;
                    }
                    smallLabel.Text = smallLabel.Text + bigLabel.Text + subtractBtn.Text;
                    bigLabel.Text = answer.ToString();
                }
                else
                {
                    smallLabel.Text = bigLabel.Text + subtractBtn.Text;
                    answer = Convert.ToDecimal(bigLabel.Text);
                    bigLabel.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            symbol = "-";
            afterSym = true;
            shouldClear = true;
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterSym == true)
                {
                    num1 = Convert.ToDecimal(bigLabel.Text);
                    switch (symbol)
                    {
                        case "%":
                            answer = Decimal.Round(answer % num1, 0);
                            break;
                        case "+":
                            answer = Decimal.Round(answer + num1, 4);
                            break;
                        case "-":
                            answer = Decimal.Round(answer - num1, 4);
                            break;
                        case "/":
                            answer = Decimal.Round(answer / num1, 4);
                            break;
                        case "*":
                            answer = Decimal.Round(answer * num1, 4);
                            break;
                        case "=":
                            answer = Convert.ToDecimal(bigLabel.Text);

                            smallLabel.Text = bigLabel.Text;
                            bigLabel.Text = "";
                            break;

                    }
                    smallLabel.Text = smallLabel.Text + bigLabel.Text + multiplyBtn.Text;
                    bigLabel.Text = answer.ToString();
                }
                else
                {
                    smallLabel.Text = bigLabel.Text + multiplyBtn.Text;
                    answer = Convert.ToDecimal(bigLabel.Text);
                    bigLabel.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            symbol = "*";
            afterSym = true;
            shouldClear = true;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterSym == true)
                {
                    num1 = Convert.ToDecimal(bigLabel.Text);
                    switch (symbol)
                    {
                        case "%":
                            answer = Decimal.Round(answer % num1, 0);
                            break;
                        case "+":
                            answer = Decimal.Round(answer + num1, 4);
                            break;
                        case "-":
                            answer = Decimal.Round(answer - num1, 4);
                            break;
                        case "/":
                            answer = Decimal.Round(answer / num1, 4);
                            break;
                        case "*":
                            answer = Decimal.Round(answer * num1, 4);
                            break;
                        case "=":
                            answer = Convert.ToDecimal(bigLabel.Text);

                            smallLabel.Text = bigLabel.Text;
                            bigLabel.Text = "";
                            break;

                    }
                    smallLabel.Text = smallLabel.Text + bigLabel.Text + divideBtn.Text;
                    bigLabel.Text = answer.ToString();
                }
                else
                {
                    smallLabel.Text = bigLabel.Text + divideBtn.Text;
                    answer = Convert.ToDecimal(bigLabel.Text);
                    bigLabel.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            symbol = "/";
            afterSym = true;
            shouldClear = true;
        }

        private void moduloBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterSym == true)
                {
                    num1 = Convert.ToDecimal(bigLabel.Text);
                    switch (symbol)
                    {
                        case "%":
                            answer = Decimal.Round(answer % num1, 0);
                            break;
                        case "+":
                            answer = Decimal.Round(answer + num1, 4);
                            break;
                        case "-":
                            answer = Decimal.Round(answer - num1, 4);
                            break;
                        case "/":
                            answer = Decimal.Round(answer / num1, 4);
                            break;
                        case "*":
                            answer = Decimal.Round(answer * num1, 4);
                            break;
                        case "=":
                            answer = Convert.ToDecimal(bigLabel.Text);

                            smallLabel.Text = bigLabel.Text;
                            bigLabel.Text = "";
                            break;

                    }
                    smallLabel.Text = smallLabel.Text + bigLabel.Text + moduloBtn.Text;
                    bigLabel.Text = answer.ToString();
                }
                else
                {
                    smallLabel.Text = bigLabel.Text + moduloBtn.Text;
                    answer = Convert.ToDecimal(bigLabel.Text);
                    bigLabel.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            symbol = "%";
            afterSym = true;
            shouldClear = true;
        }
        private void equalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterSym == true)
                {
                    num1 = Convert.ToDecimal(bigLabel.Text);
                    switch (symbol)
                    {
                        case "%":
                            answer = Decimal.Round(answer % num1, 0);
                            break;
                        case "+":
                            answer = Decimal.Round(answer + num1, 4);
                            break;
                        case "-":
                            answer = Decimal.Round(answer - num1, 4);
                            break;
                        case "/":
                            answer = Decimal.Round(answer / num1, 4);
                            break;
                        case "*":
                            answer = Decimal.Round(answer * num1, 4);
                            break;
                        case "=":
                            answer = Convert.ToDecimal(bigLabel.Text);
                            smallLabel.Text = bigLabel.Text;
                            bigLabel.Text = "";
                            break;
                    }
                    smallLabel.Text = "";
                    bigLabel.Text = answer.ToString();
                }
                else
                {
                    answer = Convert.ToDecimal(bigLabel.Text);
                    bigLabel.Text = answer.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            afterSym = true;
            symbol = "=";
            shouldClear = true;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(bigLabel.Text);
            temp = Math.Log10(temp);
            answer = Decimal.Round(Convert.ToDecimal(temp), 4);
            bigLabel.Text = answer.ToString();

            afterSym = true;
            symbol = "=";
            shouldClear = true;
        }

        private void squareRootBtn_Click(object sender, EventArgs e)
        {

            double temp = Convert.ToDouble(bigLabel.Text);
            temp = Math.Sqrt(temp);
            answer = Decimal.Round(Convert.ToDecimal(temp), 4);
            bigLabel.Text = answer.ToString();

            afterSym = true;
            symbol = "=";
            shouldClear = true;
        }

        private void squaredBtn_Click(object sender, EventArgs e)
        {
            decimal temp = Convert.ToDecimal(bigLabel.Text);
            answer = temp; ;
            answer = Decimal.Round(answer * answer, 4);
            bigLabel.Text = answer.ToString();

            afterSym = true;
            symbol = "=";
            shouldClear = true;
        }

        private void piBtn_Click(object sender, EventArgs e)
        {
            const decimal PI = 3.14m;
            decimal temp = Convert.ToDecimal(bigLabel.Text);
            answer = Decimal.Round(temp * PI);
            bigLabel.Text = answer.ToString();

            afterSym = true;
            symbol = "=";
            shouldClear = true;
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            bigLabel.Text = "";
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            bigLabel.Text = "";
            smallLabel.Text = "";
            num1 = 0;
            answer = 0;
            afterSym = false;
        }

        private void backSpaceBtn_Click(object sender, EventArgs e)
        {
            if (bigLabel.Text != string.Empty)
            {
                bigLabel.Text = bigLabel.Text.Substring(0, bigLabel.Text.Length - 1);
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void minimizeBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(minimizeBtn, "Minimize");
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(exitBtn, "Exit");
        }
    }
}

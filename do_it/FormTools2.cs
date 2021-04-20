using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Tulpep.NotificationWindow;

namespace do_it
{
    public partial class FormTools2 : Form
    {
        public FormTools2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Process.Start("www.gmail.com");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("www.drive.google.com");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Process.Start("www.youtube.com");
        }
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://teams.microsoft.com/");
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://web.telegram.org/");
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://zoom.us/");
        }

        private void btnmap_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/");
        }

        private void FormTools2_Load(object sender, EventArgs e)
        {

        }
        int min = 00;
        int sec = 00;
        int milisec = 00;


        private void StopWatch_Tick(object sender, EventArgs e)
        {


            milisec++;
            if (milisec > 99)
            {
                milisec = 00;
                sec++;
            }
            if (sec > 59)
            {
                sec = 00;
                min++;
            }
            lblstpwatch.Text = min.ToString("00") + ":" + sec.ToString("00") + ":" + milisec.ToString("00");


        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            lblstpwatch.Text = "00:00:00";
            min = 00;
            sec = 00;
            milisec = 00;
        }

        private void btnstrat_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }
        string curenttime;
        string messagetime;
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            curenttime = DateTime.Now.ToString("hh:mm:ss:tt");
            //label5.Text = curenttime;
        }
        

        private void timer3_Tick(object sender, EventArgs e)
        {

            messagetime = txtH.Text + ":" + txtmin.Text + ":" + txtss.Text + ":" + comboBox1.Text;



            if (curenttime == messagetime)
            {
                timer2.Stop();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info_30px;
                popup.TitleText = "Reminder";
                popup.ContentText = textBox1.Text;
                popup.Popup();
                curenttime = null;

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label2.Text = "reminder set for " + messagetime;
        }

        private void btnnstop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label2.Text = "";
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com");
        }
        const string divideByZero = "Err!";
        const string syntaxErr = "SYNTAX ERROR!";
        bool decimalPointActive = false;
   
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDisplay.Text)) return;
            Clipboard.SetText(txtDisplay.Text);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            decimalPointActive = false;
            PreCheck_ButtonClick();
            previousOperation = Operation.None;
            txtDisplay.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            decimalPointActive = false;
            PreCheck_ButtonClick();
            if (txtDisplay.Text.Length > 0)
            {
                double d;
                if (!double.TryParse(txtDisplay.Text[txtDisplay.Text.Length - 1].ToString(), out d))
                {
                    previousOperation = Operation.None;
                }

                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text.Length == 0)
            {
                previousOperation = Operation.None;
            }
            if (previousOperation != Operation.None)
            {
                currentOperation = previousOperation;
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Div;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            txtDisplay.Text += (sender as Button).Text;
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Mul;
            PerformCalculation(previousOperation);
            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            txtDisplay.Text += (sender as Button).Text;
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength == 0 || previousOperation == Operation.Sub) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Sub;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            txtDisplay.Text += (sender as Button).Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength == 0) return;
            PreCheck_ButtonClick();
            currentOperation = Operation.Add;
            PerformCalculation(previousOperation);

            previousOperation = currentOperation;
            EnableOperatorButtons(false);
            txtDisplay.Text += (sender as Button).Text;
        }

        private void PerformCalculation(Operation previousOperation)
        {
            try
            {
                if (previousOperation == Operation.None)
                    return;
                List<double> lstNums = null;

                switch (previousOperation)
                {
                    case Operation.Add:
                        if (currentOperation == Operation.Sub)
                        {
                            currentOperation = Operation.Add;
                            return;
                        }
                        lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                        txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                        break;
                    case Operation.Sub:
                        int idx = txtDisplay.Text.LastIndexOf('-'); // To handle ex: -9-2
                        if (idx > 0)
                        {
                            var op1 = Convert.ToDouble(txtDisplay.Text.Substring(0, idx));
                            var op2 = Convert.ToDouble(txtDisplay.Text.Substring(idx + 1));
                            txtDisplay.Text = (op1 - op2).ToString();
                        }
                        break;
                    case Operation.Mul:
                        if (currentOperation == Operation.Sub)
                        {
                            currentOperation = Operation.Mul;
                            return;
                        }
                        lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                        txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                        break;
                    case Operation.Div:
                        if (currentOperation == Operation.Sub)
                        {
                            currentOperation = Operation.Div;
                            return;
                        }
                        try
                        {
                            lstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                            if (lstNums[1] == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            txtDisplay.Text = (lstNums[0] / lstNums[1]).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            txtDisplay.Text = divideByZero;
                        }
                        break;
                    case Operation.None:
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                txtDisplay.Text = syntaxErr;
            }
        }

        private void BtnNum_Click(object btn, EventArgs e)
        {
            if (txtDisplay.Text == syntaxErr || txtDisplay.Text == divideByZero)
            {
                txtDisplay.Text = string.Empty;
            }
            EnableOperatorButtons();
            PreCheck_ButtonClick();
            txtDisplay.Text += (btn as Button).Text;
        }

        private void PreCheck_ButtonClick()
        {
            if (txtDisplay.Text == divideByZero || txtDisplay.Text == syntaxErr)
                txtDisplay.Clear();
            if (previousOperation != Operation.None)
            {
                EnableOperatorButtons();
            }
        }

        private void EnableOperatorButtons(bool enable = true)
        {
            btnMul.Enabled = enable;
            btnDiv.Enabled = enable;
            btnAdd.Enabled = enable;
            if (!enable)
            {
                decimalPointActive = false;
            }
            //btnSub.Enabled = enable;
        }
        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        Operation previousOperation = Operation.None;
        Operation currentOperation = Operation.None;

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength == 0) return;
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.None;
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (decimalPointActive) return;
            if (txtDisplay.Text == syntaxErr || txtDisplay.Text == divideByZero)
            {
                txtDisplay.Text = string.Empty;
            }
            EnableOperatorButtons();
            PreCheck_ButtonClick();
            txtDisplay.Text += (sender as Button).Text;
            decimalPointActive = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}


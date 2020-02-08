using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFineCalc5
{
    // TODO rename the file.
   
    public partial class Form1 : Form
    {

        public const int cServiceMultiplyer = 3;
        public const int maxFine = 75000;
        public const int maxTasks = 150;

        String charges = "";
        int fineSum = 0;
        int timeSum = 0;
        int userID = 0;
        int timeLeft = 0;
        int timeLeftClear = 0;
        int timeLeftLoad = 0;

        public Form1()
        {
            InitializeComponent();
        }

       

        //Moving Violation check box:
        private void MovingViolationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeSum = 0;
            fineSum = 0;
            MovingViolationListBox.CheckOnClick = true;


            chargesBox.Items.Clear();
            
            foreach (string s in MovingViolationListBox.CheckedItems)
            {
                
                var offense = Offenses.ViolationByName[s];

                var offenseInfo = Offenses.MovingViolationData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}"); // using the ternary ? : operator.
                
                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;            
            }

            foreach (string s in MisdemeanorsListBox.CheckedItems)
            {

                var offense = Offenses.MisdemeanorByName[s];

                var offenseInfo = Offenses.MisdemeanorsData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }

            foreach (string s in FeloniesListBox.CheckedItems)
            {

                var offense = Offenses.FeloniesByName[s];

                var offenseInfo = Offenses.FeloniesData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }

            
            if (fineSum > Form1.maxFine)
            {
                fineSum = Form1.maxFine;
                FineTB.Value = fineSum;  
            } 
            if (timeSum > Form1.maxTasks)
            {
                timeSum = Form1.maxTasks;
                CServiceTB.Value = timeSum;
                timeSum = Form1.maxTasks;
            }

            FineTB.Value = fineSum;
            CServiceTB.Value = timeSum;
        }
        private void clearCalcButton_Click(object sender, EventArgs e)
        {
            charges = "";
            fineSum = 0;
            timeSum = 0;
            userID = 0;
            chargesBox.Items.Clear();
            chargesBox.Items.Add("No Charges Selected");
            FineTB.Value = 0;
            CServiceTB.Value = 0;
            userIDBox.Value = 0;

            while (MovingViolationListBox.CheckedIndices.Count > 0)
                MovingViolationListBox.SetItemChecked(MovingViolationListBox.CheckedIndices[0], false);

            while (MisdemeanorsListBox.CheckedIndices.Count > 0)
                MisdemeanorsListBox.SetItemChecked(MisdemeanorsListBox.CheckedIndices[0], false);

            while (FeloniesListBox.CheckedIndices.Count > 0)
                FeloniesListBox.SetItemChecked(FeloniesListBox.CheckedIndices[0], false);

            clearCalcButton.BackColor = Color.LimeGreen;
            clearCalcButton.Text = "Cleared Calc!";
            ClearTimer.Start();
            timeLeftClear = 3;
        }

        private void copyFineCode_Click(object sender, EventArgs e)
        {
            foreach (string s in MovingViolationListBox.CheckedItems)
            {
                charges += s + ", ";
            }
            foreach (string s in MisdemeanorsListBox.CheckedItems)
            {
                charges += s + ", ";
            }
            foreach (string s in FeloniesListBox.CheckedItems)
            {
                charges += s + ", ";
            }

            if (userID == 0 || userIDBox.Text == "")
            {
                MessageBox.Show("Please Enter The User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }      
            else if (charges.Length < 1)
            {
                MessageBox.Show("No Charges Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if (fineSum == 0)
            {
                MessageBox.Show("Fine Cannot Be $0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if (timeSum == 0)
            {
                System.Windows.Forms.Clipboard.SetText("/fine " + userID + " " + fineSum + " " + charges.TrimEnd(',', ' ') + " || ISSUED: " + DateTime.Now.ToString("M/d/yyyy"));
                copyFineCode.BackColor = Color.LimeGreen;
                copyFineCode.Text = "Copied Fine Code!";
                CopyButtonTimer.Start();
                timeLeft = 3;
                charges = " ";
            } else
            {
                System.Windows.Forms.Clipboard.SetText("/fine " + userID + " " + fineSum + " " + charges.TrimEnd(',', ' ') + " || Tasks: " + timeSum + " || ISSUED: " + DateTime.Now.ToString("M/d/yyyy"));
                copyFineCode.BackColor = Color.LimeGreen;
                copyFineCode.Text = "Copied Fine Code!";
                CopyButtonTimer.Start();
                timeLeft = 3;
                charges = " ";
            }
            
        }

        private void userIDBox_ValueChanged(object sender, EventArgs e)
        {  
            userID = Convert.ToInt32(userIDBox.Value);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by: P_O_G#2222\n\nSpecial Thanks:\n\nC# Support: AdmSnyder#8493\n\n_________________________________\n\nwww.thewackpackrp.com\nhttps://github.com/sircam191", "-WackPack Fine Calc V5-", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void MisdemeanorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MisdemeanorsListBox.CheckOnClick = true;
            fineSum = 0;
            timeSum = 0;
            chargesBox.Items.Clear();

            foreach (string s in MisdemeanorsListBox.CheckedItems)
            {
               
                var offense = Offenses.MisdemeanorByName[s];

                var offenseInfo = Offenses.MisdemeanorsData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }
   
            foreach (string s in MovingViolationListBox.CheckedItems)
            {

                var offense = Offenses.ViolationByName[s];

                var offenseInfo = Offenses.MovingViolationData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }

            foreach (string s in FeloniesListBox.CheckedItems)
            {

                var offense = Offenses.FeloniesByName[s];

                var offenseInfo = Offenses.FeloniesData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }

            if (fineSum > Form1.maxFine)
            {
                fineSum = Form1.maxFine;
                FineTB.Value = fineSum;
            }
            if (timeSum > Form1.maxTasks)
            {
                timeSum = Form1.maxTasks;
                timeSum = Form1.maxTasks;
                CServiceTB.Value = timeSum;
            }


            FineTB.Value = fineSum;
            CServiceTB.Value = timeSum;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
          
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
           
            label3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FDCA2F");
            label4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FDCA2F");
            label5.BackColor = System.Drawing.ColorTranslator.FromHtml("#FDCA2F");
            label6.BackColor = System.Drawing.ColorTranslator.FromHtml("#FDCA2F");

            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;

            userIDBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdd96d");
            FineTB.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdd96d");
            
            CServiceTB.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdd96d");

            chargesBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#042349");
            chargesBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");


            this.groupBox1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");
            this.groupBox2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");
            this.groupBox3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");

            this.MovingViolationListBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#042349");
            this.FeloniesListBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#042349");
            this.MisdemeanorsListBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#042349");

            this.MovingViolationListBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");
            this.FeloniesListBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");
            this.MisdemeanorsListBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");

            


            SecretLabel.BackColor = Color.Transparent;

          

            MovingViolationListBox.BeginUpdate();
            FeloniesListBox.BeginUpdate();
            MisdemeanorsListBox.BeginUpdate();

            foreach (var x in Offenses.MovingViolationData)
            {
                MovingViolationListBox.Items.Add(x.Value.Text);
            }



            foreach (var x in Offenses.MisdemeanorsData)
            {
                MisdemeanorsListBox.Items.Add(x.Value.Text);
            }



            foreach (var x in Offenses.FeloniesData)
            {
                FeloniesListBox.Items.Add(x.Value.Text);
            }

            


            chargesBox.Items.Add("No Charges Selected");
            FineTB.Value = 0;
            CServiceTB.Value = timeSum;

            MovingViolationListBox.EndUpdate();
            MisdemeanorsListBox.EndUpdate();
            FeloniesListBox.EndUpdate();
            LoadTimer.Start();
            timeLeftLoad = 1;
            
        }

        private void CopyButtonTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                CopyButtonTimer.Stop();
                copyFineCode.BackColor = Color.DarkGray;
                copyFineCode.Text = "Copy Fine Code";
            }

        }

        private void ClearTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeftClear > 0)
            {
                timeLeftClear = timeLeftClear - 1;
            }
            else
            {
                ClearTimer.Stop();
                clearCalcButton.BackColor = Color.DarkGray;
                clearCalcButton.Text = "Clear Calc";
            }

        }

        private void FeloniesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           FeloniesListBox.CheckOnClick = true;
            fineSum = 0;
            timeSum = 0;
            chargesBox.Items.Clear();

            foreach (string s in MovingViolationListBox.CheckedItems)
            {

                var offense = Offenses.ViolationByName[s];

                var offenseInfo = Offenses.MovingViolationData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }

            foreach (string s in MisdemeanorsListBox.CheckedItems)
            {

                var offense = Offenses.MisdemeanorByName[s];

                var offenseInfo = Offenses.MisdemeanorsData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }

            foreach (string s in FeloniesListBox.CheckedItems)
            {

                var offense = Offenses.FeloniesByName[s];

                var offenseInfo = Offenses.FeloniesData[offense];
                chargesBox.Items.Add($"{offenseInfo.Text} - ${offenseInfo.Fine}{(offenseInfo.DaysInJail > 0 ? $" - {offenseInfo.DaysInJail * Form1.cServiceMultiplyer} Tasks" : "")}");

                fineSum += offenseInfo.Fine;
                timeSum += offenseInfo.DaysInJail * Form1.cServiceMultiplyer;
            }


            if (fineSum > Form1.maxFine)
            {
                fineSum = Form1.maxFine;
                FineTB.Value = fineSum;
            }
            if (timeSum > Form1.maxTasks)
            {
                timeSum = Form1.maxTasks;
                timeSum = Form1.maxTasks;
                CServiceTB.Value = timeSum;
            }


            FineTB.Value = fineSum;
            CServiceTB.Value = timeSum;

        }


        private void FineTB_ValueChanged(object sender, EventArgs e)
        {
            fineSum = Decimal.ToInt32(FineTB.Value);
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeftLoad > 0)
            {
                timeLeftLoad -= 1;
            }
            else
            {
                LoadTimer.Stop();
                this.Opacity = 100;
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Open Image file";
                fileOpen.Filter = "png Files (*.png)| *.png";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                   
                    this.BackgroundImage = Image.FromFile(fileOpen.FileName);
                }
                
            }
        }

        private void SecretLabel_Click(object sender, EventArgs e)
        {
            
            this.BackgroundImage = Properties.Resources.trippy;
            MessageBox.Show("Wow you found a secret button!\n\nWell done give yourself a pat on the back.\n\n Okay time to get back to work trooper!", "Secret Button", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CServiceTB_ValueChanged(object sender, EventArgs e)
        {
            timeSum = Convert.ToInt32(CServiceTB.Value);
        }
    }
}

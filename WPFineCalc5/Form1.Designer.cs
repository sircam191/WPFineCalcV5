namespace WPFineCalc5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MovingViolationListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MisdemeanorsListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FeloniesListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.copyFineCode = new System.Windows.Forms.Button();
            this.clearCalcButton = new System.Windows.Forms.Button();
            this.chargesBox = new System.Windows.Forms.ListBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.CopyButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearTimer = new System.Windows.Forms.Timer(this.components);
            this.FineTB = new System.Windows.Forms.NumericUpDown();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SecretLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CServiceTB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.userIDBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FineTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CServiceTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // userIDBox
            // 
            this.userIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIDBox.Location = new System.Drawing.Point(101, 11);
            this.userIDBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(52, 20);
            this.userIDBox.TabIndex = 1;
            this.userIDBox.ValueChanged += new System.EventHandler(this.userIDBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(765, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Charges:";
            // 
            // MovingViolationListBox
            // 
            this.MovingViolationListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovingViolationListBox.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovingViolationListBox.FormattingEnabled = true;
            this.MovingViolationListBox.Location = new System.Drawing.Point(6, 17);
            this.MovingViolationListBox.Name = "MovingViolationListBox";
            this.MovingViolationListBox.Size = new System.Drawing.Size(198, 376);
            this.MovingViolationListBox.TabIndex = 2;
            this.MovingViolationListBox.Tag = "500";
            this.MovingViolationListBox.SelectedIndexChanged += new System.EventHandler(this.MovingViolationListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MovingViolationListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 402);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOVING VIOLATIONS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MisdemeanorsListBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(222, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 402);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MISDEMEANORS";
            // 
            // MisdemeanorsListBox
            // 
            this.MisdemeanorsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MisdemeanorsListBox.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MisdemeanorsListBox.FormattingEnabled = true;
            this.MisdemeanorsListBox.Location = new System.Drawing.Point(6, 17);
            this.MisdemeanorsListBox.Name = "MisdemeanorsListBox";
            this.MisdemeanorsListBox.Size = new System.Drawing.Size(191, 376);
            this.MisdemeanorsListBox.TabIndex = 3;
            this.MisdemeanorsListBox.SelectedIndexChanged += new System.EventHandler(this.MisdemeanorsListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FeloniesListBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(431, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 402);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FELONIES";
            // 
            // FeloniesListBox
            // 
            this.FeloniesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FeloniesListBox.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeloniesListBox.FormattingEnabled = true;
            this.FeloniesListBox.Location = new System.Drawing.Point(7, 17);
            this.FeloniesListBox.Name = "FeloniesListBox";
            this.FeloniesListBox.Size = new System.Drawing.Size(206, 376);
            this.FeloniesListBox.TabIndex = 4;
            this.FeloniesListBox.SelectedIndexChanged += new System.EventHandler(this.FeloniesListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.6F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(667, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Community Service Tasks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.65F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(776, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fine:";
            // 
            // copyFineCode
            // 
            this.copyFineCode.BackColor = System.Drawing.Color.DarkGray;
            this.copyFineCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyFineCode.Location = new System.Drawing.Point(795, 419);
            this.copyFineCode.Name = "copyFineCode";
            this.copyFineCode.Size = new System.Drawing.Size(135, 23);
            this.copyFineCode.TabIndex = 6;
            this.copyFineCode.Text = "Copy Fine Code";
            this.copyFineCode.UseVisualStyleBackColor = false;
            this.copyFineCode.Click += new System.EventHandler(this.copyFineCode_Click);
            // 
            // clearCalcButton
            // 
            this.clearCalcButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCalcButton.Location = new System.Drawing.Point(670, 419);
            this.clearCalcButton.Name = "clearCalcButton";
            this.clearCalcButton.Size = new System.Drawing.Size(119, 23);
            this.clearCalcButton.TabIndex = 7;
            this.clearCalcButton.Text = "Clear Calc";
            this.clearCalcButton.UseVisualStyleBackColor = false;
            this.clearCalcButton.Click += new System.EventHandler(this.clearCalcButton_Click);
            // 
            // chargesBox
            // 
            this.chargesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chargesBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargesBox.FormattingEnabled = true;
            this.chargesBox.ItemHeight = 15;
            this.chargesBox.Location = new System.Drawing.Point(663, 46);
            this.chargesBox.Name = "chargesBox";
            this.chargesBox.Size = new System.Drawing.Size(274, 302);
            this.chargesBox.TabIndex = 17;
            this.chargesBox.TabStop = false;
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.HelpButton.Location = new System.Drawing.Point(888, 8);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(28, 26);
            this.HelpButton.TabIndex = 20;
            this.HelpButton.TabStop = false;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // CopyButtonTimer
            // 
            this.CopyButtonTimer.Tick += new System.EventHandler(this.CopyButtonTimer_Tick);
            // 
            // ClearTimer
            // 
            this.ClearTimer.Tick += new System.EventHandler(this.ClearTimer_Tick);
            // 
            // FineTB
            // 
            this.FineTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FineTB.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.FineTB.Location = new System.Drawing.Point(824, 363);
            this.FineTB.Maximum = new decimal(new int[] {
            75000,
            0,
            0,
            0});
            this.FineTB.Name = "FineTB";
            this.FineTB.ReadOnly = true;
            this.FineTB.Size = new System.Drawing.Size(106, 20);
            this.FineTB.TabIndex = 5;
            this.FineTB.ValueChanged += new System.EventHandler(this.FineTB_ValueChanged);
            // 
            // LoadTimer
            // 
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label5.Location = new System.Drawing.Point(812, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "$";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Tomato;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.Location = new System.Drawing.Point(915, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 26);
            this.CloseButton.TabIndex = 25;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SecretLabel
            // 
            this.SecretLabel.AutoSize = true;
            this.SecretLabel.Location = new System.Drawing.Point(752, 17);
            this.SecretLabel.Name = "SecretLabel";
            this.SecretLabel.Size = new System.Drawing.Size(10, 13);
            this.SecretLabel.TabIndex = 27;
            this.SecretLabel.Text = " ";
            this.SecretLabel.Click += new System.EventHandler(this.SecretLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WPFineCalc5.Properties.Resources.yellowSquare;
            this.pictureBox1.Location = new System.Drawing.Point(663, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(274, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(375, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "WP SASP Fine Calculator";
            // 
            // CServiceTB
            // 
            this.CServiceTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CServiceTB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CServiceTB.Location = new System.Drawing.Point(824, 392);
            this.CServiceTB.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CServiceTB.Name = "CServiceTB";
            this.CServiceTB.ReadOnly = true;
            this.CServiceTB.Size = new System.Drawing.Size(106, 20);
            this.CServiceTB.TabIndex = 30;
            this.CServiceTB.ValueChanged += new System.EventHandler(this.CServiceTB_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WPFineCalc5.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.CServiceTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FineTB);
            this.Controls.Add(this.SecretLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.chargesBox);
            this.Controls.Add(this.clearCalcButton);
            this.Controls.Add(this.copyFineCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaCKPaCK Fine Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.userIDBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FineTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CServiceTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown userIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox MovingViolationListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox MisdemeanorsListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox FeloniesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button copyFineCode;
        private System.Windows.Forms.Button clearCalcButton;
        private System.Windows.Forms.ListBox chargesBox;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Timer CopyButtonTimer;
        private System.Windows.Forms.Timer ClearTimer;
        private System.Windows.Forms.NumericUpDown FineTB;
        private System.Windows.Forms.Timer LoadTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label SecretLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CServiceTB;
    }
}


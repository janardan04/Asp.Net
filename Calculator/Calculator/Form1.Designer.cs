namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOutput = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(-2, -8);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(464, 93);
            txtOutput.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 255);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button20, 3, 4);
            tableLayoutPanel1.Controls.Add(button19, 2, 4);
            tableLayoutPanel1.Controls.Add(button18, 1, 4);
            tableLayoutPanel1.Controls.Add(button17, 0, 4);
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Controls.Add(button15, 2, 3);
            tableLayoutPanel1.Controls.Add(button14, 1, 3);
            tableLayoutPanel1.Controls.Add(button13, 0, 3);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button9, 0, 2);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI", 13.8F);
            tableLayoutPanel1.Location = new Point(2, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(460, 432);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button20
            // 
            button20.Dock = DockStyle.Fill;
            button20.Location = new Point(348, 347);
            button20.Name = "button20";
            button20.Size = new Size(109, 82);
            button20.TabIndex = 19;
            button20.Text = "=";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Equals_click;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Fill;
            button19.Location = new Point(233, 347);
            button19.Name = "button19";
            button19.Size = new Size(109, 82);
            button19.TabIndex = 18;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Dock = DockStyle.Fill;
            button18.Location = new Point(118, 347);
            button18.Name = "button18";
            button18.Size = new Size(109, 82);
            button18.TabIndex = 17;
            button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(3, 347);
            button17.Name = "button17";
            button17.Size = new Size(109, 82);
            button17.TabIndex = 16;
            button17.Text = "0";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(255, 224, 192);
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(348, 261);
            button16.Name = "button16";
            button16.Size = new Size(109, 80);
            button16.TabIndex = 15;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button_click;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(233, 261);
            button15.Name = "button15";
            button15.Size = new Size(109, 80);
            button15.TabIndex = 14;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_click;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(118, 261);
            button14.Name = "button14";
            button14.Size = new Size(109, 80);
            button14.TabIndex = 13;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(3, 261);
            button13.Name = "button13";
            button13.Size = new Size(109, 80);
            button13.TabIndex = 12;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(255, 224, 192);
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(348, 175);
            button12.Name = "button12";
            button12.Size = new Size(109, 80);
            button12.TabIndex = 11;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button_click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(233, 175);
            button11.Name = "button11";
            button11.Size = new Size(109, 80);
            button11.TabIndex = 10;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(118, 175);
            button10.Name = "button10";
            button10.Size = new Size(109, 80);
            button10.TabIndex = 9;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(3, 175);
            button9.Name = "button9";
            button9.Size = new Size(109, 80);
            button9.TabIndex = 8;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 224, 192);
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(348, 89);
            button8.Name = "button8";
            button8.Size = new Size(109, 80);
            button8.TabIndex = 7;
            button8.Text = "*";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(233, 89);
            button7.Name = "button7";
            button7.Size = new Size(109, 80);
            button7.TabIndex = 6;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(118, 89);
            button6.Name = "button6";
            button6.Size = new Size(109, 80);
            button6.TabIndex = 5;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 89);
            button5.Name = "button5";
            button5.Size = new Size(109, 80);
            button5.TabIndex = 4;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(348, 3);
            button4.Name = "button4";
            button4.Size = new Size(109, 80);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(233, 3);
            button3.Name = "button3";
            button3.Size = new Size(109, 80);
            button3.TabIndex = 2;
            button3.Text = "%";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(118, 3);
            button2.Name = "button2";
            button2.Size = new Size(109, 80);
            button2.TabIndex = 1;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_clearEntery_click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(109, 80);
            button1.TabIndex = 0;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Clear_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(462, 512);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Calculator_Janardan";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtOutput;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button20;
        private Button button19;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button18;
    }
}

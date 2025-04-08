namespace Assign4_WindowForm_Tshirt
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
            input = new TextBox();
            s = new RadioButton();
            m = new RadioButton();
            l = new RadioButton();
            code = new TextBox();
            p = new Label();
            cal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // input
            // 
            input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input.Font = new Font("Microsoft Sans Serif", 13.8F);
            input.Location = new Point(125, 11);
            input.Margin = new Padding(2, 3, 2, 3);
            input.Multiline = true;
            input.Name = "input";
            input.PlaceholderText = "Enter the no of Tshirt";
            input.Size = new Size(514, 76);
            input.TabIndex = 0;
            input.TextChanged += input_TextChanged;
            // 
            // s
            // 
            s.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            s.AutoSize = true;
            s.Font = new Font("Microsoft Sans Serif", 13.8F);
            s.Location = new Point(125, 93);
            s.Margin = new Padding(2, 3, 2, 3);
            s.Name = "s";
            s.Size = new Size(95, 33);
            s.TabIndex = 1;
            s.TabStop = true;
            s.Text = "Small";
            s.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            m.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            m.AutoSize = true;
            m.Font = new Font("Microsoft Sans Serif", 13.8F);
            m.Location = new Point(236, 93);
            m.Margin = new Padding(2, 3, 2, 3);
            m.Name = "m";
            m.Size = new Size(121, 33);
            m.TabIndex = 2;
            m.TabStop = true;
            m.Text = "Medium";
            m.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            l.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            l.AutoSize = true;
            l.Font = new Font("Microsoft Sans Serif", 13.8F);
            l.Location = new Point(375, 93);
            l.Margin = new Padding(2, 3, 2, 3);
            l.Name = "l";
            l.Size = new Size(96, 33);
            l.TabIndex = 3;
            l.TabStop = true;
            l.Text = "Large";
            l.UseVisualStyleBackColor = true;
            l.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // code
            // 
            code.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            code.Font = new Font("Microsoft Sans Serif", 13.8F);
            code.Location = new Point(169, 153);
            code.Margin = new Padding(2, 3, 2, 3);
            code.Name = "code";
            code.PlaceholderText = "Refer code";
            code.Size = new Size(353, 34);
            code.TabIndex = 4;
            code.TextChanged += code_TextChanged;
            // 
            // p
            // 
            p.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            p.AutoSize = true;
            p.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p.Location = new Point(210, 272);
            p.Margin = new Padding(2, 0, 2, 0);
            p.Name = "p";
            p.Size = new Size(0, 32);
            p.TabIndex = 5;
            // 
            // cal
            // 
            cal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cal.Font = new Font("Microsoft Sans Serif", 13.8F);
            cal.Location = new Point(169, 202);
            cal.Margin = new Padding(2, 3, 2, 3);
            cal.Name = "cal";
            cal.Size = new Size(121, 48);
            cal.TabIndex = 6;
            cal.Text = "calculate";
            cal.UseVisualStyleBackColor = true;
            cal.Click += cal_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.Location = new Point(-5, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 29);
            label1.TabIndex = 7;
            label1.Text = "Quantity";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(60, 29);
            label2.TabIndex = 8;
            label2.Text = "Size";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(-5, 153);
            label3.Name = "label3";
            label3.Size = new Size(137, 29);
            label3.TabIndex = 9;
            label3.Text = "Refer Code";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.Location = new Point(109, 272);
            label4.Name = "label4";
            label4.Size = new Size(81, 29);
            label4.TabIndex = 10;
            label4.Text = "Price :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(640, 360);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cal);
            Controls.Add(p);
            Controls.Add(code);
            Controls.Add(l);
            Controls.Add(m);
            Controls.Add(s);
            Controls.Add(input);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Tshirt Price Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private RadioButton s;
        private RadioButton m;
        private RadioButton l;
        private TextBox code;
        private Label p;
        private Button cal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

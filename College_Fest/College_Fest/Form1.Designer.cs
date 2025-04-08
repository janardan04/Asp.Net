namespace College_Fest
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
            people = new TextBox();
            button1 = new Button();
            listbox = new ListBox();
            SuspendLayout();
            // 
            // people
            // 
            people.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            people.Location = new Point(-1, 0);
            people.Margin = new Padding(5);
            people.Multiline = true;
            people.Name = "people";
            people.PlaceholderText = "Enter The Number Of Peoples";
            people.Size = new Size(608, 95);
            people.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Location = new Point(-1, 94);
            button1.Name = "button1";
            button1.Size = new Size(608, 45);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listbox
            // 
            listbox.AccessibleName = "listBox";
            listbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listbox.ForeColor = Color.DeepPink;
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 31;
            listbox.Location = new Point(-1, 137);
            listbox.Margin = new Padding(2, 3, 2, 3);
            listbox.Name = "listbox";
            listbox.Size = new Size(608, 221);
            listbox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(607, 346);
            Controls.Add(listbox);
            Controls.Add(button1);
            Controls.Add(people);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "College Fest";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox people;
        private Button button1;
        private ListBox listbox;
    }
}

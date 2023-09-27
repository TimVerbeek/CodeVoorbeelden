namespace CovadisBackendApp
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
            listBox1 = new ListBox();
            label1 = new Label();
            naam = new Label();
            dailynaam = new TextBox();
            datumpicker = new DateTimePicker();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            Dailysnack = new Label();
            snack = new Label();
            label3 = new Label();
            aantal = new Label();
            button2 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Orange;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(1062, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(318, 464);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(1133, 30);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 6;
            label1.Text = "Bestellingen  van de dag";
            label1.Click += label1_Click;
            // 
            // naam
            // 
            naam.AutoSize = true;
            naam.Location = new Point(895, 81);
            naam.Name = "naam";
            naam.Size = new Size(0, 20);
            naam.TabIndex = 10;
            naam.Click += naam_Click;
            // 
            // dailynaam
            // 
            dailynaam.Location = new Point(14, 97);
            dailynaam.Name = "dailynaam";
            dailynaam.Size = new Size(180, 27);
            dailynaam.TabIndex = 14;
            dailynaam.TextChanged += dailynaam_TextChanged;
            // 
            // datumpicker
            // 
            datumpicker.Location = new Point(14, 164);
            datumpicker.Name = "datumpicker";
            datumpicker.Size = new Size(180, 27);
            datumpicker.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(14, 271);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 18;
            button1.Text = "Maak Dailysnack";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 74);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 19;
            label4.Text = "Naam";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 20;
            label5.Text = "Datum";
            // 
            // Dailysnack
            // 
            Dailysnack.AutoSize = true;
            Dailysnack.Location = new Point(-2, 348);
            Dailysnack.Name = "Dailysnack";
            Dailysnack.Size = new Size(147, 20);
            Dailysnack.TabIndex = 21;
            Dailysnack.Text = "Dailysnack vandaag: ";
            Dailysnack.Click += Dailysnack_Click;
            // 
            // snack
            // 
            snack.AutoSize = true;
            snack.Location = new Point(-2, 378);
            snack.Name = "snack";
            snack.Size = new Size(50, 20);
            snack.TabIndex = 22;
            snack.Text = "label6";
            snack.Click += snack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 424);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 23;
            label3.Text = "Mee-eters";
            // 
            // aantal
            // 
            aantal.AutoSize = true;
            aantal.Location = new Point(2, 452);
            aantal.Name = "aantal";
            aantal.Size = new Size(50, 20);
            aantal.TabIndex = 24;
            aantal.Text = "label2";
            aantal.Click += aantal_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 11);
            button2.Name = "button2";
            button2.Size = new Size(118, 25);
            button2.TabIndex = 25;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(166, 272);
            button6.Name = "button6";
            button6.Size = new Size(148, 28);
            button6.TabIndex = 26;
            button6.Text = "Delete Dailysnack";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1392, 619);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(aantal);
            Controls.Add(label3);
            Controls.Add(snack);
            Controls.Add(Dailysnack);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(datumpicker);
            Controls.Add(dailynaam);
            Controls.Add(naam);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox listBox1;
        private Label label1;
        private Label naam;
        private Label label2;
        //private ListBox listBox2;
        private TextBox dailynaam;
        private DateTimePicker datumpicker;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label Dailysnack;
        private Label snack;
        private Label label3;
        private Label aantal;
        private Button button2;
        private Button button6;
    }
}
namespace lab4inheritance
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
            pictureBox1 = new PictureBox();
            label_name = new Label();
            button1_Load = new Button();
            pictureBox2 = new PictureBox();
            label2_name = new Label();
            button2_Load = new Button();
            button5_load = new Button();
            button3_Load = new Button();
            button4_Load = new Button();
            button6_load = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(321, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(376, 239);
            label_name.Name = "label_name";
            label_name.Size = new Size(0, 15);
            label_name.TabIndex = 1;
            label_name.Click += Name_Click;
            // 
            // button1_Load
            // 
            button1_Load.BackColor = SystemColors.ActiveBorder;
            button1_Load.ForeColor = SystemColors.ControlText;
            button1_Load.Location = new Point(376, 309);
            button1_Load.Name = "button1_Load";
            button1_Load.Size = new Size(163, 23);
            button1_Load.TabIndex = 2;
            button1_Load.Text = "Load Pokamon";
            button1_Load.UseVisualStyleBackColor = false;
            button1_Load.Click += button1_Load_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Magnezone;
            pictureBox2.Location = new Point(644, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2_name
            // 
            label2_name.AutoSize = true;
            label2_name.Location = new Point(696, 239);
            label2_name.Name = "label2_name";
            label2_name.Size = new Size(43, 15);
            label2_name.TabIndex = 4;
            label2_name.Text = "Enemy";
            // 
            // button2_Load
            // 
            button2_Load.BackColor = SystemColors.ActiveBorder;
            button2_Load.ForeColor = SystemColors.ControlText;
            button2_Load.Location = new Point(545, 309);
            button2_Load.Name = "button2_Load";
            button2_Load.Size = new Size(163, 23);
            button2_Load.TabIndex = 5;
            button2_Load.Text = "Load Pokamon";
            button2_Load.UseVisualStyleBackColor = false;
            button2_Load.Click += button2_Load_Click;
            // 
            // button5_load
            // 
            button5_load.BackColor = SystemColors.ActiveBorder;
            button5_load.ForeColor = SystemColors.ControlText;
            button5_load.Location = new Point(376, 402);
            button5_load.Name = "button5_load";
            button5_load.Size = new Size(163, 23);
            button5_load.TabIndex = 6;
            button5_load.Text = "Load Pokamon";
            button5_load.UseVisualStyleBackColor = false;
            button5_load.Click += button5_load_Click;
            // 
            // button3_Load
            // 
            button3_Load.BackColor = SystemColors.ActiveBorder;
            button3_Load.ForeColor = SystemColors.ControlText;
            button3_Load.Location = new Point(376, 354);
            button3_Load.Name = "button3_Load";
            button3_Load.Size = new Size(163, 23);
            button3_Load.TabIndex = 7;
            button3_Load.Text = "Load Pokamon";
            button3_Load.UseVisualStyleBackColor = false;
            button3_Load.Click += button3_Load_Click;
            // 
            // button4_Load
            // 
            button4_Load.BackColor = SystemColors.ActiveBorder;
            button4_Load.ForeColor = SystemColors.ControlText;
            button4_Load.Location = new Point(545, 354);
            button4_Load.Name = "button4_Load";
            button4_Load.Size = new Size(163, 23);
            button4_Load.TabIndex = 8;
            button4_Load.Text = "Load Pokamon";
            button4_Load.UseVisualStyleBackColor = false;
            button4_Load.Click += button4_Load_Click;
            // 
            // button6_load
            // 
            button6_load.BackColor = SystemColors.ActiveBorder;
            button6_load.ForeColor = SystemColors.ControlText;
            button6_load.Location = new Point(545, 402);
            button6_load.Name = "button6_load";
            button6_load.Size = new Size(163, 23);
            button6_load.TabIndex = 9;
            button6_load.Text = "Load Pokamon";
            button6_load.UseVisualStyleBackColor = false;
            button6_load.Click += button6_load_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 555);
            Controls.Add(button6_load);
            Controls.Add(button4_Load);
            Controls.Add(button3_Load);
            Controls.Add(button5_load);
            Controls.Add(button2_Load);
            Controls.Add(label2_name);
            Controls.Add(pictureBox2);
            Controls.Add(button1_Load);
            Controls.Add(label_name);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label_name;
        private Button button1_Load;
        private PictureBox pictureBox2;
        private Label label2_name;
        private Button button2_Load;
        private Button button5_load;
        private Button button3_Load;
        private Button button4_Load;
        private Button button6_load;
    }
}

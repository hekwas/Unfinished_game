namespace trivia
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            intrb_txt = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.ForeColor = SystemColors.ButtonFace;
            labelTimer.Location = new Point(0, -5);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(217, 50);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "labelTimer";
            labelTimer.Click += label1_Click;
            // 
            // intrb_txt
            // 
            intrb_txt.AutoSize = true;
            intrb_txt.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            intrb_txt.ForeColor = SystemColors.ButtonFace;
            intrb_txt.Location = new Point(0, 81);
            intrb_txt.Name = "intrb_txt";
            intrb_txt.Size = new Size(34, 50);
            intrb_txt.TabIndex = 1;
            intrb_txt.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(262, -5);
            label1.Name = "label1";
            label1.Size = new Size(544, 50);
            label1.TabIndex = 2;
            label1.Text = "Ai 5 minute sa le completezi!\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(12, 160);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 44);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Rasp1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Location = new Point(12, 210);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 44);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Rasp2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = SystemColors.ButtonFace;
            checkBox3.Location = new Point(12, 260);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(119, 44);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Rasp3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.ForeColor = SystemColors.ButtonFace;
            checkBox4.Location = new Point(12, 310);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(119, 44);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Rasp4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(566, 389);
            button1.Name = "button1";
            button1.Size = new Size(238, 63);
            button1.TabIndex = 7;
            button1.Text = "Urmatorul";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(intrb_txt);
            Controls.Add(labelTimer);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTimer;
        private Label intrb_txt;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
    }
}
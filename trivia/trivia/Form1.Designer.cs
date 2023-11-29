namespace trivia
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
            label1 = new Label();
            txtbx_user = new TextBox();
            txtbx_password = new TextBox();
            Login = new Button();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 45);
            label1.Name = "label1";
            label1.Size = new Size(502, 86);
            label1.TabIndex = 0;
            label1.Text = "Guessing Game";
            label1.Click += label1_Click;
            // 
            // txtbx_user
            // 
            txtbx_user.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_user.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbx_user.Location = new Point(143, 156);
            txtbx_user.Name = "txtbx_user";
            txtbx_user.Size = new Size(383, 40);
            txtbx_user.TabIndex = 1;
            txtbx_user.TextChanged += txtbx_user_TextChanged;
            // 
            // txtbx_password
            // 
            txtbx_password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_password.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbx_password.Location = new Point(143, 234);
            txtbx_password.Name = "txtbx_password";
            txtbx_password.Size = new Size(383, 40);
            txtbx_password.TabIndex = 2;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login.BackColor = SystemColors.ControlDarkDark;
            Login.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(143, 316);
            Login.Name = "Login";
            Login.Size = new Size(383, 64);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(143, 210);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(143, 132);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(143, 198);
            button1.Name = "button1";
            button1.Size = new Size(383, 76);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.DimGray;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(143, 304);
            button2.Name = "button2";
            button2.Size = new Size(383, 76);
            button2.TabIndex = 7;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(699, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(txtbx_password);
            Controls.Add(txtbx_user);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Trivia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbx_user;
        private TextBox txtbx_password;
        private Button Login;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
namespace LibraryApp.View
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.authButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.designPictureBox = new System.Windows.Forms.PictureBox();
            this.design2PictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.designLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.designPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.design2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.FlatAppearance.BorderSize = 0;
            this.authButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authButton.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.ForeColor = System.Drawing.Color.White;
            this.authButton.Location = new System.Drawing.Point(106, 371);
            this.authButton.Margin = new System.Windows.Forms.Padding(6);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(180, 65);
            this.authButton.TabIndex = 0;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // regButton
            // 
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.Color.White;
            this.regButton.Location = new System.Drawing.Point(106, 448);
            this.regButton.Margin = new System.Windows.Forms.Padding(6);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(180, 65);
            this.regButton.TabIndex = 1;
            this.regButton.Text = "Регистрация";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(42, 179);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(315, 29);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(42, 262);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(315, 29);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordCheckBox.Location = new System.Drawing.Point(42, 303);
            this.passwordCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(145, 21);
            this.passwordCheckBox.TabIndex = 4;
            this.passwordCheckBox.Text = "показать пароль";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // designPictureBox
            // 
            this.designPictureBox.Location = new System.Drawing.Point(-6, 30);
            this.designPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.designPictureBox.Name = "designPictureBox";
            this.designPictureBox.Size = new System.Drawing.Size(748, 54);
            this.designPictureBox.TabIndex = 7;
            this.designPictureBox.TabStop = false;
            // 
            // design2PictureBox
            // 
            this.design2PictureBox.Location = new System.Drawing.Point(-6, 0);
            this.design2PictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.design2PictureBox.Name = "design2PictureBox";
            this.design2PictureBox.Size = new System.Drawing.Size(748, 31);
            this.design2PictureBox.TabIndex = 8;
            this.design2PictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(351, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 24);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // designLabel
            // 
            this.designLabel.AutoSize = true;
            this.designLabel.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.designLabel.ForeColor = System.Drawing.Color.White;
            this.designLabel.Location = new System.Drawing.Point(6, 41);
            this.designLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(210, 35);
            this.designLabel.TabIndex = 10;
            this.designLabel.Text = "Авторизация";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 562);
            this.Controls.Add(this.designLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.design2PictureBox);
            this.Controls.Add(this.designPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.authButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(400, 562);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.designPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.design2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox designPictureBox;
        private System.Windows.Forms.PictureBox design2PictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label designLabel;
    }
}
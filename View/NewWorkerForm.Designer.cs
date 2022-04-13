
namespace LibraryApp.View
{
    partial class NewWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWorkerForm));
            this.savelButton = new MaterialSkin.Controls.MaterialButton();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.surnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.expYearsTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.addressTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // savelButton
            // 
            this.savelButton.AutoSize = false;
            this.savelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.savelButton.Depth = 0;
            this.savelButton.HighEmphasis = true;
            this.savelButton.Icon = null;
            this.savelButton.Location = new System.Drawing.Point(165, 453);
            this.savelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.savelButton.Name = "savelButton";
            this.savelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.savelButton.Size = new System.Drawing.Size(75, 36);
            this.savelButton.TabIndex = 0;
            this.savelButton.Text = "Save";
            this.savelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.savelButton.UseAccentColor = false;
            this.savelButton.UseVisualStyleBackColor = true;
            this.savelButton.Click += new System.EventHandler(this.savelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(21, 124);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(357, 50);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.AnimateReadOnly = false;
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.Depth = 0;
            this.surnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.surnameTextBox.LeadingIcon = null;
            this.surnameTextBox.Location = new System.Drawing.Point(21, 207);
            this.surnameTextBox.MaxLength = 50;
            this.surnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.surnameTextBox.Multiline = false;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(357, 50);
            this.surnameTextBox.TabIndex = 2;
            this.surnameTextBox.Text = "";
            this.surnameTextBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 185);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Фамилия";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Имя";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 267);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Стаж";
            // 
            // expYearsTextBox
            // 
            this.expYearsTextBox.AnimateReadOnly = false;
            this.expYearsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expYearsTextBox.Depth = 0;
            this.expYearsTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.expYearsTextBox.LeadingIcon = null;
            this.expYearsTextBox.Location = new System.Drawing.Point(21, 289);
            this.expYearsTextBox.MaxLength = 50;
            this.expYearsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.expYearsTextBox.Multiline = false;
            this.expYearsTextBox.Name = "expYearsTextBox";
            this.expYearsTextBox.Size = new System.Drawing.Size(357, 50);
            this.expYearsTextBox.TabIndex = 6;
            this.expYearsTextBox.Text = "";
            this.expYearsTextBox.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 352);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Адрес";
            // 
            // addressTextBox
            // 
            this.addressTextBox.AnimateReadOnly = false;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Depth = 0;
            this.addressTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressTextBox.LeadingIcon = null;
            this.addressTextBox.Location = new System.Drawing.Point(21, 374);
            this.addressTextBox.MaxLength = 50;
            this.addressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTextBox.Multiline = false;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(357, 50);
            this.addressTextBox.TabIndex = 8;
            this.addressTextBox.Text = "";
            this.addressTextBox.TrailingIcon = null;
            // 
            // NewWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 509);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.expYearsTextBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.savelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(408, 509);
            this.MinimumSize = new System.Drawing.Size(408, 509);
            this.Name = "NewWorkerForm";
            this.Text = "Новый сотрудник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton savelButton;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialTextBox surnameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox expYearsTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox addressTextBox;
    }
}
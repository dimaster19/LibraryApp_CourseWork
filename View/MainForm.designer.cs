
namespace LibraryApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.showReaders = new MaterialSkin.Controls.MaterialButton();
            this.showWorkers = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // showReaders
            // 
            this.showReaders.AutoSize = false;
            this.showReaders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showReaders.BackColor = System.Drawing.SystemColors.Control;
            this.showReaders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.showReaders.Depth = 0;
            this.showReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showReaders.HighEmphasis = true;
            this.showReaders.Icon = null;
            this.showReaders.Location = new System.Drawing.Point(121, 145);
            this.showReaders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showReaders.MouseState = MaterialSkin.MouseState.HOVER;
            this.showReaders.Name = "showReaders";
            this.showReaders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showReaders.Size = new System.Drawing.Size(131, 36);
            this.showReaders.TabIndex = 0;
            this.showReaders.Text = "Читатели";
            this.showReaders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showReaders.UseAccentColor = false;
            this.showReaders.UseVisualStyleBackColor = false;
            this.showReaders.Click += new System.EventHandler(this.showReaders_Click);
            // 
            // showWorkers
            // 
            this.showWorkers.AutoSize = false;
            this.showWorkers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showWorkers.BackColor = System.Drawing.SystemColors.Control;
            this.showWorkers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.showWorkers.Depth = 0;
            this.showWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showWorkers.HighEmphasis = true;
            this.showWorkers.Icon = null;
            this.showWorkers.Location = new System.Drawing.Point(121, 97);
            this.showWorkers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showWorkers.MouseState = MaterialSkin.MouseState.HOVER;
            this.showWorkers.Name = "showWorkers";
            this.showWorkers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showWorkers.Size = new System.Drawing.Size(131, 36);
            this.showWorkers.TabIndex = 1;
            this.showWorkers.Text = "Сотрудники";
            this.showWorkers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showWorkers.UseAccentColor = false;
            this.showWorkers.UseVisualStyleBackColor = false;
            this.showWorkers.Click += new System.EventHandler(this.showWorkers_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.Control;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(121, 193);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(131, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Книги";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 258);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.showWorkers);
            this.Controls.Add(this.showReaders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(385, 258);
            this.MinimumSize = new System.Drawing.Size(385, 258);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryApp";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton showReaders;
        private MaterialSkin.Controls.MaterialButton showWorkers;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
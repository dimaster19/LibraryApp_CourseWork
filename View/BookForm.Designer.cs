
namespace LibraryApp.View
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.bookListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editButton1 = new MaterialSkin.Controls.MaterialButton();
            this.removeButton2 = new MaterialSkin.Controls.MaterialButton();
            this.addButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.AutoSizeTable = false;
            this.bookListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.bookListView.Depth = 0;
            this.bookListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookListView.FullRowSelect = true;
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(6, 76);
            this.bookListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.bookListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookListView.MouseState = MaterialSkin.MouseState.OUT;
            this.bookListView.Name = "bookListView";
            this.bookListView.OwnerDraw = true;
            this.bookListView.Size = new System.Drawing.Size(788, 321);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            this.bookListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.bookListView_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Автор";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Год";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Жанр";
            this.columnHeader5.Width = 200;
            // 
            // editButton1
            // 
            this.editButton1.AutoSize = false;
            this.editButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editButton1.Depth = 0;
            this.editButton1.HighEmphasis = true;
            this.editButton1.Icon = null;
            this.editButton1.Location = new System.Drawing.Point(444, 405);
            this.editButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton1.Name = "editButton1";
            this.editButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton1.Size = new System.Drawing.Size(111, 36);
            this.editButton1.TabIndex = 6;
            this.editButton1.Text = "Изменить";
            this.editButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editButton1.UseAccentColor = false;
            this.editButton1.UseVisualStyleBackColor = true;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // removeButton2
            // 
            this.removeButton2.AutoSize = false;
            this.removeButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.removeButton2.Depth = 0;
            this.removeButton2.HighEmphasis = true;
            this.removeButton2.Icon = null;
            this.removeButton2.Location = new System.Drawing.Point(682, 405);
            this.removeButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeButton2.Name = "removeButton2";
            this.removeButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeButton2.Size = new System.Drawing.Size(111, 36);
            this.removeButton2.TabIndex = 5;
            this.removeButton2.Text = "Удалить";
            this.removeButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeButton2.UseAccentColor = false;
            this.removeButton2.UseVisualStyleBackColor = true;
            this.removeButton2.Click += new System.EventHandler(this.removeButton2_Click);
            // 
            // addButton1
            // 
            this.addButton1.AutoSize = false;
            this.addButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton1.Depth = 0;
            this.addButton1.HighEmphasis = true;
            this.addButton1.Icon = null;
            this.addButton1.Location = new System.Drawing.Point(563, 405);
            this.addButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton1.Name = "addButton1";
            this.addButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton1.Size = new System.Drawing.Size(111, 36);
            this.addButton1.TabIndex = 4;
            this.addButton1.Text = "Добавить";
            this.addButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton1.UseAccentColor = false;
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton1);
            this.Controls.Add(this.removeButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.bookListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView bookListView;
        private MaterialSkin.Controls.MaterialButton editButton1;
        private MaterialSkin.Controls.MaterialButton removeButton2;
        private MaterialSkin.Controls.MaterialButton addButton1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
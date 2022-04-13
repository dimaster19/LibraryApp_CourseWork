
namespace LibraryApp.View
{
    partial class ReaderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.readerListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton1 = new MaterialSkin.Controls.MaterialButton();
            this.removeButton2 = new MaterialSkin.Controls.MaterialButton();
            this.editButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // readerListView
            // 
            this.readerListView.AutoSizeTable = false;
            this.readerListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readerListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.readerListView.Depth = 0;
            this.readerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readerListView.FullRowSelect = true;
            this.readerListView.HideSelection = false;
            this.readerListView.Location = new System.Drawing.Point(6, 80);
            this.readerListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.readerListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.readerListView.MouseState = MaterialSkin.MouseState.OUT;
            this.readerListView.Name = "readerListView";
            this.readerListView.OwnerDraw = true;
            this.readerListView.Size = new System.Drawing.Size(788, 319);
            this.readerListView.TabIndex = 0;
            this.readerListView.UseCompatibleStateImageBehavior = false;
            this.readerListView.View = System.Windows.Forms.View.Details;
            this.readerListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.readerListView_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Книга";
            this.columnHeader4.Width = 320;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            this.columnHeader5.Width = 250;
            // 
            // addButton1
            // 
            this.addButton1.AutoSize = false;
            this.addButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton1.Depth = 0;
            this.addButton1.HighEmphasis = true;
            this.addButton1.Icon = null;
            this.addButton1.Location = new System.Drawing.Point(508, 408);
            this.addButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton1.Name = "addButton1";
            this.addButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton1.Size = new System.Drawing.Size(139, 36);
            this.addButton1.TabIndex = 1;
            this.addButton1.Text = "Добавить";
            this.addButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton1.UseAccentColor = false;
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // removeButton2
            // 
            this.removeButton2.AutoSize = false;
            this.removeButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.removeButton2.Depth = 0;
            this.removeButton2.HighEmphasis = true;
            this.removeButton2.Icon = null;
            this.removeButton2.Location = new System.Drawing.Point(655, 408);
            this.removeButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeButton2.Name = "removeButton2";
            this.removeButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeButton2.Size = new System.Drawing.Size(138, 36);
            this.removeButton2.TabIndex = 2;
            this.removeButton2.Text = "Удалить";
            this.removeButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeButton2.UseAccentColor = false;
            this.removeButton2.UseVisualStyleBackColor = true;
            this.removeButton2.Click += new System.EventHandler(this.removeButton2_Click);
            // 
            // editButton1
            // 
            this.editButton1.AutoSize = false;
            this.editButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editButton1.Depth = 0;
            this.editButton1.HighEmphasis = true;
            this.editButton1.Icon = null;
            this.editButton1.Location = new System.Drawing.Point(362, 408);
            this.editButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton1.Name = "editButton1";
            this.editButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton1.Size = new System.Drawing.Size(138, 36);
            this.editButton1.TabIndex = 3;
            this.editButton1.Text = "Изменить";
            this.editButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editButton1.UseAccentColor = false;
            this.editButton1.UseVisualStyleBackColor = true;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton1);
            this.Controls.Add(this.removeButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.readerListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Читатели";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView readerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton addButton1;
        private MaterialSkin.Controls.MaterialButton removeButton2;
        private MaterialSkin.Controls.MaterialButton editButton1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}


namespace Ex1Nikita
{
    partial class MainForm
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
            this.butOpen = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblExersize = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.exersizeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(66, 167);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(75, 23);
            this.butOpen.TabIndex = 0;
            this.butOpen.Text = "Open";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(48, 49);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(93, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Select a category ";
            // 
            // lblExersize
            // 
            this.lblExersize.AutoSize = true;
            this.lblExersize.Location = new System.Drawing.Point(48, 111);
            this.lblExersize.Name = "lblExersize";
            this.lblExersize.Size = new System.Drawing.Size(93, 13);
            this.lblExersize.TabIndex = 3;
            this.lblExersize.Text = "Select an exersize";
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "Console application",
            "Types of data",
            "Cycles"});
            this.unitComboBox.Location = new System.Drawing.Point(51, 65);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(121, 21);
            this.unitComboBox.TabIndex = 4;
            this.unitComboBox.Text = "(choose)";
            this.unitComboBox.SelectedIndexChanged += new System.EventHandler(this.unitComboBox_SelectedIndexChanged);
            // 
            // exersizeComboBox
            // 
            this.exersizeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.exersizeComboBox.FormattingEnabled = true;
            this.exersizeComboBox.Location = new System.Drawing.Point(51, 127);
            this.exersizeComboBox.Name = "exersizeComboBox";
            this.exersizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.exersizeComboBox.TabIndex = 5;
            this.exersizeComboBox.Text = "(choose)";
            this.exersizeComboBox.SelectedIndexChanged += new System.EventHandler(this.exersizeComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 251);
            this.Controls.Add(this.exersizeComboBox);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.lblExersize);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.butOpen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exersizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblExersize;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.ComboBox exersizeComboBox;
    }
}


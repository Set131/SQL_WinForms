namespace WindowsFormsApp5
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1256, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategory.ForeColor = System.Drawing.Color.Transparent;
            this.lblCategory.Location = new System.Drawing.Point(12, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(254, 38);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblTheme
            // 
            this.lblTheme.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTheme.ForeColor = System.Drawing.Color.Transparent;
            this.lblTheme.Location = new System.Drawing.Point(272, 9);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(246, 38);
            this.lblTheme.TabIndex = 2;
            this.lblTheme.Text = "Theme";
            // 
            // lblFormat
            // 
            this.lblFormat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormat.ForeColor = System.Drawing.Color.Transparent;
            this.lblFormat.Location = new System.Drawing.Point(524, 9);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(241, 38);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "Format";
            // 
            // lblPublisher
            // 
            this.lblPublisher.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublisher.ForeColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Location = new System.Drawing.Point(771, 9);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(237, 38);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(12, 50);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(254, 64);
            this.txtCategory.TabIndex = 5;
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(272, 50);
            this.txtTheme.Multiline = true;
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(246, 64);
            this.txtTheme.TabIndex = 6;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(524, 50);
            this.txtFormat.Multiline = true;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(241, 64);
            this.txtFormat.TabIndex = 7;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(771, 50);
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(237, 64);
            this.txtPublisher.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(1014, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(245, 105);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Click";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1268, 698);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Button btnFilter;
    }
}


namespace FileSizeReader
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPath = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbProcessed = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridFiles = new System.Windows.Forms.DataGridView();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbReaded = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPath);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 32);
            this.panel1.TabIndex = 0;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(84, 8);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(38, 13);
            this.lbPath.TabIndex = 3;
            this.lbPath.Text = "путь...";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(835, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(754, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbReaded);
            this.panel2.Controls.Add(this.progress);
            this.panel2.Controls.Add(this.lbProcessed);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 64);
            this.panel2.TabIndex = 1;
            // 
            // lbProcessed
            // 
            this.lbProcessed.AutoSize = true;
            this.lbProcessed.Location = new System.Drawing.Point(347, 10);
            this.lbProcessed.Name = "lbProcessed";
            this.lbProcessed.Size = new System.Drawing.Size(121, 13);
            this.lbProcessed.TabIndex = 1;
            this.lbProcessed.Text = "Обработано файлов: 0";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(3, 10);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 13);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Всего: 0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridFiles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 375);
            this.panel3.TabIndex = 2;
            // 
            // gridFiles
            // 
            this.gridFiles.AllowUserToAddRows = false;
            this.gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFiles.Location = new System.Drawing.Point(0, 0);
            this.gridFiles.MultiSelect = false;
            this.gridFiles.Name = "gridFiles";
            this.gridFiles.ReadOnly = true;
            this.gridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFiles.Size = new System.Drawing.Size(913, 375);
            this.gridFiles.TabIndex = 0;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(3, 26);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(907, 23);
            this.progress.TabIndex = 2;
            // 
            // lbReaded
            // 
            this.lbReaded.AutoSize = true;
            this.lbReaded.Location = new System.Drawing.Point(751, 10);
            this.lbReaded.Name = "lbReaded";
            this.lbReaded.Size = new System.Drawing.Size(0, 13);
            this.lbReaded.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbProcessed;
        private System.Windows.Forms.DataGridView gridFiles;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbReaded;
    }
}


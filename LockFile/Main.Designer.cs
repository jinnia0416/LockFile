namespace LockFile
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txbSelectPath = new System.Windows.Forms.TextBox();
            this.labSelectFileCount = new System.Windows.Forms.Label();
            this.btnLockFile = new System.Windows.Forms.Button();
            this.btnUnLockFile = new System.Windows.Forms.Button();
            this.labLockIng = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(417, 27);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "選擇檔案";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txbSelectPath
            // 
            this.txbSelectPath.Location = new System.Drawing.Point(12, 12);
            this.txbSelectPath.Multiline = true;
            this.txbSelectPath.Name = "txbSelectPath";
            this.txbSelectPath.ReadOnly = true;
            this.txbSelectPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbSelectPath.Size = new System.Drawing.Size(399, 54);
            this.txbSelectPath.TabIndex = 1;
            // 
            // labSelectFileCount
            // 
            this.labSelectFileCount.AutoSize = true;
            this.labSelectFileCount.Location = new System.Drawing.Point(10, 89);
            this.labSelectFileCount.Name = "labSelectFileCount";
            this.labSelectFileCount.Size = new System.Drawing.Size(77, 12);
            this.labSelectFileCount.TabIndex = 2;
            this.labSelectFileCount.Text = "合計選取: 0筆";
            // 
            // btnLockFile
            // 
            this.btnLockFile.Location = new System.Drawing.Point(330, 78);
            this.btnLockFile.Name = "btnLockFile";
            this.btnLockFile.Size = new System.Drawing.Size(81, 34);
            this.btnLockFile.TabIndex = 3;
            this.btnLockFile.Text = "鎖定檔案";
            this.btnLockFile.UseVisualStyleBackColor = true;
            this.btnLockFile.Click += new System.EventHandler(this.btnLockFile_Click);
            // 
            // btnUnLockFile
            // 
            this.btnUnLockFile.Location = new System.Drawing.Point(417, 78);
            this.btnUnLockFile.Name = "btnUnLockFile";
            this.btnUnLockFile.Size = new System.Drawing.Size(81, 34);
            this.btnUnLockFile.TabIndex = 4;
            this.btnUnLockFile.Text = "解鎖檔案";
            this.btnUnLockFile.UseVisualStyleBackColor = true;
            this.btnUnLockFile.Click += new System.EventHandler(this.btnUnLockFile_Click);
            // 
            // labLockIng
            // 
            this.labLockIng.AutoSize = true;
            this.labLockIng.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLockIng.ForeColor = System.Drawing.Color.Red;
            this.labLockIng.Location = new System.Drawing.Point(143, 74);
            this.labLockIng.Name = "labLockIng";
            this.labLockIng.Size = new System.Drawing.Size(135, 29);
            this.labLockIng.TabIndex = 5;
            this.labLockIng.Text = "鎖定中!!";
            this.labLockIng.Visible = false;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(LockFile.Program);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 120);
            this.Controls.Add(this.labLockIng);
            this.Controls.Add(this.btnUnLockFile);
            this.Controls.Add(this.btnLockFile);
            this.Controls.Add(this.labSelectFileCount);
            this.Controls.Add(this.txbSelectPath);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txbSelectPath;
        private System.Windows.Forms.Label labSelectFileCount;
        private System.Windows.Forms.Button btnLockFile;
        private System.Windows.Forms.Button btnUnLockFile;
        private System.Windows.Forms.Label labLockIng;
        private System.Windows.Forms.BindingSource programBindingSource;
    }
}


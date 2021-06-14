using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockFile
{
    public partial class Main : Form
    {
        //選取檔案陣列
        private string[] filePaths = new string[0];
        //鎖定檔案讀取流陣列
        private FileStream[] fileStream;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "鎖定檔案";
            btnUnLockFile.Enabled = false;
        }

        //選取檔案
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//該值確定是否可以選擇多個檔案
            dialog.Title = "請選擇資料夾";
            dialog.Filter = "所有檔案(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //儲存選取的檔案
                filePaths = dialog.FileNames;
                //將選取的檔案顯示到畫面上
                txbSelectPath.Text = string.Join(Environment.NewLine, filePaths);
                labSelectFileCount.Text = $"合計選取: {filePaths.Length}筆";
            }
        }
        //鎖定檔案
        private void btnLockFile_Click(object sender, EventArgs e)
        {
            if(filePaths.Length < 1)
            {
                MessageBox.Show("請選擇檔案後在按鎖定");
                return;
            }
            //將其他按鈕鎖定
            btnLockFile.Enabled = false;
            btnSelectFile.Enabled = false;

            btnUnLockFile.Enabled = true;
            labLockIng.Visible = true;

            //初始化陣列
            fileStream = new FileStream[filePaths.Length];
            for(int i= 0; i< filePaths.Length; i++)
            {
                fileStream[i] = new FileStream(filePaths[i], FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
        }

        private void btnUnLockFile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileStream.Length; i++)
            {
                fileStream[i].Close();
            }
            fileStream = null;

            btnLockFile.Enabled = true;
            btnSelectFile.Enabled = true;

            btnUnLockFile.Enabled = false;
            labLockIng.Visible = false;
        }
    }
}

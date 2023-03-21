using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zip.Entities;

namespace Zip.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            string message = MainManager.Instance.compressManager.InitCompress(txtPath.Text);

            if (message.Contains("successful")) txtPath.Text = "";
            MessageBox.Show(message);
        }
    }
}

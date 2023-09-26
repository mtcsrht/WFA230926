using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230926
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ = new FrmGame(
                o: (int)nudOszlop.Value,
                s: (int)nudSor.Value,
                a: (int)nudAknaSzam.Value)
                .ShowDialog();
            this.Show();
        }
    }
}

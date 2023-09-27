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
            nudOszlop.ValueChanged += Szamolas;
            nudSor.ValueChanged += Szamolas;
        }
        private void Szamolas(object sender, EventArgs e)
        {
            int optAknaSzam = (int)((nudOszlop.Value * nudSor.Value) * 0.2M);

            nudAknaSzam.Value = optAknaSzam;
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

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
    public partial class FrmGame : Form
    {
        static Random rnd = new Random();
        public int Oszlopok { get; set; }
        public int Sorok { get; set; }
        public int Aknak { get; set; }
        public Button[,] Aknamezo { get; set; }

        public FrmGame(int o, int s, int a)
        {
            Oszlopok = o;
            Sorok = s;
            Aknak = a;
            InitializeComponent();
            InitAknamezo();
        }

        private void InitAknamezo()
        {
            //chk
            Aknamezo = new Button[Sorok, Oszlopok];
            for (int s = 0; s < Aknamezo.GetLength(0); s++)
            {
                for (int o = 0; o < Aknamezo.GetLength(1); o++)
                {
                    Aknamezo[s, o] = new Button()
                    {
                        Bounds = new Rectangle(
                            x: o * 50,
                            y: s * 50,
                            width: 50,
                            height: 50),
                    };
                    Aknamezo[s, o].Click += AknamezoBtn_Click;
                    this.Controls.Add(Aknamezo[s, o]);
                }
            }
        }

        private void AknamezoBtn_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}

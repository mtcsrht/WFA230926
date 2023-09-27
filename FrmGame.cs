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
        public bool[,] AknaPos { get; set; }

        public FrmGame(int o, int s, int a)
        {
            Oszlopok = o;
            Sorok = s;
            Aknak = a;
            InitializeComponent();
            InitAknamezo();
            InitAknaPos();
        }

        private void InitAknaPos()
        {
            AknaPos = new bool[Sorok, Oszlopok];
            for (int i = 0; i < Aknak;)
            {
                int randomSor = rnd.Next(Sorok);
                int randomOslzop = rnd.Next(Oszlopok);

                if (!AknaPos[randomSor, randomOslzop])
                {
                    AknaPos[randomSor, randomOslzop] = true;
                    i++;
                }
            }
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

            var crds = MatrixIndexOf(sender as Button);
            if (AknaPos[crds.s, crds.o])
            {
                (sender as Button).BackColor = Color.Red;
            }
            else  (sender as Button).BackColor = Color.Green;

        }

        private (int s, int o)MatrixIndexOf(Button button)
        {
            for (int s = 0; s < Aknamezo.GetLength(0); s++)
            {
                for (int o = 0; o < Aknamezo.GetLength(1); o++)
                {
                    if (Aknamezo[s, o].Equals(button)) return (s, o);
                }
            }
            throw new Exception("error"); 
        }
    }
}

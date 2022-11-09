using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodamemoria
{
    public partial class comecar : Form
    {
        public comecar()
        {
            InitializeComponent();
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            string dificuldade = cbDificuldade.Text;
            int x = 4;
            int y = 2;
            if (dificuldade == "Fácil")
            {
                x = 4;
                y = 2;
            }
            else if(dificuldade == "Médio")
            {
                x = 4;
                y = 4;
            }
            else
            {
                x = 6;
                y = 4;
            }
            this.Hide();
            jogo jogo = new jogo();
            jogo.x = x;
            jogo.y = y;
            jogo.Width = 625;
            jogo.Height = 375;
            if (jogo.x * jogo.y == 16)
            {
                jogo.Height = 625;
            }
            if (jogo.x * jogo.y == 24)
            {
                jogo.Width = 823;
                jogo.Height = 625;
            }
            jogo.ShowDialog();
            this.Show();
        }

        private void Comecar_Load(object sender, EventArgs e)
        {
            cbDificuldade.Text = "Fácil";
            btnSair.Click += new EventHandler(BtnSair_Click);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

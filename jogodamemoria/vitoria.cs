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
    public partial class vitoria : Form
    {
        public vitoria()
        {
            InitializeComponent();
        }
        public int segundos = 0;
        private void Vitoria_Load(object sender, EventArgs e)
        {
            lblVitoria.Text = String.Format("Venceu por {0} segundos",segundos);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            comecar form = new comecar();
            form.ShowDialog();
            Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace jogodamemoria
{
    public partial class jogo : Form
    {
        public jogo()
        {
            InitializeComponent();
        }
        public void EscolherImg(Button btn, int  num)
        {
            switch (num)
            {
                case 1:
                    btn.BackgroundImage = Properties.Resources.img1;
                    break;
                case 2:
                    btn.BackgroundImage = Properties.Resources.img2;
                    break;
                case 3:
                    btn.BackgroundImage = Properties.Resources.img3;
                    break;
                case 4:
                    btn.BackgroundImage = Properties.Resources.img4;
                    break;
                case 5:
                    btn.BackgroundImage = Properties.Resources.img5;
                    break;
                case 6:
                    btn.BackgroundImage = Properties.Resources.img6;
                    break;
                case 7:
                    btn.BackgroundImage = Properties.Resources.img7;
                    break;
                case 8:
                    btn.BackgroundImage = Properties.Resources.img8;
                    break;
                case 9:
                    btn.BackgroundImage = Properties.Resources.img9;
                    break;
                case 10:
                    btn.BackgroundImage = Properties.Resources.img10;
                    break;
                case 11:
                    btn.BackgroundImage = Properties.Resources.img11;
                    break;
                case 12:
                    btn.BackgroundImage = Properties.Resources.img12;
                    break;
            }
        }
        public int x;
        public int y;
        List<int> valores = new List<int>();
        List<int> valoresDescobertos = new List<int>();
        string nameTemp;
        int imgTemp;
        bool primeiraImgJogada = false;
        bool segundaImgJogada = false;
        bool acertou = false;
        Button primeiroBtnJogada, segundoBtnJogada;
        int tempo = 0;
        public Timer tempo2seg = new Timer();
        public void ClicarNaImg(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            string nomeTemp = "";
            bool acabou = false;
            foreach (char charName in btn.Name)
            {
                if(charName.ToString() != "_" && acabou == false)
                {
                    nomeTemp += charName;
                }
                else
                {
                    acabou = true;
                }
                if (acabou==true)
                {
                    EscolherImg(btn, Int32.Parse(nomeTemp.ToString()));
                    if (primeiraImgJogada == false)
                    {
                        primeiroBtnJogada = btn;
                        primeiroBtnJogada.Enabled = false;
                        primeiraImgJogada = true;
                        break;
                    }
                    else
                    {
                        primeiroBtnJogada.Enabled = true;
                        segundoBtnJogada = btn;
                        segundaImgJogada = true;
                        tempo2seg.Enabled = true;
                        tempo2seg.Interval = 1000;
                        tempo2seg.Tick += new EventHandler(Esperar2sec_Tick);
                        if (segundoBtnJogada.Name[0].ToString() == primeiroBtnJogada.Name[0].ToString())
                        {
                            acertou = true;
                            valoresDescobertos.Add(Int32.Parse(segundoBtnJogada.Name[0].ToString()));
                        }
                        else
                        {
                            acertou = false;
                        }
                        break;
                    }
                }
            }

        }
        public void Esperar2sec_Tick(object sender, EventArgs e)
        {
            if (segundaImgJogada == true && primeiraImgJogada == true)
            {
                if(acertou == false)
                {
                    if (valoresDescobertos.IndexOf(Int32.Parse(segundoBtnJogada.Name[0].ToString())) == -1)
                    {
                        segundoBtnJogada.BackgroundImage = Properties.Resources.caixa;
                    }
                    if (valoresDescobertos.IndexOf(Int32.Parse(segundoBtnJogada.Name[0].ToString())) == -1)
                    {
                        primeiroBtnJogada.BackgroundImage = Properties.Resources.caixa;
                    }
                }
                else
                {
                    primeiroBtnJogada.Name = "ganhou";
                    segundoBtnJogada.Name = "ganhou";
                }
                tempo2seg.Enabled = false;
                tempo2seg.Stop();
                tempo2seg = new Timer();
                primeiroBtnJogada = new Button();
                segundoBtnJogada = new Button();
                primeiraImgJogada = false;
                primeiraImgJogada = false;
                segundaImgJogada = false;
                acertou = false;
            }
        }
        public void VerificarValor()
        {
            Random rnd = new Random();
            while (true)
            {
                int valor = rnd.Next(1, 5);
                if (x*y==16)
                {
                    valor = rnd.Next(1, 9);
                }
                if (x*y==24)
                {
                    valor = rnd.Next(1, 13);
                }
                bool existeDois = false;
                bool existeUm = false;
                for (int i = 0; i < valores.Count; i++)
                {
                    if (valores[i] == valor && existeUm)
                    {
                        existeDois = true;
                    }
                    if (valor == valores[i])
                    {
                        existeUm = true;
                    }
                }
                if (existeDois == false && existeUm == true)
                {
                    nameTemp = String.Format("{0}_2", valor); //valor(indica a img) e _2 indica que é a segunda img
                    imgTemp = valor;
                    valores.Add(valor);
                    break;
                }
                else if (existeUm == false)
                {
                    nameTemp = String.Format("{0}_1", valor); //valor(indica a img) e _1 indica que é a primeira img
                    imgTemp = valor;
                    valores.Add(valor);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void CriarBtn(int x, int y)
        {
            int ix = 100, iy = 100;
            for (int i = 0; i < y; i++)
            {
                for (int k = 0; k < x; k++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(ix, iy);
                    btn.Width = 100;
                    btn.Height = 100;
                    btn.BackgroundImage = Properties.Resources.caixa;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    VerificarValor();
                    btn.Name = nameTemp;
                    //btn.Text = btn.Name; //--> para testar melhor
                    // erros -> banana e kiwi equivalem
                    btn.Click += new EventHandler(ClicarNaImg);
                    this.Controls.Add(btn);
                    ix += 100;
                }
                ix = 100;
                iy += 100;
            }

        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            CriarBtn(x, y);
            this.Width = 625; 
            this.Height = 375;
            if (x * y == 16)
            {
                this.Height = 625;
            }
            if (x * y == 24)
            {
                this.Width = 823;
                this.Height = 625;
            }
        }
        public void VerificarSeVenceu()
        {
            bool ganhou = true;
            foreach(Control btn in this.Controls)
            {
                if(btn is Button)
                {
                    if (btn.Name != "ganhou")
                    {
                        ganhou = false;
                        break;
                    }
                }
            }
            if (ganhou)
            {
                timer.Stop();
                this.Hide();
                vitoria formVitoria = new vitoria();
                formVitoria.segundos = tempo;
                formVitoria.ShowDialog();
                Environment.Exit(0);
            }
        }
        public void DesativarCartasGanhas()
        {
            foreach (Control btn in this.Controls)
            {
                if (btn is Button)
                {
                    if (btn.Name == "ganhou")
                    {
                        btn.Enabled = false;
                    }
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tempo++;
            lblTempo.Text = String.Format("Tempo: {0}s",tempo.ToString());
            VerificarSeVenceu();
            DesativarCartasGanhas();
        }
    }
}

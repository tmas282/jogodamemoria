namespace jogodamemoria
{
    partial class comecar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comecar));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.PictureBox();
            this.imgTitulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.BackColor = System.Drawing.Color.White;
            this.cbDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDificuldade.ForeColor = System.Drawing.Color.Black;
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.cbDificuldade.Location = new System.Drawing.Point(205, 236);
            this.cbDificuldade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(369, 47);
            this.cbDificuldade.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::jogodamemoria.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(717, 15);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 62);
            this.btnSair.TabIndex = 7;
            this.btnSair.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.BackgroundImage = global::jogodamemoria.Properties.Resources.imgBtnJogar;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogar.Location = new System.Drawing.Point(289, 311);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(197, 58);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.TabStop = false;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // imgTitulo
            // 
            this.imgTitulo.BackColor = System.Drawing.Color.Transparent;
            this.imgTitulo.BackgroundImage = global::jogodamemoria.Properties.Resources.imgTitulo;
            this.imgTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitulo.Location = new System.Drawing.Point(64, 112);
            this.imgTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgTitulo.Name = "imgTitulo";
            this.imgTitulo.Size = new System.Drawing.Size(665, 106);
            this.imgTitulo.TabIndex = 9;
            this.imgTitulo.TabStop = false;
            // 
            // comecar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::jogodamemoria.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgTitulo);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbDificuldade);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "comecar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da memória";
            this.Load += new System.EventHandler(this.Comecar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnJogar;
        private System.Windows.Forms.PictureBox imgTitulo;
    }
}


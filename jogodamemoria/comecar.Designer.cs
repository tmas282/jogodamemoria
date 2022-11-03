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
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblJogar = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(240, 220);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(102, 26);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // lblJogar
            // 
            this.lblJogar.AutoSize = true;
            this.lblJogar.BackColor = System.Drawing.Color.Transparent;
            this.lblJogar.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogar.Location = new System.Drawing.Point(58, 56);
            this.lblJogar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogar.Name = "lblJogar";
            this.lblJogar.Size = new System.Drawing.Size(477, 80);
            this.lblJogar.TabIndex = 3;
            this.lblJogar.Text = "Jogo da memória";
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.cbDificuldade.Location = new System.Drawing.Point(197, 174);
            this.cbDificuldade.Margin = new System.Windows.Forms.Padding(2);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(192, 21);
            this.cbDificuldade.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::jogodamemoria.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(538, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.TabStop = false;
            // 
            // comecar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::jogodamemoria.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.lblJogar);
            this.Controls.Add(this.btnJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "comecar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da memória";
            this.Load += new System.EventHandler(this.Comecar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblJogar;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.PictureBox btnSair;
    }
}


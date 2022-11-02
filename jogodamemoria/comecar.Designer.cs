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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblJogar = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(327, 231);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(136, 32);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // lblJogar
            // 
            this.lblJogar.AutoSize = true;
            this.lblJogar.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogar.Location = new System.Drawing.Point(106, 57);
            this.lblJogar.Name = "lblJogar";
            this.lblJogar.Size = new System.Drawing.Size(598, 98);
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
            this.cbDificuldade.Location = new System.Drawing.Point(266, 202);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(254, 24);
            this.cbDificuldade.TabIndex = 6;
            // 
            // comecar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.lblJogar);
            this.Controls.Add(this.btnJogar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "comecar";
            this.Text = "Jogo da memória";
            this.Load += new System.EventHandler(this.comecar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblJogar;
        private System.Windows.Forms.ComboBox cbDificuldade;
    }
}


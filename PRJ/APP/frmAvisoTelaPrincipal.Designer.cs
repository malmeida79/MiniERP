namespace MiniErp.App.view
{
    partial class frmAvisoTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvisoTelaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFazerBackup = new System.Windows.Forms.Button();
            this.pbAvisoTelaPrincipal = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ckbNaoRealizaBackup = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(489, 203);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFazerBackup
            // 
            this.btnFazerBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerBackup.ForeColor = System.Drawing.Color.Red;
            this.btnFazerBackup.Location = new System.Drawing.Point(239, 203);
            this.btnFazerBackup.Name = "btnFazerBackup";
            this.btnFazerBackup.Size = new System.Drawing.Size(175, 38);
            this.btnFazerBackup.TabIndex = 2;
            this.btnFazerBackup.Text = "Fazer Backup";
            this.btnFazerBackup.UseVisualStyleBackColor = true;
            this.btnFazerBackup.Click += new System.EventHandler(this.btnFazerBackup_Click);
            // 
            // pbAvisoTelaPrincipal
            // 
            this.pbAvisoTelaPrincipal.Location = new System.Drawing.Point(239, 174);
            this.pbAvisoTelaPrincipal.Name = "pbAvisoTelaPrincipal";
            this.pbAvisoTelaPrincipal.Size = new System.Drawing.Size(325, 23);
            this.pbAvisoTelaPrincipal.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ckbNaoRealizaBackup
            // 
            this.ckbNaoRealizaBackup.AutoSize = true;
            this.ckbNaoRealizaBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNaoRealizaBackup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ckbNaoRealizaBackup.Location = new System.Drawing.Point(239, 137);
            this.ckbNaoRealizaBackup.Name = "ckbNaoRealizaBackup";
            this.ckbNaoRealizaBackup.Size = new System.Drawing.Size(219, 20);
            this.ckbNaoRealizaBackup.TabIndex = 5;
            this.ckbNaoRealizaBackup.Text = "Não Realizar Backup agora";
            this.ckbNaoRealizaBackup.UseVisualStyleBackColor = true;
            this.ckbNaoRealizaBackup.CheckedChanged += new System.EventHandler(this.ckbNaoRealizaBackup_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 100);
            this.label1.TabIndex = 6;
            this.label1.Text = "Atenção: A realização do Backup é de responsabilidade do usuário.\r\nNão nos respon" +
    "sabilizamos por eventuais perdas de dados.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAvisoTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbNaoRealizaBackup);
            this.Controls.Add(this.pbAvisoTelaPrincipal);
            this.Controls.Add(this.btnFazerBackup);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAvisoTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Comercial - Alerta";
            this.Load += new System.EventHandler(this.frmAvisoTelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFazerBackup;
        private System.Windows.Forms.ProgressBar pbAvisoTelaPrincipal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ckbNaoRealizaBackup;
        private System.Windows.Forms.Label label1;
    }
}
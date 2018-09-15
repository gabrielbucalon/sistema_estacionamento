namespace EA_.View
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblEmailOuCPFIncorreto = new System.Windows.Forms.Label();
            this.lblOU = new System.Windows.Forms.Label();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.linkparacadastrar = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSenhaEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdPessoaFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaFisicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaJuridicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.lblEmailOuCPFIncorreto);
            this.groupBox1.Controls.Add(this.lblOU);
            this.groupBox1.Controls.Add(this.btnPessoaJuridica);
            this.groupBox1.Controls.Add(this.btnPessoaFisica);
            this.groupBox1.Controls.Add(this.linkparacadastrar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEntrar);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblSenhaEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdPessoaJuridica);
            this.groupBox1.Controls.Add(this.rdPessoaFisica);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(210, 48);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(150, 26);
            this.txtCPF.TabIndex = 15;
            this.txtCPF.Visible = false;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // lblEmailOuCPFIncorreto
            // 
            this.lblEmailOuCPFIncorreto.AutoSize = true;
            this.lblEmailOuCPFIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lblEmailOuCPFIncorreto.Location = new System.Drawing.Point(224, 25);
            this.lblEmailOuCPFIncorreto.Name = "lblEmailOuCPFIncorreto";
            this.lblEmailOuCPFIncorreto.Size = new System.Drawing.Size(116, 19);
            this.lblEmailOuCPFIncorreto.TabIndex = 14;
            this.lblEmailOuCPFIncorreto.Text = "E-mail incorreto";
            this.lblEmailOuCPFIncorreto.Visible = false;
            // 
            // lblOU
            // 
            this.lblOU.AutoSize = true;
            this.lblOU.Location = new System.Drawing.Point(206, 258);
            this.lblOU.Name = "lblOU";
            this.lblOU.Size = new System.Drawing.Size(32, 19);
            this.lblOU.TabIndex = 13;
            this.lblOU.Text = "OU";
            this.lblOU.Visible = false;
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.Location = new System.Drawing.Point(244, 256);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(136, 23);
            this.btnPessoaJuridica.TabIndex = 12;
            this.btnPessoaJuridica.Text = "Pessoa Juridica";
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPessoaJuridica.Visible = false;
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Location = new System.Drawing.Point(78, 255);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(123, 23);
            this.btnPessoaFisica.TabIndex = 11;
            this.btnPessoaFisica.Text = "Pessoa Fisica";
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPessoaFisica.Visible = false;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // linkparacadastrar
            // 
            this.linkparacadastrar.AutoSize = true;
            this.linkparacadastrar.Location = new System.Drawing.Point(90, 222);
            this.linkparacadastrar.Name = "linkparacadastrar";
            this.linkparacadastrar.Size = new System.Drawing.Size(241, 19);
            this.linkparacadastrar.TabIndex = 10;
            this.linkparacadastrar.TabStop = true;
            this.linkparacadastrar.Text = "Não é cadastrado? CLIQUE AQUI";
            this.linkparacadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkparacadastrar_LinkClicked);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(108, 174);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(116, 33);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(210, 124);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(150, 26);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite sua senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(210, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtCPFouEmail_TextChanged);
            // 
            // lblSenhaEmail
            // 
            this.lblSenhaEmail.AutoSize = true;
            this.lblSenhaEmail.Location = new System.Drawing.Point(153, 49);
            this.lblSenhaEmail.Name = "lblSenhaEmail";
            this.lblSenhaEmail.Size = new System.Drawing.Size(50, 19);
            this.lblSenhaEmail.TabIndex = 4;
            this.lblSenhaEmail.Text = "e-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 3;
            // 
            // rdPessoaJuridica
            // 
            this.rdPessoaJuridica.AutoSize = true;
            this.rdPessoaJuridica.Location = new System.Drawing.Point(200, 84);
            this.rdPessoaJuridica.Name = "rdPessoaJuridica";
            this.rdPessoaJuridica.Size = new System.Drawing.Size(131, 23);
            this.rdPessoaJuridica.TabIndex = 2;
            this.rdPessoaJuridica.Text = "Pessoa Juridica";
            this.rdPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdPessoaJuridica_CheckedChanged);
            // 
            // rdPessoaFisica
            // 
            this.rdPessoaFisica.AutoSize = true;
            this.rdPessoaFisica.Checked = true;
            this.rdPessoaFisica.Location = new System.Drawing.Point(77, 83);
            this.rdPessoaFisica.Name = "rdPessoaFisica";
            this.rdPessoaFisica.Size = new System.Drawing.Size(117, 23);
            this.rdPessoaFisica.TabIndex = 1;
            this.rdPessoaFisica.TabStop = true;
            this.rdPessoaFisica.Text = "Pessoa Fisica";
            this.rdPessoaFisica.UseVisualStyleBackColor = true;
            this.rdPessoaFisica.CheckedChanged += new System.EventHandler(this.rdPessoaFisica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.mapaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sairToolStripMenuItem.Text = "Logout";
            this.sairToolStripMenuItem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(80, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 414);
            this.panel1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EA_.Properties.Resources.if_Login_73221;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Image = global::EA_.Properties.Resources.icons8_casa_512_3_;
            this.inicioToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click_1);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.entrarToolStripMenuItem});
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Image = global::EA_.Properties.Resources.icons8_entrar_filled_100_1_;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaFisicaToolStripMenuItem,
            this.pessoaJuridicaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // pessoaFisicaToolStripMenuItem
            // 
            this.pessoaFisicaToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.pessoaFisicaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pessoaFisicaToolStripMenuItem.Name = "pessoaFisicaToolStripMenuItem";
            this.pessoaFisicaToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.pessoaFisicaToolStripMenuItem.Text = "Pessoa Fisica";
            this.pessoaFisicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaFisicaToolStripMenuItem_Click_1);
            // 
            // pessoaJuridicaToolStripMenuItem
            // 
            this.pessoaJuridicaToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.pessoaJuridicaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pessoaJuridicaToolStripMenuItem.Name = "pessoaJuridicaToolStripMenuItem";
            this.pessoaJuridicaToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.pessoaJuridicaToolStripMenuItem.Text = "Pessoa Juridica";
            this.pessoaJuridicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaJuridicaToolStripMenuItem_Click_1);
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.entrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click_1);
            // 
            // mapaToolStripMenuItem
            // 
            this.mapaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mapaToolStripMenuItem.Image = global::EA_.Properties.Resources.icons8_mapa_múndi_filled_1001;
            this.mapaToolStripMenuItem.Name = "mapaToolStripMenuItem";
            this.mapaToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.mapaToolStripMenuItem.Text = "Mapa";
            this.mapaToolStripMenuItem.Click += new System.EventHandler(this.mapaToolStripMenuItem_Click_1);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sobreToolStripMenuItem.Image = global::EA_.Properties.Resources.icons8_sobre_filled_100;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacione AQUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenhaEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdPessoaJuridica;
        private System.Windows.Forms.RadioButton rdPessoaFisica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkparacadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOU;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Label lblEmailOuCPFIncorreto;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaFisicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaJuridicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
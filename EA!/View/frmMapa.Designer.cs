namespace EA_.View
{
    partial class frmMapa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.btnApagaRota = new System.Windows.Forms.Button();
            this.btnRota = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProvedorMapas = new System.Windows.Forms.ComboBox();
            this.txbZoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLatitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndLatLon = new System.Windows.Forms.Button();
            this.btnPesquisarEndereco = new System.Windows.Forms.Button();
            this.tbxEndereço = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Visible = false;
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(9, 99);
            this.MainMap.Margin = new System.Windows.Forms.Padding(2);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomEnabled = true;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(586, 422);
            this.MainMap.TabIndex = 3;
            this.MainMap.Zoom = 0D;
            this.MainMap.OnPositionChanged += new GMap.NET.PositionChanged(this.MainMap_OnPositionChanged);
            this.MainMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.MainMap_OnMapZoomChanged);
            // 
            // grbInfo
            // 
            this.grbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInfo.Controls.Add(this.btnApagaRota);
            this.grbInfo.Controls.Add(this.btnRota);
            this.grbInfo.Controls.Add(this.groupBox1);
            this.grbInfo.Controls.Add(this.btnEndLatLon);
            this.grbInfo.Location = new System.Drawing.Point(600, 38);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(186, 370);
            this.grbInfo.TabIndex = 4;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Info";
            // 
            // btnApagaRota
            // 
            this.btnApagaRota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagaRota.Location = new System.Drawing.Point(98, 176);
            this.btnApagaRota.Name = "btnApagaRota";
            this.btnApagaRota.Size = new System.Drawing.Size(82, 36);
            this.btnApagaRota.TabIndex = 2;
            this.btnApagaRota.Text = "Apaga Rotas";
            this.btnApagaRota.UseVisualStyleBackColor = true;
            this.btnApagaRota.Click += new System.EventHandler(this.btnApagaRota_Click);
            // 
            // btnRota
            // 
            this.btnRota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRota.Location = new System.Drawing.Point(6, 176);
            this.btnRota.Name = "btnRota";
            this.btnRota.Size = new System.Drawing.Size(82, 36);
            this.btnRota.TabIndex = 1;
            this.btnRota.Text = "Testa Rota";
            this.btnRota.UseVisualStyleBackColor = true;
            this.btnRota.Click += new System.EventHandler(this.btnRota_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxProvedorMapas);
            this.groupBox1.Controls.Add(this.txbZoom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbLongitude);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbLatitude);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Provedor de Mapas";
            // 
            // cbxProvedorMapas
            // 
            this.cbxProvedorMapas.FormattingEnabled = true;
            this.cbxProvedorMapas.Location = new System.Drawing.Point(9, 35);
            this.cbxProvedorMapas.Name = "cbxProvedorMapas";
            this.cbxProvedorMapas.Size = new System.Drawing.Size(159, 21);
            this.cbxProvedorMapas.TabIndex = 6;
            this.cbxProvedorMapas.DropDownClosed += new System.EventHandler(this.cbxProvedorMapas_DropDownClosed);
            // 
            // txbZoom
            // 
            this.txbZoom.Location = new System.Drawing.Point(68, 114);
            this.txbZoom.Name = "txbZoom";
            this.txbZoom.Size = new System.Drawing.Size(100, 20);
            this.txbZoom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zoom:";
            // 
            // txbLongitude
            // 
            this.txbLongitude.Location = new System.Drawing.Point(68, 88);
            this.txbLongitude.Name = "txbLongitude";
            this.txbLongitude.Size = new System.Drawing.Size(100, 20);
            this.txbLongitude.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude:";
            // 
            // txbLatitude
            // 
            this.txbLatitude.Location = new System.Drawing.Point(68, 62);
            this.txbLatitude.Name = "txbLatitude";
            this.txbLatitude.Size = new System.Drawing.Size(100, 20);
            this.txbLatitude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude:";
            // 
            // btnEndLatLon
            // 
            this.btnEndLatLon.Location = new System.Drawing.Point(6, 218);
            this.btnEndLatLon.Name = "btnEndLatLon";
            this.btnEndLatLon.Size = new System.Drawing.Size(174, 38);
            this.btnEndLatLon.TabIndex = 3;
            this.btnEndLatLon.Text = "Pesquisa Endereço no Centro do Mapa!";
            this.btnEndLatLon.UseVisualStyleBackColor = true;
            this.btnEndLatLon.Click += new System.EventHandler(this.btnEndLatLon_Click);
            // 
            // btnPesquisarEndereco
            // 
            this.btnPesquisarEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarEndereco.Location = new System.Drawing.Point(512, 72);
            this.btnPesquisarEndereco.Name = "btnPesquisarEndereco";
            this.btnPesquisarEndereco.Size = new System.Drawing.Size(82, 22);
            this.btnPesquisarEndereco.TabIndex = 11;
            this.btnPesquisarEndereco.Text = "Pesquisar";
            this.btnPesquisarEndereco.UseVisualStyleBackColor = true;
            // 
            // tbxEndereço
            // 
            this.tbxEndereço.Location = new System.Drawing.Point(74, 72);
            this.tbxEndereço.Name = "tbxEndereço";
            this.tbxEndereço.Size = new System.Drawing.Size(432, 20);
            this.tbxEndereço.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Endereço:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Mapa";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EA_.Properties.Resources.if_Rounded___High_Ultra_Colour02___Maps_2250024;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.mapaToolStripMenuItem.Image = global::EA_.Properties.Resources.icons8_mapa_múndi_filled_100;
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
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 561);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPesquisarEndereco);
            this.Controls.Add(this.tbxEndereço);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.MainMap);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacione AQUI!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMapa_FormClosed);
            this.Load += new System.EventHandler(this.frmMapa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Button btnApagaRota;
        private System.Windows.Forms.Button btnRota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProvedorMapas;
        private System.Windows.Forms.TextBox txbZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLongitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLatitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndLatLon;
        private System.Windows.Forms.Button btnPesquisarEndereco;
        private System.Windows.Forms.TextBox tbxEndereço;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
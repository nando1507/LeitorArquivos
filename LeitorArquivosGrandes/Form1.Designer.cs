namespace LeitorArquivosGrandes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CsvAbrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtAbrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ArquivoAbrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PastaAbrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.groupAbertura = new System.Windows.Forms.GroupBox();
            this.groupLeitura = new System.Windows.Forms.GroupBox();
            this.chkDelimitar = new System.Windows.Forms.CheckBox();
            this.cboDelimitador = new System.Windows.Forms.ComboBox();
            this.chkLimite = new System.Windows.Forms.CheckBox();
            this.NumValues = new System.Windows.Forms.NumericUpDown();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblArquivos = new System.Windows.Forms.Label();
            this.cboArquivos = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnLinhas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQuantidade = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            this.groupAbertura.SuspendLayout();
            this.groupLeitura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumValues)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivo,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuArquivo
            // 
            this.MenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirSubMenu});
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(61, 20);
            this.MenuArquivo.Text = "Arquivo";
            // 
            // AbrirSubMenu
            // 
            this.AbrirSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CsvAbrirMenu,
            this.TxtAbrirMenu,
            this.ArquivoAbrirMenu,
            this.PastaAbrirMenu});
            this.AbrirSubMenu.Name = "AbrirSubMenu";
            this.AbrirSubMenu.Size = new System.Drawing.Size(100, 22);
            this.AbrirSubMenu.Text = "Abrir";
            // 
            // CsvAbrirMenu
            // 
            this.CsvAbrirMenu.Name = "CsvAbrirMenu";
            this.CsvAbrirMenu.Size = new System.Drawing.Size(166, 22);
            this.CsvAbrirMenu.Text = "CSV";
            this.CsvAbrirMenu.Click += new System.EventHandler(this.CsvAbrirMenu_Click);
            // 
            // TxtAbrirMenu
            // 
            this.TxtAbrirMenu.Name = "TxtAbrirMenu";
            this.TxtAbrirMenu.Size = new System.Drawing.Size(166, 22);
            this.TxtAbrirMenu.Text = "TXT";
            this.TxtAbrirMenu.Click += new System.EventHandler(this.TxtAbrirMenu_Click);
            // 
            // ArquivoAbrirMenu
            // 
            this.ArquivoAbrirMenu.Name = "ArquivoAbrirMenu";
            this.ArquivoAbrirMenu.Size = new System.Drawing.Size(166, 22);
            this.ArquivoAbrirMenu.Text = "Arquivo Genérico";
            this.ArquivoAbrirMenu.Click += new System.EventHandler(this.ArquivoAbrirMenu_Click);
            // 
            // PastaAbrirMenu
            // 
            this.PastaAbrirMenu.Name = "PastaAbrirMenu";
            this.PastaAbrirMenu.Size = new System.Drawing.Size(166, 22);
            this.PastaAbrirMenu.Text = "Pastas";
            this.PastaAbrirMenu.Click += new System.EventHandler(this.pastasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dgvLeitor
            // 
            this.dgvLeitor.AllowUserToAddRows = false;
            this.dgvLeitor.AllowUserToDeleteRows = false;
            this.dgvLeitor.AllowUserToOrderColumns = true;
            this.dgvLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Location = new System.Drawing.Point(12, 131);
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.RowTemplate.Height = 25;
            this.dgvLeitor.Size = new System.Drawing.Size(776, 283);
            this.dgvLeitor.TabIndex = 1;
            this.dgvLeitor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeitor_CellContentDoubleClick);
            // 
            // groupAbertura
            // 
            this.groupAbertura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAbertura.Controls.Add(this.groupLeitura);
            this.groupAbertura.Controls.Add(this.btnCarregar);
            this.groupAbertura.Controls.Add(this.lblArquivos);
            this.groupAbertura.Controls.Add(this.cboArquivos);
            this.groupAbertura.Location = new System.Drawing.Point(12, 27);
            this.groupAbertura.Name = "groupAbertura";
            this.groupAbertura.Size = new System.Drawing.Size(776, 98);
            this.groupAbertura.TabIndex = 2;
            this.groupAbertura.TabStop = false;
            this.groupAbertura.Text = "Arquivos";
            // 
            // groupLeitura
            // 
            this.groupLeitura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLeitura.Controls.Add(this.chkDelimitar);
            this.groupLeitura.Controls.Add(this.cboDelimitador);
            this.groupLeitura.Controls.Add(this.chkLimite);
            this.groupLeitura.Controls.Add(this.NumValues);
            this.groupLeitura.Location = new System.Drawing.Point(500, 12);
            this.groupLeitura.Name = "groupLeitura";
            this.groupLeitura.Size = new System.Drawing.Size(270, 80);
            this.groupLeitura.TabIndex = 10;
            this.groupLeitura.TabStop = false;
            this.groupLeitura.Text = "Leitura";
            // 
            // chkDelimitar
            // 
            this.chkDelimitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDelimitar.AutoSize = true;
            this.chkDelimitar.Location = new System.Drawing.Point(12, 26);
            this.chkDelimitar.Name = "chkDelimitar";
            this.chkDelimitar.Size = new System.Drawing.Size(79, 19);
            this.chkDelimitar.TabIndex = 8;
            this.chkDelimitar.Text = "Delimitar?";
            this.chkDelimitar.UseVisualStyleBackColor = true;
            this.chkDelimitar.CheckedChanged += new System.EventHandler(this.chkDelimitar_CheckedChanged);
            // 
            // cboDelimitador
            // 
            this.cboDelimitador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDelimitador.Enabled = false;
            this.cboDelimitador.FormattingEnabled = true;
            this.cboDelimitador.Items.AddRange(new object[] {
            ";",
            ":",
            ",",
            "|",
            "-",
            "\'",
            "\"",
            "*",
            "+",
            "="});
            this.cboDelimitador.Location = new System.Drawing.Point(12, 51);
            this.cboDelimitador.Name = "cboDelimitador";
            this.cboDelimitador.Size = new System.Drawing.Size(103, 23);
            this.cboDelimitador.TabIndex = 9;
            this.cboDelimitador.Text = ";";
            // 
            // chkLimite
            // 
            this.chkLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLimite.AutoSize = true;
            this.chkLimite.Checked = true;
            this.chkLimite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLimite.Location = new System.Drawing.Point(144, 26);
            this.chkLimite.Name = "chkLimite";
            this.chkLimite.Size = new System.Drawing.Size(102, 19);
            this.chkLimite.TabIndex = 4;
            this.chkLimite.Text = "Limitar linhas?";
            this.chkLimite.UseVisualStyleBackColor = true;
            this.chkLimite.CheckedChanged += new System.EventHandler(this.chkLimite_CheckedChanged);
            // 
            // NumValues
            // 
            this.NumValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumValues.Location = new System.Drawing.Point(144, 51);
            this.NumValues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumValues.Name = "NumValues";
            this.NumValues.Size = new System.Drawing.Size(120, 23);
            this.NumValues.TabIndex = 1;
            this.NumValues.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(269, 44);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(72, 23);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Visible = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblArquivos
            // 
            this.lblArquivos.AutoSize = true;
            this.lblArquivos.Location = new System.Drawing.Point(6, 27);
            this.lblArquivos.Name = "lblArquivos";
            this.lblArquivos.Size = new System.Drawing.Size(126, 15);
            this.lblArquivos.TabIndex = 2;
            this.lblArquivos.Text = "Arquivos Selecionados";
            // 
            // cboArquivos
            // 
            this.cboArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboArquivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArquivos.FormattingEnabled = true;
            this.cboArquivos.Location = new System.Drawing.Point(6, 45);
            this.cboArquivos.Name = "cboArquivos";
            this.cboArquivos.Size = new System.Drawing.Size(257, 23);
            this.cboArquivos.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLinhas,
            this.lblQuantidade});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnLinhas
            // 
            this.btnLinhas.Name = "btnLinhas";
            this.btnLinhas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLinhas.Size = new System.Drawing.Size(41, 17);
            this.btnLinhas.Text = "Linhas";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantidade.Size = new System.Drawing.Size(13, 17);
            this.lblQuantidade.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupAbertura);
            this.Controls.Add(this.dgvLeitor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Arquivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            this.groupAbertura.ResumeLayout(false);
            this.groupAbertura.PerformLayout();
            this.groupLeitura.ResumeLayout(false);
            this.groupLeitura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumValues)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuArquivo;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem AbrirSubMenu;
        private DataGridView dgvLeitor;
        private GroupBox groupAbertura;
        private ToolStripMenuItem CsvAbrirMenu;
        private ToolStripMenuItem TxtAbrirMenu;
        private ToolStripMenuItem ArquivoAbrirMenu;
        private ComboBox cboArquivos;
        private ToolStripMenuItem PastaAbrirMenu;
        private NumericUpDown NumValues;
        private Label lblArquivos;
        private CheckBox chkLimite;
        private Button btnCarregar;
        private CheckBox chkDelimitar;
        private ComboBox cboDelimitador;
        private GroupBox groupLeitura;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel btnLinhas;
        private ToolStripStatusLabel lblQuantidade;
    }
}
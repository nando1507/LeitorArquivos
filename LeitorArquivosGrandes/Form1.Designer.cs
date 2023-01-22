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
            this.cboDelimitador = new System.Windows.Forms.ComboBox();
            this.chkDelimitar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.chkLimite = new System.Windows.Forms.CheckBox();
            this.lblLinhasLidas = new System.Windows.Forms.Label();
            this.lblArquivos = new System.Windows.Forms.Label();
            this.NumValues = new System.Windows.Forms.NumericUpDown();
            this.cboArquivos = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            this.groupAbertura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumValues)).BeginInit();
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
            this.dgvLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Location = new System.Drawing.Point(12, 120);
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.RowTemplate.Height = 25;
            this.dgvLeitor.Size = new System.Drawing.Size(776, 318);
            this.dgvLeitor.TabIndex = 1;
            // 
            // groupAbertura
            // 
            this.groupAbertura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAbertura.Controls.Add(this.cboDelimitador);
            this.groupAbertura.Controls.Add(this.chkDelimitar);
            this.groupAbertura.Controls.Add(this.label1);
            this.groupAbertura.Controls.Add(this.btnCarregar);
            this.groupAbertura.Controls.Add(this.chkLimite);
            this.groupAbertura.Controls.Add(this.lblLinhasLidas);
            this.groupAbertura.Controls.Add(this.lblArquivos);
            this.groupAbertura.Controls.Add(this.NumValues);
            this.groupAbertura.Controls.Add(this.cboArquivos);
            this.groupAbertura.Location = new System.Drawing.Point(12, 27);
            this.groupAbertura.Name = "groupAbertura";
            this.groupAbertura.Size = new System.Drawing.Size(776, 87);
            this.groupAbertura.TabIndex = 2;
            this.groupAbertura.TabStop = false;
            this.groupAbertura.Text = "Arquivos";
            // 
            // cboDelimitador
            // 
            this.cboDelimitador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cboDelimitador.Location = new System.Drawing.Point(467, 45);
            this.cboDelimitador.Name = "cboDelimitador";
            this.cboDelimitador.Size = new System.Drawing.Size(103, 23);
            this.cboDelimitador.TabIndex = 9;
            // 
            // chkDelimitar
            // 
            this.chkDelimitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDelimitar.AutoSize = true;
            this.chkDelimitar.Checked = true;
            this.chkDelimitar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelimitar.Location = new System.Drawing.Point(382, 47);
            this.chkDelimitar.Name = "chkDelimitar";
            this.chkDelimitar.Size = new System.Drawing.Size(79, 19);
            this.chkDelimitar.TabIndex = 8;
            this.chkDelimitar.Text = "Delimitar?";
            this.chkDelimitar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Linhas para leitura";
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
            // chkLimite
            // 
            this.chkLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLimite.AutoSize = true;
            this.chkLimite.Checked = true;
            this.chkLimite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLimite.Location = new System.Drawing.Point(576, 47);
            this.chkLimite.Name = "chkLimite";
            this.chkLimite.Size = new System.Drawing.Size(68, 19);
            this.chkLimite.TabIndex = 4;
            this.chkLimite.Text = "Limitar?";
            this.chkLimite.UseVisualStyleBackColor = true;
            this.chkLimite.CheckedChanged += new System.EventHandler(this.chkLimite_CheckedChanged);
            // 
            // lblLinhasLidas
            // 
            this.lblLinhasLidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinhasLidas.AutoSize = true;
            this.lblLinhasLidas.Location = new System.Drawing.Point(650, 28);
            this.lblLinhasLidas.Name = "lblLinhasLidas";
            this.lblLinhasLidas.Size = new System.Drawing.Size(103, 15);
            this.lblLinhasLidas.TabIndex = 3;
            this.lblLinhasLidas.Text = "Linhas para leitura";
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
            // NumValues
            // 
            this.NumValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumValues.Location = new System.Drawing.Point(650, 46);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.NumValues)).EndInit();
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
        private Label lblLinhasLidas;
        private Label lblArquivos;
        private CheckBox chkLimite;
        private Button btnCarregar;
        private CheckBox chkDelimitar;
        private Label label1;
        private ComboBox cboDelimitador;
    }
}
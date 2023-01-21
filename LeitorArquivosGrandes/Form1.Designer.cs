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
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupAbertura = new System.Windows.Forms.GroupBox();
            this.cboArquivos = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupAbertura.SuspendLayout();
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
            this.cSVToolStripMenuItem,
            this.tXTToolStripMenuItem,
            this.aRQUIVOToolStripMenuItem,
            this.pastasToolStripMenuItem});
            this.AbrirSubMenu.Name = "AbrirSubMenu";
            this.AbrirSubMenu.Size = new System.Drawing.Size(180, 22);
            this.AbrirSubMenu.Text = "Abrir";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aRQUIVOToolStripMenuItem.Text = "Arquivo Genérico";
            this.aRQUIVOToolStripMenuItem.Click += new System.EventHandler(this.aRQUIVOToolStripMenuItem_Click);
            // 
            // pastasToolStripMenuItem
            // 
            this.pastasToolStripMenuItem.Name = "pastasToolStripMenuItem";
            this.pastasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pastasToolStripMenuItem.Text = "Pastas";
            this.pastasToolStripMenuItem.Click += new System.EventHandler(this.pastasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupAbertura
            // 
            this.groupAbertura.Controls.Add(this.cboArquivos);
            this.groupAbertura.Location = new System.Drawing.Point(12, 27);
            this.groupAbertura.Name = "groupAbertura";
            this.groupAbertura.Size = new System.Drawing.Size(776, 63);
            this.groupAbertura.TabIndex = 2;
            this.groupAbertura.TabStop = false;
            this.groupAbertura.Text = "Arquivos";
            // 
            // cboArquivos
            // 
            this.cboArquivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArquivos.FormattingEnabled = true;
            this.cboArquivos.Location = new System.Drawing.Point(6, 22);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Arquivos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupAbertura.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuArquivo;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem AbrirSubMenu;
        private DataGridView dataGridView1;
        private GroupBox groupAbertura;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem tXTToolStripMenuItem;
        private ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private ComboBox cboArquivos;
        private ToolStripMenuItem pastasToolStripMenuItem;
    }
}

namespace OrçamentosAPP
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuCadastrar = new System.Windows.Forms.Button();
            this.btnMenuConsultar = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMenuCadastrar);
            this.panel1.Controls.Add(this.btnMenuConsultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 674);
            this.panel1.TabIndex = 0;
            // 
            // btnMenuCadastrar
            // 
            this.btnMenuCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnMenuCadastrar.Image = global::OrçamentosAPP.Properties.Resources.iconMais1;
            this.btnMenuCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCadastrar.Location = new System.Drawing.Point(3, 173);
            this.btnMenuCadastrar.Name = "btnMenuCadastrar";
            this.btnMenuCadastrar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuCadastrar.Size = new System.Drawing.Size(205, 48);
            this.btnMenuCadastrar.TabIndex = 2;
            this.btnMenuCadastrar.Text = "  Novo Orçamento";
            this.btnMenuCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuCadastrar.UseVisualStyleBackColor = false;
            this.btnMenuCadastrar.Click += new System.EventHandler(this.btnMenuCadastrar_Click);
            // 
            // btnMenuConsultar
            // 
            this.btnMenuConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuConsultar.Image = global::OrçamentosAPP.Properties.Resources.iconLupa;
            this.btnMenuConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConsultar.Location = new System.Drawing.Point(3, 227);
            this.btnMenuConsultar.Name = "btnMenuConsultar";
            this.btnMenuConsultar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuConsultar.Size = new System.Drawing.Size(205, 48);
            this.btnMenuConsultar.TabIndex = 1;
            this.btnMenuConsultar.Text = "  Consultar Orçamentos";
            this.btnMenuConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuConsultar.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(217, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(827, 650);
            this.panelContent.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 674);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuCadastrar;
        private System.Windows.Forms.Button btnMenuConsultar;
        private System.Windows.Forms.Panel panelContent;
    }
}


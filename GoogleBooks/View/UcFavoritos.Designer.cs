namespace GoogleBooks.View
{
    partial class UcFavoritos
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fpnlFavoritos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meus Favoritos";
            // 
            // fpnlFavoritos
            // 
            this.fpnlFavoritos.AutoScroll = true;
            this.fpnlFavoritos.BackColor = System.Drawing.Color.Transparent;
            this.fpnlFavoritos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlFavoritos.Location = new System.Drawing.Point(0, 27);
            this.fpnlFavoritos.Name = "fpnlFavoritos";
            this.fpnlFavoritos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.fpnlFavoritos.Size = new System.Drawing.Size(331, 554);
            this.fpnlFavoritos.TabIndex = 1;
            // 
            // UcFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fpnlFavoritos);
            this.Controls.Add(this.label1);
            this.Name = "UcFavoritos";
            this.Size = new System.Drawing.Size(331, 581);
            this.Load += new System.EventHandler(this.UcFavoritos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnlFavoritos;
    }
}

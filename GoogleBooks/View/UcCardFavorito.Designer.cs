namespace GoogleBooks.View
{
    partial class UcCardFavorito
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
            this.thumbBook = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // thumbBook
            // 
            this.thumbBook.Location = new System.Drawing.Point(3, 3);
            this.thumbBook.Name = "thumbBook";
            this.thumbBook.Size = new System.Drawing.Size(85, 83);
            this.thumbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbBook.TabIndex = 0;
            this.thumbBook.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(95, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titulo";
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackgroundImage = global::GoogleBooks.Properties.Resources.star48px;
            this.btnFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Location = new System.Drawing.Point(275, 3);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(25, 23);
            this.btnFavorite.TabIndex = 2;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(98, 28);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(147, 53);
            this.txtDescription.TabIndex = 3;
            // 
            // UcCardFavorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.thumbBook);
            this.Name = "UcCardFavorito";
            this.Size = new System.Drawing.Size(303, 87);
            this.Load += new System.EventHandler(this.UcCardFavorito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thumbBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

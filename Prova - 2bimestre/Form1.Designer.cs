namespace Prova___2bimestre
{
    partial class Form1
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
            this.tx_serviço = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_serviço
            // 
            this.tx_serviço.Location = new System.Drawing.Point(108, 161);
            this.tx_serviço.Name = "tx_serviço";
            this.tx_serviço.Size = new System.Drawing.Size(210, 89);
            this.tx_serviço.TabIndex = 0;
            this.tx_serviço.Text = "Serviço";
            this.tx_serviço.UseVisualStyleBackColor = true;
            this.tx_serviço.Click += new System.EventHandler(this.tx_serviço_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.tx_serviço);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tx_serviço;
    }
}


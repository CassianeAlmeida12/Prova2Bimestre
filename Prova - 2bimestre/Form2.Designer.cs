namespace Prova___2bimestre
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_computador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_servico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_pagamento = new System.Windows.Forms.ComboBox();
            this.lb_valorfinal = new System.Windows.Forms.Label();
            this.tx_salvar = new System.Windows.Forms.Button();
            this.tx_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computador:";
            // 
            // tx_computador
            // 
            this.tx_computador.Location = new System.Drawing.Point(150, 54);
            this.tx_computador.Name = "tx_computador";
            this.tx_computador.Size = new System.Drawing.Size(100, 20);
            this.tx_computador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // tx_cliente
            // 
            this.tx_cliente.Location = new System.Drawing.Point(125, 105);
            this.tx_cliente.Name = "tx_cliente";
            this.tx_cliente.Size = new System.Drawing.Size(100, 20);
            this.tx_cliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serviço:";
            // 
            // box_servico
            // 
            this.box_servico.FormattingEnabled = true;
            this.box_servico.Items.AddRange(new object[] {
            "Formatação",
            "Limpeza",
            "Troca de peça"});
            this.box_servico.Location = new System.Drawing.Point(125, 158);
            this.box_servico.Name = "box_servico";
            this.box_servico.Size = new System.Drawing.Size(121, 21);
            this.box_servico.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de pagamento:";
            // 
            // box_pagamento
            // 
            this.box_pagamento.FormattingEnabled = true;
            this.box_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Cartão"});
            this.box_pagamento.Location = new System.Drawing.Point(186, 219);
            this.box_pagamento.Name = "box_pagamento";
            this.box_pagamento.Size = new System.Drawing.Size(121, 21);
            this.box_pagamento.TabIndex = 8;
            // 
            // lb_valorfinal
            // 
            this.lb_valorfinal.AutoSize = true;
            this.lb_valorfinal.Location = new System.Drawing.Point(85, 304);
            this.lb_valorfinal.Name = "lb_valorfinal";
            this.lb_valorfinal.Size = new System.Drawing.Size(56, 13);
            this.lb_valorfinal.TabIndex = 9;
            this.lb_valorfinal.Text = "Valor Final";
            // 
            // tx_salvar
            // 
            this.tx_salvar.Location = new System.Drawing.Point(69, 353);
            this.tx_salvar.Name = "tx_salvar";
            this.tx_salvar.Size = new System.Drawing.Size(75, 23);
            this.tx_salvar.TabIndex = 10;
            this.tx_salvar.Text = "salvar";
            this.tx_salvar.UseVisualStyleBackColor = true;
            this.tx_salvar.Click += new System.EventHandler(this.tx_salvar_Click);
            // 
            // tx_cancelar
            // 
            this.tx_cancelar.Location = new System.Drawing.Point(170, 352);
            this.tx_cancelar.Name = "tx_cancelar";
            this.tx_cancelar.Size = new System.Drawing.Size(75, 23);
            this.tx_cancelar.TabIndex = 11;
            this.tx_cancelar.Text = "cancelar";
            this.tx_cancelar.UseVisualStyleBackColor = true;
            this.tx_cancelar.Click += new System.EventHandler(this.tx_cancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_cancelar);
            this.Controls.Add(this.tx_salvar);
            this.Controls.Add(this.lb_valorfinal);
            this.Controls.Add(this.box_pagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_servico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_computador);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_computador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_servico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox box_pagamento;
        private System.Windows.Forms.Label lb_valorfinal;
        private System.Windows.Forms.Button tx_salvar;
        private System.Windows.Forms.Button tx_cancelar;
    }
}
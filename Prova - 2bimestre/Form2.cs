using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova___2bimestre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tx_cancelar_Click(object sender, EventArgs e)
        {
            tx_computador.Clear();
            tx_cliente.Clear();
            box_servico.ResetText();
            box_pagamento.ResetText();
            lb_valorfinal.ResetText();

        }

        private void tx_salvar_Click(object sender, EventArgs e)
        {
            double valorFi;
            double dinheiro = 0.2;
            double pix = 0.1;



            //PARA CALCULAR A FORMATAÇÃO
            if(box_servico.Text == "Formatação")
            {
                if(box_pagamento.Text == "Dinheiro")
                {
                    valorFi = 100 - (100 * dinheiro) ;
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
                else if(box_pagamento.Text == "Pix")
                    {
                        valorFi = 100 - (100 * pix);
                        lb_valorfinal.Text = "O valor Total é " + valorFi;
                    }
                else if (box_pagamento.Text == "Cartão")
                {
                    valorFi = 100;
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
            }




            //PARA CALCULAR A LIMPEZA
            if (box_servico.Text == "Limpeza")
            {
                if (box_pagamento.Text == "Dinheiro")
                {
                    valorFi = 50 - (50 * dinheiro);
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
                else if (box_pagamento.Text == "Pix")
                {
                    valorFi = 50 - (50 * pix);
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
                else if (box_pagamento.Text == "Cartão")
                {
                    valorFi = 50;
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
            }




            //PARA CALCULAR TROCA DE PEÇA
            if (box_servico.Text == "Troca de peça")
            {
                if (box_pagamento.Text == "Dinheiro")
                {
                    valorFi = 200 - (200 * dinheiro);
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
                else if (box_pagamento.Text == "Pix")
                {
                    valorFi = 200 - (200 * pix);
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
                else if (box_pagamento.Text == "Cartão")
                {
                    valorFi = 200;
                    lb_valorfinal.Text = "O valor Total é " + valorFi;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtValor1.Text);
            double precoUnitario = Convert.ToDouble(txtValor2.Text);

            double desconto = 0.0;

            if (quantidade > 30)
                desconto = 0.15;
            else if (quantidade > 20)
                desconto = 0.10;
            else if (quantidade > 10)
                desconto = 0.05;

            double totalSemDesconto = quantidade * precoUnitario;
            double valorDesconto = totalSemDesconto * desconto;
            double totalComDesconto = totalSemDesconto - valorDesconto;

            lblResultado.Text = $"Porcentagem de desconto: {desconto * 100}%\n" +
                                  $"Valor do desconto: R${valorDesconto:F2}\n" +
                                  $"Total: R${totalComDesconto:F2}";
        }
    } //2 label com instruções, 1 button e 2 textbox
}

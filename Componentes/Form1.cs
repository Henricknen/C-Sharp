using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Principal : Form     // 'F_Principal' herda todas propriedades da classe 'Form'
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_botao_Click(object sender, EventArgs e)        // método para o evento de 'Click'
        {
            if(tb_veiculo.Text == "")       // se o 'textbox' não estiver prenchido será executado os passos seguintes
            {
                MessageBox.Show("Digite um veiculo");       // 'MessageBox.Show' emite uma menssagem
                tb_veiculo.Focus();     // método 'Focus' define o foco de entrada para o controle
                return;      // 'return para a execução do programa
            }

            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";        // adiçionando veiculo na 'tb_listaVeiculos' e '+=' adiçiona 'tb_listaVeiculos' com o valor do veiculo anterior

            tb_veiculo.Clear();     // apos adiçionar o 'tb_veiculo' será limpado
            tb_veiculo.Focus();         // 'Focus' posicionará o cursor em 'tb_veiculo'
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();       // limpa toda lista de veiculos
            tb_veiculo.Clear();
            tb_veiculo.Focus();

        }


    }
}

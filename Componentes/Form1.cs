using System;       // Formulario 'Pai'
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
        public int num;     // criação da variável 'num'
        public F_Principal()
        {
            InitializeComponent();
            num = 0;        // iniçializando variáve 'num' em 0
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

        private void btn_mostrar_Click(object sender, EventArgs e)      // método 'btn_mostrar_Click'
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculos.Text, this);      // declarando um objeto do tipo 'f_veiculos' da classe 'F_Veiculos' com o conteudo de 'tb_listaVeiculos' como argumento de entrada
            f_Veiculos.ShowDialog();        // 'ShowDialog' mostra o formuiario com uma caixa de dialogo 'modal' e 'ShowDialog' não permite ir para o formulario anterior
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)        // método 'checkboxToolStripMenuItem' assoçiado ao evento 'Click'
        {
            F_CheckBox f_CheckBox = new F_CheckBox();      // instanciando novo objeto da classe 'F_Checkbox' e abrindo o formulario 'F_Checkbox'
            f_CheckBox.ShowDialog();        // chamando método 'ShowDialog'
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckListBox f_CheckListBox = new F_CheckListBox();
            f_CheckListBox.ShowDialog();
        }
    }
}

using System;       // as cinzas escuras é que estão sendo ultilizadas
using System.Collections.Generic;
using System.ComponentModel;        // importação de uma serie de bibliotecas
using System.Data;
using System.Drawing;       // as cinza claras no momento não está sendo ultiizadas
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_no_padrao_Windows_Forms      // 'namespace' é o nome da solução e tudo relaçionado a está solução será adiçionado neste 'namespace'
{
    public partial class Formulario : Form       //riação classe 'Formulario' que herda 'Form' que é a base
    {
        public Formulario()     // construtor da classe tem que ter o mesmo nome da classe e será executado quando o objeto da classe estiver rodadando
        {
            InitializeComponent();      // método 'InitializeComponent' faz a iniçialização dos componentes do 'Form'
        }

        private void button_Click(object sender, EventArgs e)       // evento
        {
            lb_texto.Text = tb_texto.Text;   // 'lb_texto' recebe  o 'Text' texto de 'tb_texto
        }

        private void lb_texto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




    }
}

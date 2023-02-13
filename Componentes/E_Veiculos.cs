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
    public partial class F_Veiculos : Form
    {
        public F_Veiculos(String v)     // construtor 'F_Veiculos' com um argumento de entrada chamado 'v' do tipo 'string'
        {
            InitializeComponent();

            tb_listaVeiculos.Text = v;      // 'tb_listaVeiculos' recebe o valor do argumento de entrada 'v'
        }

        private void F_Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        F_Principal fp;         // do tipo 'F_Principal' será criado objeto 'fp'
        public F_Veiculos(String v, F_Principal f)     // construtor 'F_Veiculos' com um argumentos de entrada chamado 'v' do tipo 'string' e 'F_Principal f'
        {
            InitializeComponent();

            tb_listaVeiculos.Text = v;      // 'tb_listaVeiculos' recebe o valor do argumento de entrada 'v'

            fp = f;
            f.num = 10;

        }

        private void F_Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}

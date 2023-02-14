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
    public partial class F_CheckListBox : Form
    {
        public F_CheckListBox()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_transpotesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";        // string 'txt' vazia
            if (cb_carro.Checked)       // com 'Checked' da para verifincar se componente está maracado ou desmacardo
            {
                txt += cb_carro.Text + ", ";
            }

            if (cb_aviao.Checked)
            {
                txt += cb_carro.Text + ", ";
            }

            if (cb_navio.Checked)
            {
                txt += cb_carro.Text + ", ";
            }

            if (cb_navio.Checked)
            {
                txt += cb_carro.Text + ", ";
            }

            MessageBox.Show(txt);      // mostrando 'caixa de texto'
        }
    }
}

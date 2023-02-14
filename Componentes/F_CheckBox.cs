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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();      // criação de 'lista' de CheckBox
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);       // adiçionando os elementos
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_transsporte_marcados_Click(object sender, EventArgs e)
        {
            string txt = "";        // dtring 'txt' vazia
            
            foreach (CheckBox t in transp)      // loop 'foreach' vai pegar elemento por elemento da lista 'transp' e adiçionar em 't'
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);      // criando 'caixa de texto' para mostrar
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)        // se 'patinete' estiver marcado será exibido a menssagem abaixo
            {
                MessageBox.Show("Patinete marcado");
            }
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {
            F_filhoCheckBox f_FilhoCheckBox = new F_filhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Fluxo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblFolhaDePagamento_Click(object sender, EventArgs e)
        {

        }

        private void cbbClubeDeLazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbClubeDeLazer.Text)

            {
                case "ClubeA":
                    vSalario = vSalario - 100;
                    break;
                case "ClubeB":
                    vSalario = vSalario - 50;
                    break;
                case "ClubeC":
                    vSalario = vSalario - 10;
                    break;
                default:
                    break;
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdbPlanoDeSaude.Checked)
            {
                txtSalario.Enabled = true;
                txtSalario.Focus();
            }
        }

        private void txtSalarioFolha_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                {
                txtSalarioFolha.Text = txtSalario.Text;
            }
        }

        private void S(object sender, EventArgs e)
        {

        }

        private void txtImpostoRenda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

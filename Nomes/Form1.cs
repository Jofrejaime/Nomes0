using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomes
{
    public partial class Nomes : Form
    {
        Operacoes op = new Operacoes();

        public Nomes()
        {
            InitializeComponent();
        }

        private void Nomes_Load(object sender, EventArgs e)
        {
            op.apresentar(dataGrid);
            op.contar(lbconta);
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            op.add(dataGrid, txtNome);
            op.contar(lbconta);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            op.actualizar(dataGrid, ID, txtNome);
            op.contar(lbconta);
        }

        private void btnAppagar_Click(object sender, EventArgs e)
        {
            op.remover(ID, dataGrid);
            op.contar(lbconta);
        }
    }
}

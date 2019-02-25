using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilidadeDigital
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnBusca_click(object sender, EventArgs e)
        {

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            ImportaTxt importa = new ImportaTxt();
            this.Hide();
            importa.ShowDialog();
            this.Show();
        }
    }
}

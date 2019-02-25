using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilidadeDigital
{
    public partial class ImportaTxt : Form
    {
        string file;
        public ImportaTxt()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //ofdarquivo.filter = "text|*.txt|all|*.*";
            DialogResult result = ofdArquivo.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                this.file = ofdArquivo.FileName;
                lblArquivoSelecionado.Text = this.file;
            }
        }

        private void btnGeraRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void ImportaTxt_Leave(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

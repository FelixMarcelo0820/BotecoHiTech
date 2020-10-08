using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotecoHitech.lib.Views.Fornecedor
{
    public partial class FrmExibeF : Form
    {
        public FrmExibeF()
        {
            InitializeComponent();
        }

        private void FrmExibeP_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetFornecedor.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dataSetFornecedor.Fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}

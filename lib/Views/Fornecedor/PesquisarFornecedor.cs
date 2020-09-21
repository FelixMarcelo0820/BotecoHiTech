using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BotecoHitech
{
    public partial class PesquisarFornecedor : Form
    {
        public PesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

                SqlDataAdapter comando = new SqlDataAdapter("Select * from Fornecedor where nome Like '%" + txtPesquisa.Text + "%'", cone);

                DataTable tabela = new DataTable();

                comando.Fill(tabela);

                tabela.Columns[0].ColumnName = "ID";

                tabela.Columns[1].ColumnName = "nome";

                tabela.Columns[2].ColumnName = "CNPJ";

                tabela.Columns[3].ColumnName = "Endereco";

                tabela.Columns[4].ColumnName = "Tipo";

                tabela.Columns[5].ColumnName = "Telefone";

                
                dgvPesquisa.DataSource = tabela;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}

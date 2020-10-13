using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotecoHitech.lib.Views.Login_e_Tela_principal
{
    public partial class ExibeRelatUser : Form
    {
        public ExibeRelatUser()
        {
            InitializeComponent();
        }

        private void ExibeRelatUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetUser.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.dataSetUser.Usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}

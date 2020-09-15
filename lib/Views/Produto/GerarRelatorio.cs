using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BotecoHitech.lib.Views.Produto
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void GerarRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'butecoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.butecoDataSet.Produto);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog bm = new PrintDialog();
            bm.Document = printDocument1;
            bm.UseEXDialog = true;
            DialogResult bmResult = bm.ShowDialog();

            if(bmResult == DialogResult.OK)
            {

                printDocument1.DocumentName = "AAAAAAAAAA";
                printDocument1.Print();

            }

           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height)) ;
            e.Graphics.DrawImage(bm,10,10);

            


        }
    }
}

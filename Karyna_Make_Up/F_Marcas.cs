using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karyna_Make_Up
{
    public partial class F_Marcas : Form
    {

        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_MARCASTableAdapter tb_marcas = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_MARCASTableAdapter();
        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_PRODUTOSTableAdapter tb_produtos = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_PRODUTOSTableAdapter();
        epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter tb_marcas = new epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter();
        epraja_projectDataSetTableAdapters.TB_PRODUTOSTableAdapter tb_produtos = new epraja_projectDataSetTableAdapters.TB_PRODUTOSTableAdapter();

        Marcas marca = new Marcas();
        SQLExceptions sqlexceptions = new SQLExceptions();

        //Abre a conexão com o banco de dados
        SqlConnection projetos = new SqlConnection(@"Data Source=tcp:eprajaproject.database.windows.net,1433;Initial Catalog=epraja_project;Integrated Security=False;Persist Security Info=False;User ID=washington.filho;Password=vDcCAgDb2104?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd = new SqlCommand();
        private int currentRow = 0;
        public F_Marcas()
        {
            InitializeComponent();
        }

        private void F_Marcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'epraja_projectDataSet.TB_MARCAS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_MARCASTableAdapter1.Fill(this.epraja_projectDataSet.TB_MARCAS);
            // TODO: esta linha de código carrega dados na tabela 'pROJETOSDataSet.TB_MARCAS'. Você pode movê-la ou removê-la conforme necessário.
            //this.tB_MARCASTableAdapter.Fill(this.pROJETOSDataSet.TB_MARCAS);

        }

        private void btn_cadMarca_Click(object sender, EventArgs e)
        {
            marca.setMarca(this.txt_Marca.Text);
            tb_marcas.InsertMarca(marca.getMarca());
            this.tB_MARCASTableAdapter1.Fill(this.epraja_projectDataSet.TB_MARCAS);
            this.Refresh();
        }

        private void btn_DelMarca_Click_1(object sender, EventArgs e)
        {
            string rowId = TbMarcas_DataGrid[0, currentRow].Value.ToString();
            tb_marcas.DeleteMarca(int.Parse(rowId));
            this.tB_MARCASTableAdapter1.Fill(this.epraja_projectDataSet.TB_MARCAS);
            this.Refresh();

        }




        private void TbMarcas_DataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = int.Parse(e.RowIndex.ToString());
        }

        private void F_Marcas_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_Produtos f_produtos = new F_Produtos();

            f_produtos.Show();
        }

        private void txt_Marca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

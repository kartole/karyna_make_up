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
    public partial class F_Produtos : Form
    {

        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_PRODUTOSTableAdapter tb_produtos = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_PRODUTOSTableAdapter();
        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_MARCASTableAdapter tb_marcas = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_MARCASTableAdapter();
        epraja_projectDataSetTableAdapters.TB_PRODUTOSTableAdapter tb_produtos = new epraja_projectDataSetTableAdapters.TB_PRODUTOSTableAdapter();
        epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter tb_marcas = new epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter();

        Produtos produto = new Produtos();
        Marcas marca = new Marcas();
        SQLExceptions sqlexceptions = new SQLExceptions();

        //Abre a conexão com o banco de dados
        SqlConnection projetos = new SqlConnection(@"Data Source=tcp:eprajaproject.database.windows.net,1433;Initial Catalog=epraja_project;Integrated Security=False;Persist Security Info=False;User ID=washington.filho;Password=vDcCAgDb2104?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand cmd = new SqlCommand();
        private int currentRow = 0;
        public F_Produtos()
        {
            InitializeComponent();
        }

        public void F_Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'epraja_projectDataSet.TB_MARCAS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_MARCASTableAdapter.Fill(this.epraja_projectDataSet.TB_MARCAS);
            // TODO: esta linha de código carrega dados na tabela 'epraja_projectDataSet.TB_PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOSTableAdapter1.Fill(this.epraja_projectDataSet.TB_PRODUTOS);

            string marcasList;

            // TODO: esta linha de código carrega dados na tabela 'pROJETOSDataSet.TB_PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOSTableAdapter.Fill(this.pROJETOSDataSet.TB_PRODUTOS);

            cmd.CommandText = "SELECT NO_MARCA FROM TB_MARCAS ORDER BY NO_MARCA ASC";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = projetos;
            try
            {
                projetos.Open();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlDataReader dr = null;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                marcasList = dr["NO_MARCA"].ToString();
                cbx_Marca.Items.Add(marcasList);
            }
            projetos.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.txt_Produto.Enabled = true;
            this.cbx_Marca.Enabled = true;
            this.txt_Qtde.Enabled = true;
            this.btn_Salvar.Enabled = true;
            this.btn_QtdeAdd.Enabled = true;
            this.btn_QtdeSub.Enabled = true;
            this.btn_Cancelar.Enabled = true;

        }



        private void TbProdutos_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = int.Parse(e.RowIndex.ToString());

            int rowId = int.Parse(TbProdutos_DataGrid[0, currentRow].Value.ToString());
            produto.setIdProduto(rowId);
            txt_Produto.Text = TbProdutos_DataGrid[1, currentRow].Value.ToString();
            cbx_Marca.Text = TbProdutos_DataGrid[2, currentRow].Value.ToString();
            txt_Qtde.Text = TbProdutos_DataGrid[3, currentRow].Value.ToString();


        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            marca.setMarca(cbx_Marca.Text);

            cmd.CommandText = "SELECT ID_MARCA FROM TB_MARCAS WHERE NO_MARCA='" + marca.getMarca()+"'";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = projetos;

            

            projetos.Open();
            object idMarca = cmd.ExecuteScalar();
            projetos.Close();

            produto.setProduto(txt_Produto.Text);
            produto.setQtde(int.Parse(txt_Qtde.Text));
            marca.setMarca(cbx_Marca.Text);

            tb_produtos.UpdateProduto(produto.getProduto(), 
                                      produto.getQtde(),
                                      Convert.ToInt32(idMarca),
                                      produto.getIdProduto()
                                      );

            clearContents();

            this.txt_Produto.Enabled = false;
            this.cbx_Marca.Enabled = false;
            this.txt_Qtde.Enabled = false;
            this.btn_Salvar.Enabled = false;

            tb_produtos.Fill(this.epraja_projectDataSet.TB_PRODUTOS);
            //tb_produtos.Fill(this.pROJETOSDataSet.TB_PRODUTOS);
            this.Refresh();

        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            //Mostra ícone de erro se o usuário não preencher campos obrigatórios
            if (txt_Produto.Text == "")
            {
                MessageBox.Show("O campo PRODUTO é obrigatório!");
                return;
            }

            if (cbx_Marca.Text == "")
            {
                MessageBox.Show("O campo MARCA é obrigatório!");
                return;
            }

            if (txt_Qtde.Text == "")
            {
                MessageBox.Show("O campo QTDE (Quantidade) é obrigatório!");
                return;
            }


            produto.setProduto(txt_Produto.Text);            
            produto.setQtde(int.Parse(txt_Qtde.Text));
            marca.setMarca(cbx_Marca.Text);

           /* SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@MARCA";

            parameter.SqlDbType = SqlDbType.NVarChar;

            parameter.Direction = ParameterDirection.Input;

            parameter.Value = marca.getMarca();*/

            

            cmd.CommandText = "SELECT TOP 1 ID_MARCA FROM TB_MARCAS WHERE NO_MARCA = '" + marca.getMarca() + "' ORDER BY ID_MARCA DESC";
            //cmd.CommandText = "SELECT TOP 1 ID_MARCA FROM TB_MARCAS WHERE NO_MARCA = '@MARCA' ORDER BY ID_MARCA DESC";
            //cmd.Parameters.Add(parameter);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = projetos;



            projetos.Open();
            object idMarca = cmd.ExecuteScalar();
            projetos.Close();

            
            tb_produtos.InsertProduto(Convert.ToInt32(idMarca), 
                                        produto.getProduto(),                                 
                                        produto.getQtde());

            /*tb_produtos.InsertProduto(marca.getIdMarca(),
                                        produto.getProduto(),
                                        produto.getQtde());*/

            tb_produtos.Fill(this.epraja_projectDataSet.TB_PRODUTOS);
            //tb_produtos.Fill(this.pROJETOSDataSet.TB_PRODUTOS);

            clearContents();

            this.Refresh();
        }

        private void clearContents()
        {
            cbx_Marca.Text = null;
            txt_Produto.Clear();
            txt_Qtde.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Marcas f_marcas = new F_Marcas();

            f_marcas.Show();

            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Qtde.Text == ""){
                txt_Qtde.Text = "0";
            }
            else
            {
                int qtde = int.Parse(txt_Qtde.Text) + 1;
                txt_Qtde.Text = Convert.ToString(qtde);
            }
            

        }

        private void btn_QtdeSub_Click(object sender, EventArgs e)
        {
            if (txt_Qtde.Text == "" || txt_Qtde.Text == "0")
            {
                txt_Qtde.Text = "0";
            }
            else
            {
                int qtde = int.Parse(txt_Qtde.Text) - 1;
                txt_Qtde.Text = Convert.ToString(qtde);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            clearContents();

            txt_Produto.Enabled = false;
            txt_Qtde.Enabled = false;
            cbx_Marca.Enabled = false;
            btn_QtdeAdd.Enabled = false;
            btn_QtdeSub.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Cancelar.Enabled = false;

        }

        private void TbProdutos_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Voltar_Cliente_Click(object sender, EventArgs e)
        {
            F_Menu f_menu = new F_Menu();

            f_menu.Show();

            this.Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            string rowId = TbProdutos_DataGrid[0, currentRow].Value.ToString();
            tb_produtos.DeleteProduto(int.Parse(rowId));
            tb_produtos.Fill(this.epraja_projectDataSet.TB_PRODUTOS);
            //this.tB_PRODUTOSTableAdapter1.Fill(this.pROJETOSDataSet.TB_PRODUTOS);            
            this.Refresh();
        }
    }
}

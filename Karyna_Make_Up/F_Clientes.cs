using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Karyna_Make_Up
{
    public partial class F_Clientes : Form
    {
        //Abre as instancias do DataSet do banco de dados das entidades CLIENTES, ENDERECO e TELEFONE
        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_CLIENTESTableAdapter tb_cliente = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_CLIENTESTableAdapter();
        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_TELEFONETableAdapter tb_telefone = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_TELEFONETableAdapter();
        //PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_ENDERECOTableAdapter tb_endereco = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_ENDERECOTableAdapter();

        epraja_projectDataSetTableAdapters.TB_CLIENTESTableAdapter tb_cliente = new epraja_projectDataSetTableAdapters.TB_CLIENTESTableAdapter();
        epraja_projectDataSetTableAdapters.TB_TELEFONETableAdapter tb_telefone = new epraja_projectDataSetTableAdapters.TB_TELEFONETableAdapter();
        epraja_projectDataSetTableAdapters.TB_ENDERECOTableAdapter tb_endereco = new epraja_projectDataSetTableAdapters.TB_ENDERECOTableAdapter();
           

       
        Clientes cliente = new Clientes();
        Endereco endereco = new Endereco();

        //Abre a conexão com o banco de dados
        //SqlConnection projetos = new SqlConnection(@"Data Source=DESKTOP-1EKSR5E\PROJETOS;Initial Catalog=PROJETOS;Integrated Security=True");
        SqlConnection projetos = new SqlConnection(@"Data Source=tcp:eprajaproject.database.windows.net,1433;Initial Catalog=epraja_project;Integrated Security=False;Persist Security Info=False;User ID=washington.filho;Password=vDcCAgDb2104?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand cmd = new SqlCommand();

        
        

        private int currentRow = 0;        

        public F_Clientes()
        {
            
            //projetos.ConnectionString = "Server=tcp:eprajaproject.database.windows.net,1433;Initial Catalog=epraja_project;Persist Security Info=False;User ID=washington.filho;Password=vDcCAgDb2104?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            InitializeComponent();
        }

        /*private void F_Clientes_Load(object sender, EventArgs e) =>
            // TODO: esta linha de código carrega dados na tabela 'pROJETOSDataSet.TB_CLIENTES'.

            this.tB_CLIENTESTableAdapter2.Fill(this.epraja_projectDataSet.TB_CLIENTES);
            //this.tB_CLIENTESTableAdapter.Fill(this.pROJETOSDataSet.TB_CLIENTES);*/
        

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Mostra ícone de erro se o usuário não preencher campos obrigatórios
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("O nome deve ser preenchido!");
                return;
            }
                
            if (txt_CPF.Text == "")
            {
                MessageBox.Show("O CPF é um campo obrigatório!");
                return;
            }
                
            if (txt_Sexo.Text == "")
            {
                MessageBox.Show("Informe o sexo!");
                return;
            }

            

            cliente.setNome(txt_Nome.Text);
            cliente.setCPF(txt_CPF.Text);
            cliente.setNasc(txt_Nasc.Text);
            cliente.setSexo(txt_Sexo.Text);
            cliente.setEmail(txt_Email.Text);




            try
            {
                
                tb_cliente.InsertCliente( cliente.getCPF(), 
                                            cliente.getNome(), 
                                            cliente.getNasc(), 
                                            cliente.getSexo(),
                                            cliente.getEmail()
                                          );
            }

            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return;
            }
            
            
            
            cmd.CommandText = "SELECT TOP 1 ID_CLIENTE FROM TB_CLIENTES ORDER BY ID_CLIENTE DESC";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = projetos;

            

            projetos.Open();
            object idCadastro = cmd.ExecuteScalar();          
            projetos.Close();


            tb_telefone.InsertTelefone(txt_Telefone.Text, 
                                       Convert.ToInt32(idCadastro));

            tb_endereco.InsertEndereco( txt_Rua.Text, 
                                        int.Parse(txt_Numero.Text), 
                                        txt_Compl.Text, 
                                        txt_Bairro.Text, 
                                        txt_Cidade.Text, 
                                        txt_UF.Text, 
                                        Convert.ToInt32(idCadastro));

            tb_cliente.getClientes();

            this.tB_CLIENTESTableAdapter2.Fill(this.epraja_projectDataSet.TB_CLIENTES);

            txt_Nome.Clear();
            txt_CPF.Clear();
            txt_Nasc.Clear();
            txt_Sexo.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            txt_Rua.Clear();
            txt_Numero.Clear();
            txt_Compl.Clear();
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            txt_UF.Clear();

            this.Refresh();

            
        }

        private void F_Clientes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'epraja_projectDataSet.TB_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.          
            this.tB_CLIENTESTableAdapter2.Fill(this.epraja_projectDataSet.TB_CLIENTES);                       
            //tb_cliente.Fill(this.epraja_projectDataSet.TB_CLIENTES);
            
        }

        private void TbClientes_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          currentRow = int.Parse(e.RowIndex.ToString());

        }
        private void btn_filtrar_Click(object sender, EventArgs e)
        {


            string rowId = TbClientes_DataGrid[0, currentRow].Value.ToString();

            //Instancia um vetor para guardar os nomes das tabelas a terem registros deletados
            string[] delete = new string[3];

            delete[0] = "TB_ENDERECO";
            delete[1] = "TB_TELEFONE";
            delete[2] = "TB_CLIENTES";

            projetos.Open();

            //Deleta os registros do cliente em todas as tabelas em ordem para manter a integridade referencial das constraints
            for (int i = 0; i < 3; i++)
            {
                cmd.CommandText = "DELETE FROM " + delete[i] + " WHERE ID_CLIENTE=" + int.Parse(rowId.ToString());

                

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = projetos;

                
                cmd.ExecuteNonQuery();
                
            }

            projetos.Close();

            delete = null;


            tb_cliente.getClientes();

            tb_cliente.Fill(this.epraja_projectDataSet.TB_CLIENTES);
           

            this.Refresh();
            

        }

        private static void DisplaySqlErrors(SqlException exception)
        {

            if (exception.Number == 2627)
            {
                MessageBox.Show("O CPF informado já está cadastrado!!!");                
                return;
            }
          
        }

        private void txt_Nome_Validating(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            if(txt_Nome.Text.Trim().Length == 0)
            {               
                errorProvider_Nome.SetError(txt_Nome, "O nome deve ser informado!");
            }
            else
            {
                errorProvider_Nome.SetError(txt_Nome,"");
            }
        }

        private void txt_CPF_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txt_CPF.Text.Trim().Length == 0)
            {
                errorProvider_Nome.SetError(txt_CPF, "O CPF deve ser informado!");
            }
            else
            {
                errorProvider_Nome.SetError(txt_CPF, "");
            }
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            //Permite que apenas letras do alfabeto sejam digitadas no campo NOME;
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))

            {
                
                e.Handled = true;

            }
        }




        private void txt_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Permite que apenas números sejam digitados no campo CPF
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))

            {

                e.Handled = true;

            }
        }

        private void CONTATO_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {

            //Atribui os valores do registro selecionado aos objetos da classe Cliente
            cliente.setRowId(int.Parse(TbClientes_DataGrid[0, currentRow].Value.ToString()));
            cliente.setNome(TbClientes_DataGrid[1, currentRow].Value.ToString());
            cliente.setCPF(TbClientes_DataGrid[2, currentRow].Value.ToString());
            cliente.setNasc(TbClientes_DataGrid[3, currentRow].Value.ToString());
            cliente.setSexo(TbClientes_DataGrid[4, currentRow].Value.ToString());
            cliente.setEmail(TbClientes_DataGrid[5, currentRow].Value.ToString());
            cliente.setTelefone(TbClientes_DataGrid[6, currentRow].Value.ToString());

            //Atribui os endereços separados por tipo (Rua, Numero, Bairro, Complemento...) aos seus respectivos objetos da classe Endereco
            endereco.setEndereco(TbClientes_DataGrid[7, currentRow].Value.ToString().Split(','));
            endereco.setEndereco2(endereco.getEndereco2().ToString().Split('-'));
            endereco.setEndereco3(endereco.getEndereco3().Split('('));

            //Atribui aos textBoxes os valores retornados para cada tipo de endereço
            txt_Nome.Text = cliente.getNome();
            txt_CPF.Text = cliente.getCPF();
            txt_Nasc.Text = cliente.getNasc();
            txt_Sexo.Text = cliente.getSexo();
            txt_Email.Text = cliente.getEmail();
            txt_Telefone.Text = cliente.getTelefone();
            txt_Rua.Text = endereco.getRua();
            txt_Numero.Text = endereco.getNum();
            txt_Compl.Text = endereco.getComp();
            txt_Bairro.Text = endereco.getBairro();
            txt_Cidade.Text = endereco.getCidade();
            txt_UF.Text = endereco.getUF().Substring(0, 2);

            //Libera o botão de salvar
            btn_Salvar.Enabled = true;

            this.Refresh();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            cliente.setNome(txt_Nome.Text);
            cliente.setCPF(txt_CPF.Text);
            cliente.setNasc(txt_Nasc.Text);
            cliente.setSexo(txt_Sexo.Text);
            endereco.setRua(txt_Rua.Text);
            endereco.setNum(txt_Numero.Text);
            endereco.setBairro(txt_Bairro.Text);
            endereco.setComp(txt_Compl.Text);
            endereco.setCidade(txt_Cidade.Text);
            endereco.setUF(txt_UF.Text);
            cliente.setTelefone(txt_Telefone.Text);
            cliente.setEmail(txt_Email.Text);

            
            tb_cliente.UpdateCliente(cliente.getNome(),
                                     cliente.getCPF(),
                                     cliente.getNasc(),
                                     cliente.getSexo(),
                                     cliente.getEmail(),
                                     cliente.getRowId(),
                                     endereco.getRua(),
                                     int.Parse(endereco.getNum()),
                                     endereco.getComp(),
                                     endereco.getBairro(),
                                     endereco.getCidade(),
                                     endereco.getUF(),
                                     cliente.getTelefone()                                     
                                     );

            tb_cliente.Fill(this.epraja_projectDataSet.TB_CLIENTES);

            txt_Nome.Clear();
            txt_CPF.Clear();
            txt_Nasc.Clear();
            txt_Sexo.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            txt_Rua.Clear();
            txt_Numero.Clear();
            txt_Compl.Clear();
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            txt_UF.Clear();

            MessageBox.Show("Dados alterados com sucesso!");

            this.Refresh();
        }

        private void btn_Voltar_Cliente_Click(object sender, EventArgs e)
        {
            F_Menu menu = new F_Menu();

            menu.Show();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nome.Clear();
            txt_CPF.Clear();
            txt_Nasc.Clear();
            txt_Sexo.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            txt_Rua.Clear();
            txt_Numero.Clear();
            txt_Compl.Clear();
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            txt_UF.Clear();

            this.Refresh();
        }
        
        private void txt_Compl_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || 
                char.IsDigit(e.KeyChar) || 
                char.IsControl(e.KeyChar) || 
                char.IsWhiteSpace(e.KeyChar)
                 )
               )
            {
                e.Handled = true;
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))

            {

                e.Handled = true;

            }
        }
    }
}

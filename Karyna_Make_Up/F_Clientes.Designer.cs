using System;
using System.Windows.Forms;

namespace Karyna_Make_Up
{
    partial class F_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Clientes));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Sexo = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nasc = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.TbClientes_DataGrid = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.epraja_projectDataSet = new Karyna_Make_Up.epraja_projectDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETOSDataSet1 = new PROJETOSDataSet.PROJETOSDataSet();
            this.errorProvider_Nome = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.ENDERECO = new System.Windows.Forms.Label();
            this.DADOS_CLIENTE = new System.Windows.Forms.Label();
            this.CONTATO = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_n = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tbl_telefone = new System.Windows.Forms.Label();
            this.txt_Compl = new System.Windows.Forms.TextBox();
            this.lbl_compl = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nasc = new System.Windows.Forms.MaskedTextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.tB_CLIENTESTableAdapter1 = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_CLIENTESTableAdapter();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Voltar_Cliente = new System.Windows.Forms.Button();
            this.tB_CLIENTESTableAdapter2 = new Karyna_Make_Up.epraja_projectDataSetTableAdapters.TB_CLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TbClientes_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epraja_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Nome)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_cadastrar.FlatAppearance.BorderSize = 7;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.LightPink;
            this.btn_cadastrar.Location = new System.Drawing.Point(76, 316);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(131, 61);
            this.btn_cadastrar.TabIndex = 12;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nome.ForeColor = System.Drawing.Color.Purple;
            this.txt_Nome.Location = new System.Drawing.Point(38, 75);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Nome.Size = new System.Drawing.Size(327, 13);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            this.txt_Nome.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Nome_Validating);
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Sexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Sexo.ForeColor = System.Drawing.Color.Purple;
            this.txt_Sexo.Location = new System.Drawing.Point(680, 76);
            this.txt_Sexo.MaxLength = 1;
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Size = new System.Drawing.Size(42, 13);
            this.txt_Sexo.TabIndex = 3;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Nome.Location = new System.Drawing.Point(38, 55);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(54, 17);
            this.lbl_Nome.TabIndex = 9;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.ForeColor = System.Drawing.Color.Purple;
            this.lbl_CPF.Location = new System.Drawing.Point(395, 55);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(42, 17);
            this.lbl_CPF.TabIndex = 10;
            this.lbl_CPF.Text = "CPF:";
            // 
            // lbl_Nasc
            // 
            this.lbl_Nasc.AutoSize = true;
            this.lbl_Nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nasc.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Nasc.Location = new System.Drawing.Point(541, 55);
            this.lbl_Nasc.Name = "lbl_Nasc";
            this.lbl_Nasc.Size = new System.Drawing.Size(97, 17);
            this.lbl_Nasc.TabIndex = 11;
            this.lbl_Nasc.Text = "Nascimento:";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Sexo.Location = new System.Drawing.Point(677, 57);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(48, 17);
            this.lbl_Sexo.TabIndex = 12;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_filtrar.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_filtrar.FlatAppearance.BorderSize = 7;
            this.btn_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.ForeColor = System.Drawing.Color.LightPink;
            this.btn_filtrar.Location = new System.Drawing.Point(736, 316);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(131, 61);
            this.btn_filtrar.TabIndex = 13;
            this.btn_filtrar.Text = "EXCLUIR";
            this.btn_filtrar.UseVisualStyleBackColor = false;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // TbClientes_DataGrid
            // 
            this.TbClientes_DataGrid.AllowUserToOrderColumns = true;
            this.TbClientes_DataGrid.AutoGenerateColumns = false;
            this.TbClientes_DataGrid.BackgroundColor = System.Drawing.Color.Pink;
            this.TbClientes_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbClientes_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.nOMEDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.nASCIMENTODataGridViewTextBoxColumn,
            this.sEXODataGridViewTextBoxColumn,
            this.EMAIL,
            this.TELEFONE,
            this.dataGridViewTextBoxColumn1});
            this.TbClientes_DataGrid.DataSource = this.bindingSource2;
            this.TbClientes_DataGrid.GridColor = System.Drawing.Color.Purple;
            this.TbClientes_DataGrid.Location = new System.Drawing.Point(-1, 409);
            this.TbClientes_DataGrid.Name = "TbClientes_DataGrid";
            this.TbClientes_DataGrid.ReadOnly = true;
            this.TbClientes_DataGrid.Size = new System.Drawing.Size(1060, 254);
            this.TbClientes_DataGrid.TabIndex = 14;
            this.TbClientes_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbClientes_DataGrid_CellClick);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.Frozen = true;
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Frozen = true;
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nASCIMENTODataGridViewTextBoxColumn
            // 
            this.nASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "NASCIMENTO";
            this.nASCIMENTODataGridViewTextBoxColumn.HeaderText = "NASCIMENTO";
            this.nASCIMENTODataGridViewTextBoxColumn.Name = "nASCIMENTODataGridViewTextBoxColumn";
            this.nASCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEXODataGridViewTextBoxColumn
            // 
            this.sEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO";
            this.sEXODataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.sEXODataGridViewTextBoxColumn.Name = "sEXODataGridViewTextBoxColumn";
            this.sEXODataGridViewTextBoxColumn.ReadOnly = true;
            this.sEXODataGridViewTextBoxColumn.Width = 50;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 150;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 300;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "TB_CLIENTES";
            this.bindingSource2.DataSource = this.epraja_projectDataSet;
            // 
            // epraja_projectDataSet
            // 
            this.epraja_projectDataSet.DataSetName = "epraja_projectDataSet";
            this.epraja_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TB_CLIENTES";
            this.bindingSource1.DataSource = this.pROJETOSDataSet1;
            // 
            // pROJETOSDataSet1
            // 
            this.pROJETOSDataSet1.DataSetName = "PROJETOSDataSet";
            this.pROJETOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider_Nome
            // 
            this.errorProvider_Nome.ContainerControl = this;
            // 
            // txt_Rua
            // 
            this.txt_Rua.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Rua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Rua.ForeColor = System.Drawing.Color.Purple;
            this.txt_Rua.Location = new System.Drawing.Point(38, 256);
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(260, 13);
            this.txt_Rua.TabIndex = 6;
            // 
            // txt_Numero
            // 
            this.txt_Numero.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Numero.ForeColor = System.Drawing.Color.Purple;
            this.txt_Numero.Location = new System.Drawing.Point(324, 256);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(42, 13);
            this.txt_Numero.TabIndex = 7;
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Bairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Bairro.ForeColor = System.Drawing.Color.Purple;
            this.txt_Bairro.Location = new System.Drawing.Point(587, 256);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(125, 13);
            this.txt_Bairro.TabIndex = 9;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cidade.ForeColor = System.Drawing.Color.Purple;
            this.txt_Cidade.Location = new System.Drawing.Point(736, 256);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(111, 13);
            this.txt_Cidade.TabIndex = 10;
            // 
            // txt_UF
            // 
            this.txt_UF.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_UF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_UF.ForeColor = System.Drawing.Color.Purple;
            this.txt_UF.Location = new System.Drawing.Point(873, 256);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(42, 13);
            this.txt_UF.TabIndex = 11;
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rua.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Rua.Location = new System.Drawing.Point(38, 236);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(42, 17);
            this.lbl_Rua.TabIndex = 21;
            this.lbl_Rua.Text = "Rua:";
            // 
            // ENDERECO
            // 
            this.ENDERECO.AutoSize = true;
            this.ENDERECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDERECO.ForeColor = System.Drawing.Color.Purple;
            this.ENDERECO.Location = new System.Drawing.Point(39, 195);
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.Size = new System.Drawing.Size(125, 24);
            this.ENDERECO.TabIndex = 22;
            this.ENDERECO.Text = "ENDEREÇO";
            // 
            // DADOS_CLIENTE
            // 
            this.DADOS_CLIENTE.AutoSize = true;
            this.DADOS_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DADOS_CLIENTE.ForeColor = System.Drawing.Color.Purple;
            this.DADOS_CLIENTE.Location = new System.Drawing.Point(36, 15);
            this.DADOS_CLIENTE.Name = "DADOS_CLIENTE";
            this.DADOS_CLIENTE.Size = new System.Drawing.Size(209, 24);
            this.DADOS_CLIENTE.TabIndex = 23;
            this.DADOS_CLIENTE.Text = "DADOS DO CLIENTE";
            // 
            // CONTATO
            // 
            this.CONTATO.AutoSize = true;
            this.CONTATO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTATO.ForeColor = System.Drawing.Color.Purple;
            this.CONTATO.Location = new System.Drawing.Point(36, 105);
            this.CONTATO.Name = "CONTATO";
            this.CONTATO.Size = new System.Drawing.Size(222, 24);
            this.CONTATO.TabIndex = 24;
            this.CONTATO.Text = "DADOS DE CONTATO";
            this.CONTATO.Click += new System.EventHandler(this.CONTATO_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_Email.ForeColor = System.Drawing.Color.Purple;
            this.txt_Email.Location = new System.Drawing.Point(38, 163);
            this.txt_Email.MaxLength = 100;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(249, 13);
            this.txt_Email.TabIndex = 4;
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n.ForeColor = System.Drawing.Color.Purple;
            this.lbl_n.Location = new System.Drawing.Point(321, 236);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(29, 17);
            this.lbl_n.TabIndex = 27;
            this.lbl_n.Text = "N.:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.ForeColor = System.Drawing.Color.Purple;
            this.lbl_bairro.Location = new System.Drawing.Point(587, 237);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(57, 17);
            this.lbl_bairro.TabIndex = 28;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.ForeColor = System.Drawing.Color.Purple;
            this.lbl_cidade.Location = new System.Drawing.Point(733, 237);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(63, 17);
            this.lbl_cidade.TabIndex = 29;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf.ForeColor = System.Drawing.Color.Purple;
            this.lbl_uf.Location = new System.Drawing.Point(870, 237);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(33, 17);
            this.lbl_uf.TabIndex = 30;
            this.lbl_uf.Text = "UF:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Purple;
            this.lbl_email.Location = new System.Drawing.Point(41, 143);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 17);
            this.lbl_email.TabIndex = 31;
            this.lbl_email.Text = "E-mail:";
            // 
            // tbl_telefone
            // 
            this.tbl_telefone.AutoSize = true;
            this.tbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_telefone.ForeColor = System.Drawing.Color.Purple;
            this.tbl_telefone.Location = new System.Drawing.Point(323, 143);
            this.tbl_telefone.Name = "tbl_telefone";
            this.tbl_telefone.Size = new System.Drawing.Size(77, 17);
            this.tbl_telefone.TabIndex = 32;
            this.tbl_telefone.Text = "Telefone:";
            // 
            // txt_Compl
            // 
            this.txt_Compl.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Compl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Compl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Compl.ForeColor = System.Drawing.Color.Purple;
            this.txt_Compl.Location = new System.Drawing.Point(385, 256);
            this.txt_Compl.Name = "txt_Compl";
            this.txt_Compl.Size = new System.Drawing.Size(174, 13);
            this.txt_Compl.TabIndex = 8;
            this.txt_Compl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Compl_KeyPress);
            // 
            // lbl_compl
            // 
            this.lbl_compl.AutoSize = true;
            this.lbl_compl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compl.ForeColor = System.Drawing.Color.Purple;
            this.lbl_compl.Location = new System.Drawing.Point(382, 236);
            this.lbl_compl.Name = "lbl_compl";
            this.lbl_compl.Size = new System.Drawing.Size(110, 17);
            this.lbl_compl.TabIndex = 34;
            this.lbl_compl.Text = "Complemento:";
            // 
            // txt_CPF
            // 
            this.txt_CPF.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_CPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CPF.ForeColor = System.Drawing.Color.Purple;
            this.txt_CPF.Location = new System.Drawing.Point(398, 75);
            this.txt_CPF.Mask = "###.###.###-##";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(100, 13);
            this.txt_CPF.TabIndex = 1;
            this.txt_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_Nasc
            // 
            this.txt_Nasc.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Nasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nasc.ForeColor = System.Drawing.Color.Purple;
            this.txt_Nasc.Location = new System.Drawing.Point(544, 76);
            this.txt_Nasc.Mask = "00/00/0000";
            this.txt_Nasc.Name = "txt_Nasc";
            this.txt_Nasc.Size = new System.Drawing.Size(100, 13);
            this.txt_Nasc.TabIndex = 2;
            this.txt_Nasc.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefone.ForeColor = System.Drawing.Color.Purple;
            this.txt_Telefone.Location = new System.Drawing.Point(326, 163);
            this.txt_Telefone.Mask = "(##) #####-####";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(100, 13);
            this.txt_Telefone.TabIndex = 5;
            this.txt_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // tB_CLIENTESTableAdapter1
            // 
            this.tB_CLIENTESTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Atualizar.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_Atualizar.FlatAppearance.BorderSize = 7;
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.LightPink;
            this.btn_Atualizar.Location = new System.Drawing.Point(255, 316);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(131, 61);
            this.btn_Atualizar.TabIndex = 35;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Salvar.BackgroundImage = global::Karyna_Make_Up.Properties.Resources.save_button;
            this.btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_Salvar.FlatAppearance.BorderSize = 7;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.LightPink;
            this.btn_Salvar.Location = new System.Drawing.Point(385, 316);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(32, 31);
            this.btn_Salvar.TabIndex = 36;
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Cancelar.BackgroundImage = global::Karyna_Make_Up.Properties.Resources.cancelar_button;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_Cancelar.FlatAppearance.BorderSize = 7;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.LightPink;
            this.btn_Cancelar.Location = new System.Drawing.Point(385, 344);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(32, 31);
            this.btn_Cancelar.TabIndex = 37;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 38;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar_Cliente
            // 
            this.btn_Voltar_Cliente.BackColor = System.Drawing.Color.Pink;
            this.btn_Voltar_Cliente.BackgroundImage = global::Karyna_Make_Up.Properties.Resources.back_button;
            this.btn_Voltar_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Voltar_Cliente.ForeColor = System.Drawing.Color.Pink;
            this.btn_Voltar_Cliente.Location = new System.Drawing.Point(874, 35);
            this.btn_Voltar_Cliente.Name = "btn_Voltar_Cliente";
            this.btn_Voltar_Cliente.Size = new System.Drawing.Size(41, 39);
            this.btn_Voltar_Cliente.TabIndex = 39;
            this.btn_Voltar_Cliente.UseVisualStyleBackColor = false;
            this.btn_Voltar_Cliente.Click += new System.EventHandler(this.btn_Voltar_Cliente_Click);
            // 
            // tB_CLIENTESTableAdapter2
            // 
            this.tB_CLIENTESTableAdapter2.ClearBeforeFill = true;
            // 
            // F_Clientes
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1058, 658);
            this.Controls.Add(this.btn_Voltar_Cliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Nasc);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.lbl_compl);
            this.Controls.Add(this.txt_Compl);
            this.Controls.Add(this.tbl_telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_uf);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.CONTATO);
            this.Controls.Add(this.DADOS_CLIENTE);
            this.Controls.Add(this.ENDERECO);
            this.Controls.Add(this.lbl_Rua);
            this.Controls.Add(this.txt_UF);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.txt_Rua);
            this.Controls.Add(this.TbClientes_DataGrid);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.lbl_Nasc);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_Sexo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.F_Clientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TbClientes_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epraja_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Nome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TbClientes_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PROJETOSDataSet.PROJETOSDataSet pROJETOSDataSet;
        private System.Windows.Forms.BindingSource tBCLIENTESBindingSource;
        private PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_CLIENTESTableAdapter tB_CLIENTESTableAdapter;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Sexo;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nasc;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.DataGridView TbClientes_DataGrid;
        private PROJETOSDataSet.PROJETOSDataSet pROJETOSDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_CLIENTESTableAdapter tB_CLIENTESTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider_Nome;
        private System.Windows.Forms.Label lbl_compl;
        private System.Windows.Forms.TextBox txt_Compl;
        private System.Windows.Forms.Label tbl_telefone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label CONTATO;
        private System.Windows.Forms.Label DADOS_CLIENTE;
        private System.Windows.Forms.Label ENDERECO;
        private System.Windows.Forms.Label lbl_Rua;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Rua;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox txt_Nasc;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Voltar_Cliente;
        private epraja_projectDataSet epraja_projectDataSet;
        private BindingSource bindingSource2;
        private epraja_projectDataSetTableAdapters.TB_CLIENTESTableAdapter tB_CLIENTESTableAdapter2;
    }
}
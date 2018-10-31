namespace Karyna_Make_Up
{
    partial class F_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Produtos));
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.txt_Qtde = new System.Windows.Forms.TextBox();
            this.btn_QtdeAdd = new System.Windows.Forms.Button();
            this.btn_QtdeSub = new System.Windows.Forms.Button();
            this.TbProdutos_DataGrid = new System.Windows.Forms.DataGridView();
            this.iDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBPRODUTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eprajaprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epraja_projectDataSet = new Karyna_Make_Up.epraja_projectDataSet();
            this.tBPRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETOSDataSet = new PROJETOSDataSet.PROJETOSDataSet();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_cad = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.tB_PRODUTOSTableAdapter = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_PRODUTOSTableAdapter();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.tBMARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Voltar_Cliente = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.tB_PRODUTOSTableAdapter1 = new Karyna_Make_Up.epraja_projectDataSetTableAdapters.TB_PRODUTOSTableAdapter();
            this.tB_MARCASTableAdapter = new Karyna_Make_Up.epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TbProdutos_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprajaprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epraja_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMARCASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Produto
            // 
            this.txt_Produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Produto.Enabled = false;
            this.txt_Produto.Location = new System.Drawing.Point(135, 134);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(147, 20);
            this.txt_Produto.TabIndex = 0;
            // 
            // txt_Qtde
            // 
            this.txt_Qtde.Enabled = false;
            this.txt_Qtde.Location = new System.Drawing.Point(510, 135);
            this.txt_Qtde.Name = "txt_Qtde";
            this.txt_Qtde.Size = new System.Drawing.Size(27, 20);
            this.txt_Qtde.TabIndex = 2;
            // 
            // btn_QtdeAdd
            // 
            this.btn_QtdeAdd.Enabled = false;
            this.btn_QtdeAdd.Location = new System.Drawing.Point(559, 135);
            this.btn_QtdeAdd.Name = "btn_QtdeAdd";
            this.btn_QtdeAdd.Size = new System.Drawing.Size(23, 20);
            this.btn_QtdeAdd.TabIndex = 3;
            this.btn_QtdeAdd.Text = "+";
            this.btn_QtdeAdd.UseVisualStyleBackColor = true;
            this.btn_QtdeAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_QtdeSub
            // 
            this.btn_QtdeSub.Enabled = false;
            this.btn_QtdeSub.Location = new System.Drawing.Point(463, 135);
            this.btn_QtdeSub.Name = "btn_QtdeSub";
            this.btn_QtdeSub.Size = new System.Drawing.Size(23, 20);
            this.btn_QtdeSub.TabIndex = 4;
            this.btn_QtdeSub.Text = "-";
            this.btn_QtdeSub.UseVisualStyleBackColor = true;
            this.btn_QtdeSub.Click += new System.EventHandler(this.btn_QtdeSub_Click);
            // 
            // TbProdutos_DataGrid
            // 
            this.TbProdutos_DataGrid.AllowUserToOrderColumns = true;
            this.TbProdutos_DataGrid.AutoGenerateColumns = false;
            this.TbProdutos_DataGrid.BackgroundColor = System.Drawing.Color.Pink;
            this.TbProdutos_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbProdutos_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbProdutos_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTODataGridViewTextBoxColumn,
            this.nOPRODUTODataGridViewTextBoxColumn,
            this.NO_MARCA,
            this.QUANTIDADE,
            this.iDMARCADataGridViewTextBoxColumn});
            this.TbProdutos_DataGrid.DataSource = this.tBPRODUTOSBindingSource1;
            this.TbProdutos_DataGrid.Location = new System.Drawing.Point(135, 258);
            this.TbProdutos_DataGrid.Name = "TbProdutos_DataGrid";
            this.TbProdutos_DataGrid.Size = new System.Drawing.Size(447, 200);
            this.TbProdutos_DataGrid.TabIndex = 8;
            this.TbProdutos_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbProdutos_DataGrid_CellClick);
            this.TbProdutos_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbProdutos_DataGrid_CellContentClick);
            // 
            // iDPRODUTODataGridViewTextBoxColumn
            // 
            this.iDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.HeaderText = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.Name = "iDPRODUTODataGridViewTextBoxColumn";
            this.iDPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // nOPRODUTODataGridViewTextBoxColumn
            // 
            this.nOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NO_PRODUTO";
            this.nOPRODUTODataGridViewTextBoxColumn.HeaderText = "NO_PRODUTO";
            this.nOPRODUTODataGridViewTextBoxColumn.Name = "nOPRODUTODataGridViewTextBoxColumn";
            // 
            // NO_MARCA
            // 
            this.NO_MARCA.DataPropertyName = "NO_MARCA";
            this.NO_MARCA.HeaderText = "MARCA";
            this.NO_MARCA.Name = "NO_MARCA";
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // iDMARCADataGridViewTextBoxColumn
            // 
            this.iDMARCADataGridViewTextBoxColumn.DataPropertyName = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.HeaderText = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.Name = "iDMARCADataGridViewTextBoxColumn";
            this.iDMARCADataGridViewTextBoxColumn.Visible = false;
            // 
            // tBPRODUTOSBindingSource1
            // 
            this.tBPRODUTOSBindingSource1.DataMember = "TB_PRODUTOS";
            this.tBPRODUTOSBindingSource1.DataSource = this.eprajaprojectDataSetBindingSource;
            // 
            // eprajaprojectDataSetBindingSource
            // 
            this.eprajaprojectDataSetBindingSource.DataSource = this.epraja_projectDataSet;
            this.eprajaprojectDataSetBindingSource.Position = 0;
            // 
            // epraja_projectDataSet
            // 
            this.epraja_projectDataSet.DataSetName = "epraja_projectDataSet";
            this.epraja_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPRODUTOSBindingSource
            // 
            this.tBPRODUTOSBindingSource.DataMember = "TB_PRODUTOS";
            this.tBPRODUTOSBindingSource.DataSource = this.pROJETOSDataSet;
            // 
            // pROJETOSDataSet
            // 
            this.pROJETOSDataSet.DataSetName = "PROJETOSDataSet";
            this.pROJETOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Nome.Location = new System.Drawing.Point(132, 114);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(70, 17);
            this.lbl_Nome.TabIndex = 10;
            this.lbl_Nome.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(320, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(507, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Qtde";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_Edit.FlatAppearance.BorderSize = 7;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.LightPink;
            this.btn_Edit.Location = new System.Drawing.Point(135, 19);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(63, 30);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.Text = "EDITAR";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cad
            // 
            this.btn_cad.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_cad.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_cad.FlatAppearance.BorderSize = 7;
            this.btn_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad.ForeColor = System.Drawing.Color.LightPink;
            this.btn_cad.Location = new System.Drawing.Point(135, 189);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(92, 30);
            this.btn_cad.TabIndex = 14;
            this.btn_cad.Text = "CADASTRAR";
            this.btn_cad.UseVisualStyleBackColor = false;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
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
            this.btn_Salvar.Location = new System.Drawing.Point(512, 19);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(32, 30);
            this.btn_Salvar.TabIndex = 37;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(550, 19);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(32, 30);
            this.btn_Cancelar.TabIndex = 38;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // tB_PRODUTOSTableAdapter
            // 
            this.tB_PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.Enabled = false;
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Location = new System.Drawing.Point(323, 133);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(107, 21);
            this.cbx_Marca.TabIndex = 39;
            // 
            // tBMARCASBindingSource
            // 
            this.tBMARCASBindingSource.DataMember = "TB_MARCAS";
            this.tBMARCASBindingSource.DataSource = this.eprajaprojectDataSetBindingSource;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkMagenta;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.button3.FlatAppearance.BorderSize = 7;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightPink;
            this.button3.Location = new System.Drawing.Point(323, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 30);
            this.button3.TabIndex = 40;
            this.button3.Text = "CAD MARCAS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Voltar_Cliente
            // 
            this.btn_Voltar_Cliente.BackColor = System.Drawing.Color.Pink;
            this.btn_Voltar_Cliente.BackgroundImage = global::Karyna_Make_Up.Properties.Resources.back_button;
            this.btn_Voltar_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Voltar_Cliente.ForeColor = System.Drawing.Color.Pink;
            this.btn_Voltar_Cliente.Location = new System.Drawing.Point(672, 10);
            this.btn_Voltar_Cliente.Name = "btn_Voltar_Cliente";
            this.btn_Voltar_Cliente.Size = new System.Drawing.Size(41, 39);
            this.btn_Voltar_Cliente.TabIndex = 41;
            this.btn_Voltar_Cliente.UseVisualStyleBackColor = false;
            this.btn_Voltar_Cliente.Click += new System.EventHandler(this.btn_Voltar_Cliente_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Excluir.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_Excluir.FlatAppearance.BorderSize = 7;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.LightPink;
            this.btn_Excluir.Location = new System.Drawing.Point(253, 189);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(92, 30);
            this.btn_Excluir.TabIndex = 42;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // tB_PRODUTOSTableAdapter1
            // 
            this.tB_PRODUTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // tB_MARCASTableAdapter
            // 
            this.tB_MARCASTableAdapter.ClearBeforeFill = true;
            // 
            // F_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(740, 497);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Voltar_Cliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.TbProdutos_DataGrid);
            this.Controls.Add(this.btn_QtdeSub);
            this.Controls.Add(this.btn_QtdeAdd);
            this.Controls.Add(this.txt_Qtde);
            this.Controls.Add(this.txt_Produto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.F_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbProdutos_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprajaprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epraja_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMARCASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.TextBox txt_Qtde;
        private System.Windows.Forms.Button btn_QtdeAdd;
        private System.Windows.Forms.Button btn_QtdeSub;
        private System.Windows.Forms.DataGridView TbProdutos_DataGrid;
        private PROJETOSDataSet.PROJETOSDataSet pROJETOSDataSet;
        private System.Windows.Forms.BindingSource tBPRODUTOSBindingSource;
        private PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_PRODUTOSTableAdapter tB_PRODUTOSTableAdapter;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Voltar_Cliente;
        private System.Windows.Forms.Button btn_Excluir;
        private epraja_projectDataSet epraja_projectDataSet;
        private System.Windows.Forms.BindingSource eprajaprojectDataSetBindingSource;
        private System.Windows.Forms.BindingSource tBPRODUTOSBindingSource1;
        private epraja_projectDataSetTableAdapters.TB_PRODUTOSTableAdapter tB_PRODUTOSTableAdapter1;
        private System.Windows.Forms.BindingSource tBMARCASBindingSource;
        private epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter tB_MARCASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMARCADataGridViewTextBoxColumn;
    }
}
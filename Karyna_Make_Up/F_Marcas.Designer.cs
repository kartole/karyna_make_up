namespace Karyna_Make_Up
{
    partial class F_Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Marcas));
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.TbMarcas_DataGrid = new System.Windows.Forms.DataGridView();
            this.iDMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBMARCASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.epraja_projectDataSet = new Karyna_Make_Up.epraja_projectDataSet();
            this.tBMARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETOSDataSet = new PROJETOSDataSet.PROJETOSDataSet();
            this.tB_MARCASTableAdapter = new PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_MARCASTableAdapter();
            this.btn_cadMarca = new System.Windows.Forms.Button();
            this.btn_DelMarca = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.tB_MARCASTableAdapter1 = new Karyna_Make_Up.epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TbMarcas_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMARCASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epraja_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMARCASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Marca
            // 
            this.txt_Marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Marca.Location = new System.Drawing.Point(47, 40);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(145, 20);
            this.txt_Marca.TabIndex = 0;
            // 
            // TbMarcas_DataGrid
            // 
            this.TbMarcas_DataGrid.AllowUserToOrderColumns = true;
            this.TbMarcas_DataGrid.AutoGenerateColumns = false;
            this.TbMarcas_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbMarcas_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMARCADataGridViewTextBoxColumn,
            this.MARCA});
            this.TbMarcas_DataGrid.DataSource = this.tBMARCASBindingSource1;
            this.TbMarcas_DataGrid.Location = new System.Drawing.Point(-3, 180);
            this.TbMarcas_DataGrid.Name = "TbMarcas_DataGrid";
            this.TbMarcas_DataGrid.Size = new System.Drawing.Size(254, 155);
            this.TbMarcas_DataGrid.TabIndex = 3;
            this.TbMarcas_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbMarcas_DataGrid_CellClick_1);
            // 
            // iDMARCADataGridViewTextBoxColumn
            // 
            this.iDMARCADataGridViewTextBoxColumn.DataPropertyName = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.HeaderText = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.Name = "iDMARCADataGridViewTextBoxColumn";
            this.iDMARCADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMARCADataGridViewTextBoxColumn.Visible = false;
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "NO_MARCA";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.MaxInputLength = 100;
            this.MARCA.Name = "MARCA";
            // 
            // tBMARCASBindingSource1
            // 
            this.tBMARCASBindingSource1.DataMember = "TB_MARCAS";
            this.tBMARCASBindingSource1.DataSource = this.epraja_projectDataSet;
            // 
            // epraja_projectDataSet
            // 
            this.epraja_projectDataSet.DataSetName = "epraja_projectDataSet";
            this.epraja_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBMARCASBindingSource
            // 
            this.tBMARCASBindingSource.DataMember = "TB_MARCAS";
            this.tBMARCASBindingSource.DataSource = this.pROJETOSDataSet;
            // 
            // pROJETOSDataSet
            // 
            this.pROJETOSDataSet.DataSetName = "PROJETOSDataSet";
            this.pROJETOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_MARCASTableAdapter
            // 
            this.tB_MARCASTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cadMarca
            // 
            this.btn_cadMarca.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_cadMarca.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_cadMarca.FlatAppearance.BorderSize = 7;
            this.btn_cadMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadMarca.ForeColor = System.Drawing.Color.LightPink;
            this.btn_cadMarca.Location = new System.Drawing.Point(70, 87);
            this.btn_cadMarca.Name = "btn_cadMarca";
            this.btn_cadMarca.Size = new System.Drawing.Size(107, 30);
            this.btn_cadMarca.TabIndex = 41;
            this.btn_cadMarca.Text = "CADASTRAR";
            this.btn_cadMarca.UseVisualStyleBackColor = false;
            this.btn_cadMarca.Click += new System.EventHandler(this.btn_cadMarca_Click);
            // 
            // btn_DelMarca
            // 
            this.btn_DelMarca.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_DelMarca.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.btn_DelMarca.FlatAppearance.BorderSize = 7;
            this.btn_DelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelMarca.ForeColor = System.Drawing.Color.LightPink;
            this.btn_DelMarca.Location = new System.Drawing.Point(70, 132);
            this.btn_DelMarca.Name = "btn_DelMarca";
            this.btn_DelMarca.Size = new System.Drawing.Size(107, 30);
            this.btn_DelMarca.TabIndex = 42;
            this.btn_DelMarca.Text = "EXCLUIR";
            this.btn_DelMarca.UseVisualStyleBackColor = false;
            this.btn_DelMarca.Click += new System.EventHandler(this.btn_DelMarca_Click_1);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Nome.Location = new System.Drawing.Point(90, 20);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(57, 17);
            this.lbl_Nome.TabIndex = 43;
            this.lbl_Nome.Text = "Marca:";
            // 
            // tB_MARCASTableAdapter1
            // 
            this.tB_MARCASTableAdapter1.ClearBeforeFill = true;
            // 
            // F_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(246, 335);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_DelMarca);
            this.Controls.Add(this.btn_cadMarca);
            this.Controls.Add(this.TbMarcas_DataGrid);
            this.Controls.Add(this.txt_Marca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Marcas_FormClosed);
            this.Load += new System.EventHandler(this.F_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbMarcas_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMARCASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epraja_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMARCASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.DataGridView TbMarcas_DataGrid;
        private PROJETOSDataSet.PROJETOSDataSet pROJETOSDataSet;
        private System.Windows.Forms.BindingSource tBMARCASBindingSource;
        private PROJETOSDataSet.PROJETOSDataSetTableAdapters.TB_MARCASTableAdapter tB_MARCASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_cadMarca;
        private System.Windows.Forms.Button btn_DelMarca;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private epraja_projectDataSet epraja_projectDataSet;
        private System.Windows.Forms.BindingSource tBMARCASBindingSource1;
        private epraja_projectDataSetTableAdapters.TB_MARCASTableAdapter tB_MARCASTableAdapter1;
    }
}
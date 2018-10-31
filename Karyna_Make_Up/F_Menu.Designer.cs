namespace Karyna_Make_Up
{
    partial class F_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Menu));
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Produtos = new System.Windows.Forms.Button();
            this.btn_Agenda = new System.Windows.Forms.Button();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.ForeColor = System.Drawing.Color.Pink;
            this.btn_Clientes.Location = new System.Drawing.Point(41, 284);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(151, 37);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "CLIENTES";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Produtos
            // 
            this.btn_Produtos.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Produtos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produtos.ForeColor = System.Drawing.Color.Pink;
            this.btn_Produtos.Location = new System.Drawing.Point(41, 340);
            this.btn_Produtos.Name = "btn_Produtos";
            this.btn_Produtos.Size = new System.Drawing.Size(151, 37);
            this.btn_Produtos.TabIndex = 1;
            this.btn_Produtos.Text = "PRODUTOS";
            this.btn_Produtos.UseVisualStyleBackColor = false;
            this.btn_Produtos.Click += new System.EventHandler(this.btn_Produtos_Click);
            // 
            // btn_Agenda
            // 
            this.btn_Agenda.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_Agenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agenda.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agenda.ForeColor = System.Drawing.Color.Pink;
            this.btn_Agenda.Location = new System.Drawing.Point(41, 396);
            this.btn_Agenda.Name = "btn_Agenda";
            this.btn_Agenda.Size = new System.Drawing.Size(151, 37);
            this.btn_Agenda.TabIndex = 2;
            this.btn_Agenda.Text = "AGENDA";
            this.btn_Agenda.UseVisualStyleBackColor = false;
            this.btn_Agenda.Visible = false;
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.DarkMagenta;
            this.pn_Menu.Controls.Add(this.button1);
            this.pn_Menu.Controls.Add(this.btn_Clientes);
            this.pn_Menu.Controls.Add(this.btn_Agenda);
            this.pn_Menu.Controls.Add(this.btn_Produtos);
            this.pn_Menu.Location = new System.Drawing.Point(-2, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(25, 687);
            this.pn_Menu.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 26);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::Karyna_Make_Up.Properties.Resources.painel_principal;
            this.ClientSize = new System.Drawing.Size(1124, 685);
            this.Controls.Add(this.pn_Menu);
            this.ForeColor = System.Drawing.Color.Pink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            this.pn_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Produtos;
        private System.Windows.Forms.Button btn_Agenda;
        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Button button1;
    }
}


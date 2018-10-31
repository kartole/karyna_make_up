using System.Windows.Forms;

namespace Karyna_Make_Up
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void btn_Clientes_Click(object sender, System.EventArgs e)
        {
            F_Clientes f_clientes = new F_Clientes();

            f_clientes.Show();

            this.Visible = false;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (pn_Menu.Size == new System.Drawing.Size(237, 687))
            {
                pn_Menu.Size = new System.Drawing.Size(25, 687);
                return;
            }

            pn_Menu.MaximumSize = new System.Drawing.Size(300, 687);
                pn_Menu.Size = new System.Drawing.Size(237, 687);
            
        }

        private void btn_Produtos_Click(object sender, System.EventArgs e)
        {
            F_Produtos f_produtos = new F_Produtos();

            f_produtos.Show();

            this.Visible = false;
        }

        private void F_Menu_Load(object sender, System.EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karyna_Make_Up
{
    class SQLExceptions
    {

        public void DisplaySqlErrors(SqlException exception)
        {

            if (exception.Number == 2627)
            {
                MessageBox.Show("O CPF informado já está cadastrado!!!");
                return;
            }

        }
    }
}

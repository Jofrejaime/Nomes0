using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;
namespace Nomes
{
    
    class Operacoes
    {
       private MySqlCommand comando;
       private MySqlDataAdapter adaptador;
       private MySqlConnection conecter = new MySqlConnection("server=localhost; user=root; password=''; database=soma");
        
        public void apresentar(BunifuCustomDataGrid dt)
        {
            adaptador = new MySqlDataAdapter("SELECT*FROM nomes",conecter);
            DataTable table = new DataTable();
            table.Clear();
            adaptador.Fill(table);
            dt.DataSource = table;
        }

        public void add(BunifuCustomDataGrid dt, BunifuMaterialTextbox txt)
        {
            conecter.Open();
            comando = new MySqlCommand("insert into nomes(Nome) values(@nome)",conecter);
            comando.Parameters.Add("@nome", MySqlDbType.String).Value = txt.Text;
            comando.ExecuteNonQuery();
            conecter.Close();
            apresentar(dt);
        }

       public void remover(BunifuMaterialTextbox txt, BunifuCustomDataGrid dt)
        {
            int id = Convert.ToInt16(txt.Text);
            conecter.Open();
            comando = new MySqlCommand("delete from nomes where id = '"+id+"'",conecter);
            comando.ExecuteNonQuery();
            conecter.Close();
            apresentar(dt);
        }
        public void actualizar(BunifuCustomDataGrid dt, BunifuMaterialTextbox txt, BunifuMaterialTextbox txtnome)
        {
            int id = Convert.ToInt16(txt.Text);
            conecter.Open();
            comando = new MySqlCommand("update nomes set nome = @nome where id = '"+id+"'",conecter);
            comando.Parameters.Add("@nome", MySqlDbType.String).Value=txtnome.Text;
            comando.ExecuteNonQuery();
            conecter.Close();
            apresentar(dt);
            

        }
        public int contar(BunifuCustomLabel lb)
       {
           conecter.Open();
            comando = new MySqlCommand("Select COUNT(DISTINCT id) FROM nomes",conecter);
            int total = Convert.ToInt16(comando.ExecuteScalar());
            lb.Text = Convert.ToString(total);
            conecter.Close();
            return 1 ;
       }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Entities;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace DataAccess
{
    public class CD_Data
    {
        string cadenaConexion = "Server=localhost;User=root;Password=;Port=3306;database=concesionario_ford";

        public void Conexion() 
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            try
            {
                conexionBD.Open(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
                return;
            }
        }

        public void Create(CE_Entities cE)
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            string Query = "INSERT INTO `usuarios` (`id`,`usuario`, `cedula`, `contra`) VALUES (NULL,'" + cE.usuario + "', '" + cE.cedula + "', '" + cE.password + "');";

            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            conexionBD.Close();
        }

        public int Read(CE_Entities cE)
        {
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
            codigo.Connection = conexionBD;
            codigo.CommandText = "SELECT usuario,contra FROM `usuarios` WHERE usuario='" + cE.usuario + "' and contra='" + cE.password + "'";
            MySqlDataReader leer = codigo.ExecuteReader();
            
            bool v = leer.Read();

            if (v == true)
            {
                return 1; 
            }
            return 0;
            conexionBD.Close();
        }

        public void Update(CE_Entities cE)
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            string Query = "UPDATE `usuarios` SET `contra` = '" + cE.password + "' WHERE `usuarios`.`usuario` = '" + cE.usuario + "';";

            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            conexionBD.Close();
        }

        public void CreateTwo(CE_Entities cE)
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            string Query = "INSERT INTO `lista` (`id`,`tipo_Vehiculo`, `nombre_Cliente`, `telefono_Cliente`, `email_Cliente`) VALUES (NULL,'" + cE.cbVehiclecoti + "', '" + cE.namecoti + "', '" + cE.telefonocoti + "', '" + cE.emailcoti + "');";

            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            conexionBD.Close();
        }

        public void Delete(CE_Entities cE)
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            string Query = "DELETE FROM `lista` WHERE `id`='" + cE.id + "';";

            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            conexionBD.Close();
        }
        public DataSet Listar()
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            string Query = ("SELECT * FROM `lista`;");
            MySqlDataAdapter adaptador;
            DataSet ds = new DataSet();

            adaptador = new MySqlDataAdapter(Query, conexionBD);
            adaptador.Fill(ds, "lista");

            return ds;
        }
    }
}

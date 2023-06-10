using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CData
{
    public class CBD
    {
        string BDD = "HOSPITAL";
        //Editar las variables según su configuración de SQL SERVER
        public string NIGSERVER = "DESKTOP-2U77OBE\\SQLEXPRESS", NIGPSW = "nigel123";
        string FERSERVER = "COMTEX765", FERPSW = "12 fer 13";
        string CRISSERVER = "", CRISPSW = "";
        string KEVSERVER = "", KEVPSW = "";
        string SERVER = "", SKYPSW = "";
        public string cadena;
        public SqlConnection connect = new SqlConnection();
        public CBD()
        {
            //Editar la cadena de conexión con sus variables
            cadena = $"Data Source= {@NIGSERVER};Initial Catalog={@BDD};User ID=sa;Password={@NIGPSW}";
            connect.ConnectionString = cadena;
        }
        public void Abrir()
        {
            try
            {
                connect.Open();
                Console.WriteLine("Conexión abierta");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Cerrar()
        {
            try
            {
                connect.Close();
                Console.WriteLine("Conexión cerrada");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

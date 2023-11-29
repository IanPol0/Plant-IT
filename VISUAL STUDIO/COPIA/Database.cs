using System.Data.OleDb;

namespace COPIA
{
    public static class Database
    {
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\PlantIT_Database.accdb;";

        private static OleDbConnection conexion = new OleDbConnection(connectionString);
        private static OleDbCommand comando = new OleDbCommand();

        public static void OpenConnection(OleDbConnection conexion, OleDbCommand comando)
        {
            comando.Connection = conexion;
            conexion.Open();
        }

        public static void BorrarDatos(int id)
        {
            OpenConnection(conexion, comando);
            comando.CommandText = $"delete from Maceta where IDPlanta={id} and Id>3";
            comando.ExecuteNonQuery();
            comando.CommandText = $"update Maceta set Humedad=0, Luz=0, EstadoHumedad=0, EstadoLuz=0, Fecha=0, Hora=0 where Id={id}";
            comando.ExecuteNonQuery();
            comando.CommandText = $"update Planta set Nombre='Plant {id}', HumedadMinima=0, HumedadMaxima=0, LuzMinima=0, LuzMaxima=0, IDFamilia=0 where Id={id}";
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}


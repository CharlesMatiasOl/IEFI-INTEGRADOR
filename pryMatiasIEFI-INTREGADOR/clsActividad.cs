using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMatiasIEFI_INTREGADOR
{
    internal class clsActividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dato
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos en la base a datos por .NET
        private OleDbDataReader Lectora;
        public string NombreActividad;
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFIBD.mdb";
        private string tabla = "Actividad";

        // Funciones 
        public void Listar(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();
                comando.Connection = conexion; 
                comando.CommandType = CommandType.TableDirect; // trae una tabla
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram 
                adaptador.Fill(DS);
                dgvGrilla.DataSource = DS.Tables[0];
                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }

        public void ListarC(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();
                comando.Connection = conexion; 
                comando.CommandType = CommandType.TableDirect; 
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram 
                adaptador.Fill(DS, tabla);
                combo.DataSource = DS.Tables[tabla];
                combo.DisplayMember = "Detalle_Actividad";//es lo que va aparecer en la lista desplegable
                combo.ValueMember = "Codigo_Actividad";


                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }

        public void BuscarActivid(int codigo)
        {
            try
            {
                //Conecto con la base de datos
                conexion.ConnectionString = cadenaConexion;               
                conexion.Open();               
                comando.Connection = conexion;               
                comando.CommandType = CommandType.Text;             
                comando.CommandText = "SELECT * FROM Actividad WHERE Codigo_Actividad =" + codigo;//Indico Nombre de la tabla a travez de la variable tabla creada                             
                Lectora = comando.ExecuteReader();//le paso a adaptador el comando 

                while (Lectora.Read())
                {
                    NombreActividad = Lectora[1].ToString();
                }

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }
        }
    }
}

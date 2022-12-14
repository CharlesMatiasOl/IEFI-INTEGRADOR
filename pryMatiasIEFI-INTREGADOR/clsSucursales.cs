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
    internal class clsSucursales
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dato
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos en la base a datos para.NET
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFIBD.mdb";
        private string tabla = "Sucursales";

        public void ListarComboBox(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();
                comando.Connection = conexion; 
                comando.CommandType = CommandType.TableDirect; //nos trae una tabla
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram 
                adaptador.Fill(DS, tabla);
                combo.DataSource = DS.Tables[tabla];
                combo.DisplayMember = "Detalle_Sucursal";//es lo que va aparecer en la lista 
                combo.ValueMember = "Codigo_Sucursal";


                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }
        public void FiltrarClientesDeUnaSucursal(DataGridView Grilla, Int32 Sucursal)
        {
            try
            {

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                OleDbDataReader Lector = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (Lector.HasRows)// si hay filas se lee
                {
                    while (Lector.Read())//leemos
                    {
                        if (Lector.GetInt32(3) == Sucursal)// y si esta todo bien pone los datos en la grilla
                        {
                            Grilla.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetDecimal(5));
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {

            }
        }

    }
}

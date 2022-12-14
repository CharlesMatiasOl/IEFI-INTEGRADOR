using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMatiasIEFI_INTREGADOR
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dato
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos que estan en la base a datos comprensibles por .NET

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFIBD.mdb";
        private string tabla = "Socio";

        private decimal saldo;
        private Int32 cantidad;
        private decimal promedio;

        private Int32 dni;
        private string nombre;
        private string direccion;
        private Int32 codSucursal;
        private Int32 codActividad;



        //propiedades de lecturas 
        public Int32 Dni_Socio
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre_Apellido
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }

        }
        public decimal TotalSaldo
        {
            get { return saldo; }


        }
        public Int32 cantidadSocios
        {
            get { return cantidad; }
        }
        public decimal promedioSaldo
        {
            get { return saldo / cantidad; }

        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public Int32 CodigoSucursal
        {
            get { return codSucursal; }
            set { codSucursal = value; }
        }
        public Int32 CodigoActividad
        {
            get { return codActividad; }
            set { codActividad = value; }
        }

        //Funciones

        public void Listar(DataGridView dgvGrilla) 
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();
                comando.Connection = conexion; 
                comando.CommandType = CommandType.TableDirect; 
                comando.CommandText = tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);

                dgvGrilla.DataSource = DS.Tables[0];


                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }
        public void Buscar(Int32 Dni_Socio)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = "Socio";


                OleDbDataReader DR = comando.ExecuteReader(); //recibe lo que tiene la tabla y ejecuta
                if (DR.HasRows) 
                {
                    while (DR.Read()) //mientras haya datos
                    {
                        if (DR.GetInt32(0) == Dni_Socio) //comparamos con lo escrito 
                        {
                            dni = DR.GetInt32(0);
                            nombre = DR.GetString(1);
                            direccion = DR.GetString(2);
                            codSucursal = DR.GetInt32(3);
                            codActividad = DR.GetInt32(4);
                            saldo = DR.GetDecimal(5);

                        }
                    }
                }
                conexion.Close();

            }
            catch (Exception)
            {


            }
        }
        public void ListarSocios(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = tabla;

                OleDbDataReader DR = comando.ExecuteReader(); //recibe y ejecuta
                dgvGrilla.Rows.Clear();
                cantidad = 0;
                saldo = 0;
                while (DR.Read()) // recorre la base de datos y si esta todo bien 
                {
                    if (DR.GetDecimal(5) > 0)
                    {

                        dgvGrilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5)); // aca lo agrega los datos en la grilla
                        cantidad++;
                        saldo = saldo + DR.GetDecimal(5);

                    }

                }
                conexion.Close();
            }
            catch (Exception)
            {


            }
        }

        public void RegistroClientes()
        {
            try
            {
                // Comando para inserir datos 
                String Sql = "";
                Sql = "INSERT INTO Socio (Dni_Socio,Nombre_Apellido,Direccion,Codigo_Sucursal,Codigo_Actividad,Saldo)";
                Sql = Sql + " VALUES (" + Dni_Socio + ",'" + Nombre_Apellido + "','" + Direccion + "'," + CodigoSucursal + "," + CodigoActividad + "," + Saldo + ")";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser registrado!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser registrado");
            }
        }

        public void BajaDeSocios()
        {
            try
            {
                String Sql = "";
                Sql = "DELETE FROM Socio " +
                    "WHERE(" + dni + "=[Dni_Socio])";

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser eliminado!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser eliminado");
            }
        }
        public void ModificarSocios(Int32 Dni_Socio)
        {
            try
            {
                String Sql = "UPDATE Socio SET " +//Comando para modificar en la tabla
                    "[Dni_Socio] = " + Dni_Socio + ", " +
                    "[Nombre_Apellido] = '" + Nombre_Apellido + "', " +
                    "[Direccion] = '" + Direccion + "', " +
                    "[Codigo_Sucursal] = " + CodigoSucursal + " , " +
                    "[Codigo_Actividad] = " + CodigoActividad + " , " +
                    "[Saldo] = " + Saldo + " WHERE [Dni_Socio] = " + Dni_Socio;


                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser modificado!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser modficado");
            }
        }

        public void FiltrarClientesDeUnaActividad(DataGridView Grilla, Int32 Actividad)
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
                    while (Lector.Read())// lo filtramos para que aparezca el dato correcto
                    {
                        if (Lector.GetInt32(4) == Actividad) // y depues agrega el dato 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace  FetchEmpleo
{
    public class CV_CP
    {
		private int id;
		private int propietario;
		private string tipo;
		private string contenido;

		#region PROPIEDADES
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public int Propietario {
			get {
				return propietario;
			}
			set {
				propietario = value;
			}
		}

		public string Tipo {
			get {
				return tipo;
			}
			set {
				tipo = value;
			}
		}

		public string Contenido {
			get {
				return contenido;
			}
			set {
				contenido = value;
			}
		}
		#endregion

		public CV_CP()
		{
		}
    }

    public class daoCV_CP
	{
		private MySqlConnection conexion;

		/// <summary>
		/// Conectar a la base de datos especificada con user y password.
		/// </summary>
		/// <param name="srv"></param>
		/// <param name="db"></param>
		/// <param name="user"></param>
		/// <param name="pwd"></param>
		/// <returns></returns>
		public bool Conectar(string srv, string db, string user, string pwd)
		{
			bool conectado = false;
			string cadenaConexion = "server=" + srv + ";" + "database=" + db + ";"
				+ "uid=" + user + ";" + "pwd=" + pwd + ";";

			try
			{
				conexion = new MySqlConnection(cadenaConexion);
				conexion.Open(); //conexión habilitada
				conectado = true;
			}
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
				case 113: throw new Exception("Error en la conexión");
				case 1045: throw new Exception("Usuario o contraseña incorrectos");

				}
			}
			return conectado;
		}

		/// <summary>
		/// Desconectar esta instancia.
		/// </summary>
		public void Desconectar()
		{
			conexion.Close();
		}

		/// <summary>
		/// Seleccionar un CV/CP por su Id, que obtenemos de tabla Inscripcion.
		/// </summary>
		public CV_CP SeleccionarUnCV_CP(int id)
		{
			CV_CP unCV_CP = new CV_CP ();
			string sql;
			sql = "select id,propietario,tipo,contenido from CV_CP where id=" + id + ";";

			MySqlCommand cmd = new MySqlCommand (sql, conexion);

			//construimos un objeto datareader para ejecutar el comando cmd
			MySqlDataReader lector = cmd.ExecuteReader ();
			//recuperamos los datos lector para devolver la colección

			lector.Read ();
			unCV_CP.Id = (int)lector ["id"];
			unCV_CP.Propietario = (int)lector ["propietario"];
			unCV_CP.Tipo = lector ["tipo"].ToString();
			unCV_CP.Contenido = lector ["contenido"].ToString();
			lector.Close ();

			return unCV_CP;
		}

		// <summary>
		/// Insertar un CV/CP.
		/// </summary>
		public bool InsertarCV_CP(CV_CP cvcp)
		{
			//POR HACER
			return true;
		}

		/// <summary>
		/// Modificar datos de un CV/CP
		/// </summary>
        public bool ModificarCV_CP(CV_CP cvcp)
		{
			//POR HACER
			return true;
		}
	}
}

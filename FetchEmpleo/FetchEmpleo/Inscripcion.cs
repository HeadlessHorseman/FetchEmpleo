using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace  FetchEmpleo
{
    public class Inscripcion
    {
		private int numero;
		private int candidato;
		private int oferta;

		#region PROPIEDADES
		public int Numero {
			get {
				return numero;
			}
			set {
				numero = value;
			}
		}

		public int Curriculo {
			get {
				return candidato;
			}
			set {
				candidato = value;
			}
		}

		public int Oferta {
			get {
				return oferta;
			}
			set {
				oferta = value;
			}
		}
		#endregion

		public Inscripcion()
		{
		}
    }

    public class daoInscripcion
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
		/// Seleccionar datos de Inscripcion para ver a los Candidatos que tengo.
		/// </summary>
		public List<Inscripcion> SeleccionarInscripcion(int idEmpresa)
		{
			List<Inscripcion> resultado = new List<Inscripcion>();
			string sql;
			sql = "select * from inscripcion where oferta in (select * from oferta where empresa='" + idEmpresa + "');";

			MySqlCommand cmd = new MySqlCommand(sql, conexion);

			MySqlDataReader lector = cmd.ExecuteReader();

			while (lector.Read ()) 
			{
				Inscripcion inscripcion = new Inscripcion ();
				inscripcion.Numero = (int)lector ["numero"];
				inscripcion.Curriculo = (int)lector ["candidato"];
				inscripcion.Oferta = (int)lector ["oferta"];
				resultado.Add (inscripcion);
			}
			lector.Close();

			return resultado;
		}

		// <summary>
		/// Insertar una Inscripcion.
		/// </summary>
		public bool InsertarInscripcion(Inscripcion inscripcion)
		{
			//POR HACER
			return true;
		}

		/// <summary>
		/// Modificar datos de una Inscripcion
		/// </summary>
		/// <returns></returns>
        public bool ModificarInscripcion(Inscripcion inscripcion)
		{
			//POR HACER
			return true;
		}
	}
}

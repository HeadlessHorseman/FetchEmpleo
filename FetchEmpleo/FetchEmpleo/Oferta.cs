using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace  FetchEmpleo
{
    public class Oferta
    {
		private int id;
		private int idEmpresa;
		private string titulo;
		private string requisitos;
		private string descripcion;
		private bool discapacitado;
		private int plazas;

        #region PROPIEDADES
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Requisitos
        {
            get { return requisitos; }
            set { requisitos = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public bool Discapacitado
        {
            get { return discapacitado; }
            set { discapacitado = value; }
        }
        public int Plazas
        {
            get { return plazas; }
            set { plazas = value; }
        }
        #endregion

        public Oferta()
        {
        }
    }

    public class daoOferta
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
        /// Seleccionar ofertas por Empresa.
        /// </summary>
        public List<Oferta> SeleccionarMisOfertas(string empresa)
        {
            List<Oferta> resultado = new List<Oferta>();
            string sql;
			sql = "select id,titulo,requisitos,descripcion,discapacitado,plazas from oferta where empresa in (select id from empresa where login='" + empresa + "');";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            //construimos un objeto datareader para ejecutar el comando cmd
            MySqlDataReader lector = cmd.ExecuteReader();
            //recuperamos los datos lector para devolver la colección

            while (lector.Read())
            {
                Oferta unaOferta = new Oferta();
                unaOferta.Id = (int)lector["id"];
				unaOferta.Titulo = lector ["titulo"].ToString();
				unaOferta.Requisitos = lector ["requisitos"].ToString();
				unaOferta.Descripcion=lector["descripcion"].ToString();
				unaOferta.Discapacitado = (bool)lector ["discapacitado"];
				unaOferta.Plazas = (int)lector ["plazas"];
                resultado.Add(unaOferta);
            }
            lector.Close();
            return resultado;
        }

		/// <summary>
		/// Seleccionar una oferta por Id de oferta.
		/// </summary>
		public Oferta SeleccionarUnaOferta(int id)
		{
			Oferta unaOferta = new Oferta ();
			string sql;
			sql = "select id,titulo,requisitos,descripcion,discapacitado,plazas from oferta where id=" + id + ";";

			MySqlCommand cmd = new MySqlCommand (sql, conexion);

			//construimos un objeto datareader para ejecutar el comando cmd
			MySqlDataReader lector = cmd.ExecuteReader ();
			//recuperamos los datos lector para devolver la colección

			lector.Read ();
			unaOferta.Id = (int)lector ["id"];
			unaOferta.Titulo = lector ["titulo"].ToString();
			unaOferta.Requisitos = lector ["requisitos"].ToString();
			unaOferta.Descripcion = lector ["descripcion"].ToString();
			unaOferta.Discapacitado = (bool)lector ["discapacitado"];
			unaOferta.Plazas = (int)lector ["plazas"];
			lector.Close ();

			return unaOferta;
		}

		// <summary>
		/// Insertar una Oferta.
		/// </summary>
        public bool InsertarOferta(Oferta unaOferta)
		{
			bool insertado = false;
			string sql = "insert into oferta values(" +
				unaOferta.Id + ","+
				unaOferta.IdEmpresa+",'"+
				unaOferta.Titulo+"','"+
				unaOferta.Requisitos+"','"+
				unaOferta.Descripcion+"',"+
				unaOferta.Discapacitado+","+
				unaOferta.Plazas
				+ ");";

            MySqlCommand comandoInsert = new MySqlCommand(sql, conexion);

            MySqlDataReader MyReader;

            try
            {
                MyReader = comandoInsert.ExecuteReader();  // Here our query will be executed and data saved into the database.
                while (MyReader.Read())
                {

                }
                MyReader.Close();
                insertado = true;
            }
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
				case 1048: throw new Exception("Columna no puede ser nula");
				case 1062: throw new Exception("Clave primaria ya existente");
				case 1216: throw new Exception("No  se puede añadir, no existe este idEmpresa en Empresa");
				default:
					throw;
				}
			}

			return insertado;
		}

		/// <summary>
		/// Modificar datos de una Oferta
		/// </summary>
		/// <returns></returns>
        public bool ModificarOferta(Oferta unaOferta)
		{
			bool modificado = false;
			string sql = "update oferta set titulo='" + unaOferta.Titulo
				+ "',requisitos='" + unaOferta.Requisitos
				+ "',descripcion='" + unaOferta.Descripcion
				+ "',discapacitado=" + unaOferta.Discapacitado
				+ ",plazas=" + unaOferta.Plazas
				+ " where id=" + unaOferta.Id
				+ ";";

            MySqlCommand comandoInsert = new MySqlCommand(sql, conexion);

            MySqlDataReader MyReader;

            try
            {
                MyReader = comandoInsert.ExecuteReader();  // Here our query will be executed and data saved into the database.
                while (MyReader.Read())
                {

                }
                MyReader.Close();
                modificado = true;
            }
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
				case 1048: throw new Exception("Columna no puede ser nula");
				case 1062: throw new Exception("Clave primaria ya existente"); 
				case 1452: throw new Exception("No se puede modificar, no existe este idEmpresa en Empresa");
				default:
					throw;
				}
			}

			return modificado;
		}

        /// <summary>
        /// Borrar una Oferta
        /// </summary>
        /// <returns></returns>
        public bool BorrarOferta(Oferta unaOferta)
        {
            bool borrado = false;
            string sql = "delete from oferta where id=" + unaOferta.Id + ";";

            MySqlCommand comandoInsert = new MySqlCommand(sql, conexion);

            MySqlDataReader MyReader;

            try
            {
                MyReader = comandoInsert.ExecuteReader();  // Here our query will be executed and data saved into the database.
                while (MyReader.Read())
                {

                }
                MyReader.Close();
                borrado = true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1452: throw new Exception("No se puede borrar, no existe este idEmpresa en Empresa");
                    default:
                        throw;
                }
            }

            return borrado;
        }

        public int CountOfertas(int idEmpresa)
        {
            int numOfertas;
            string sql = "select count(*) as Contar from oferta where empresa=" + idEmpresa + ";";

            MySqlCommand selectCount = new MySqlCommand(sql, conexion);

            MySqlDataReader lector = selectCount.ExecuteReader();
            lector.Read();
            numOfertas = Convert.ToInt32(lector["Contar"]);
            lector.Close();

            return numOfertas;
        }
    }
}

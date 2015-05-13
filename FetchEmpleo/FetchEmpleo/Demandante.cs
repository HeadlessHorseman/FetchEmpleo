using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  FetchEmpleo
{
    public class Demandante
    {
        int id;
        string login;
        string dni;
        string nombre;
        string apellidos;
        bool discapacitado;
        DateTime fechaNacimiento;
        string sexo;
        string domicilio;
        string email;
        int telefono;
        string web;

        #region PROPIEDADES
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public bool Discapacitado
        {
            get { return discapacitado; }
            set { discapacitado = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Web
        {
            get { return web; }
            set { web = value; }
        }
        #endregion

        public Demandante()
        {
        }
    }

    public class daoDemandante
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
        /// Seleccionar todos los Candidatos de una empresa determinada.
        /// </summary>
        public List<Demandante> SeleccionarMisCandidatos(int id)
        {
            List<Demandante> resultado = new List<Demandante>();
            string sql;
            sql = "select id,dni,nombre,apellidos,discapacitado,fechaNacimiento,sexo,domicilio,email,telefono,web from demandante "
                        +"where id in (select candidato from inscripcion where oferta in (select id from oferta where empresa='"+id+"'));";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            //construimos un objeto datareader para ejecutar el comando cmd
            MySqlDataReader lector = cmd.ExecuteReader();
            //recuperamos los datos lector para devolver la colección

            while (lector.Read())
            {
                Demandante unCandidato = new Demandante();
                unCandidato.Id = (int)lector["id"];
                unCandidato.Dni = lector["dni"].ToString();
                unCandidato.Nombre = lector["nombre"].ToString();
                unCandidato.Apellidos = lector["apellidos"].ToString();
                unCandidato.Discapacitado = (bool)lector["discapacitado"];
                unCandidato.FechaNacimiento = (DateTime)(lector["fechaNacimiento"]);
                unCandidato.Sexo = lector["sexo"].ToString();
                unCandidato.Domicilio = lector["domicilio"].ToString();
                unCandidato.Email = lector["email"].ToString();
                unCandidato.Telefono = Convert.ToInt32(lector["telefono"]);
                unCandidato.Web = lector["web"].ToString();
                resultado.Add(unCandidato);
            }
            lector.Close();
            return resultado;
        }

        public Demandante SeleccionarDemandante(string login)
        {
            Demandante demand = new Demandante();
            string sql;
            sql = "select * from demandante where login='" + login + "';";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            MySqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            demand.Id = (int)lector["id"];
            demand.Dni = lector["dni"].ToString();
            demand.Nombre = lector["nombre"].ToString();
            demand.Apellidos = lector["apellidos"].ToString();
            demand.Discapacitado = (bool)lector["discapacitado"];
            demand.FechaNacimiento = (DateTime)(lector["fechaNacimiento"]);
            demand.Sexo = lector["sexo"].ToString();
            demand.Domicilio = lector["domicilio"].ToString();
            demand.Email = lector["email"].ToString();
            demand.Telefono = Convert.ToInt32(lector["telefono"]);
            demand.Web = lector["web"].ToString();
            lector.Close();

            return demand;
        }

        public bool ModificarDemandante(Demandante demandante)
        {
            bool modificado = false;

            string sql = "update demandante set dni='" + demandante.Id
                + "',apellidos='" + demandante.Apellidos
                + "',nombre='" + demandante.Nombre
                + "',sexo='" + demandante.Sexo
                + "',discapacitado='" + demandante.Discapacitado
                + "',email='" + demandante.Email
                + "',telefono='" + demandante.Telefono
                + "',domicilio='" + demandante.Domicilio
                + "',web='" + demandante.Web + "'"
                + " where id=" + demandante.Id
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
                    case 1048: throw new Exception("Columna no puede ser nula");    // Único error con sentido 1048, los demás no se producirán porque
                    case 1062: throw new Exception("Clave primaria ya existente");      // supuestamente ya se ha creado el usuario con anterioridad
                    case 1216: throw new Exception("No  se puede añadir, no existe este usuario en tabla Usuarios");
                    case 1452: throw new Exception("No se puede modificar, no existe este usuario en tabla Usuarios");
                    default:
                        throw;
                }
            }

            return modificado;
        }
    }
}

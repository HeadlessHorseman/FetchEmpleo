using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace  FetchEmpleo
{
    public class Empresa
    {
        private int id;
        private string login;
        private string cif;
        private string raSocial;
        private string nombre;
        private string categoria;
        private string email;
        private int telefono;
        private string domicilio;
        private string localidad;
        private string web;
        private string imagen;

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
        public string Cif
        {
            get { return cif; }
            set { cif = value; }
        }
        public string RaSocial
        {
            get { return raSocial; }
            set { raSocial = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
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
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        public string Web
        {
            get { return web; }
            set { web = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        #endregion

        public Empresa()
        {
        }
    }

    public class daoEmpresa
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
        /// Seleccionar datos de Empresa por su nombre de usuario.
        /// </summary>
        public Empresa SeleccionarEmpresa(string login)
        {
            Empresa empresa = new Empresa();
            string sql;
			sql = "select * from empresa where login='" + login + "';";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            MySqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            empresa.Id = (int)lector["id"];
            empresa.Login = lector["login"].ToString();
            empresa.Cif = lector["cif"].ToString();
            empresa.RaSocial = lector["razonSocial"].ToString();
            empresa.Nombre = lector["nombre"].ToString();
            empresa.Categoria = lector["categoria"].ToString();
            empresa.Email = lector["email"].ToString();
            empresa.Telefono = Convert.ToInt32(lector["telefono"]);
            empresa.Domicilio = lector["domicilio"].ToString();
            empresa.Localidad = lector["localidad"].ToString();
            empresa.Web = lector["web"].ToString();
            empresa.Imagen = lector["logo"].ToString();
            lector.Close();

            return empresa;
        }

        /// <summary>
        /// Insertar datos de Empresa.
        /// </summary>
        public bool InsertarEmpresa(Empresa empresa)
        {
            bool insertado = false;
            string sql = "insert into empresa (id,login,cif,razonSocial,nombre,categoria,email,telefono,domicilio,localidad,web) values(" +
                empresa.Id + ",'"+
                empresa.Login+"','"+
                empresa.Cif+"','"+
                empresa.RaSocial+"','"+
                empresa.Nombre+"','"+
                empresa.Categoria+"','"+
                empresa.Email+"','"+
                empresa.Telefono+"','"+
                empresa.Domicilio+"','"+
                empresa.Localidad+"','"+
                empresa.Web+"'"
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
                    case 1048: throw new Exception("Columna no puede ser nula");    // Único error con sentido 1048, los demás no se producirán porque
                    case 1062: throw new Exception("Clave primaria ya existente");      // supuestamente ya se ha creado el usuario con anterioridad
                    case 1216: throw new Exception("No  se puede añadir, no existe este usuario en tabla Usuarios");
                    case 1452: throw new Exception("No se puede insertar, no existe este usuario en tabla Usuarios");
                    default:
                        throw;
                }
            }

            return insertado;
        }

        /// <summary>
        /// Modificar datos de Empresa
        /// </summary>
        /// <returns></returns>
        public bool ModificarEmpresa(Empresa empresa)
        {
            bool modificado = false;
            string sql = "update empresa set cif='" + empresa.Cif
                + "',razonSocial='" + empresa.RaSocial
                + "',nombre='" + empresa.Nombre
                + "',categoria='" + empresa.Categoria
                + "',email='" + empresa.Email
                + "',telefono='" + empresa.Telefono
                + "',domicilio='" + empresa.Domicilio
                + "',localidad='" + empresa.Localidad
                + "',web='" + empresa.Web + "'"
                + " where id=" + empresa.Id
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

        //Insertar logo en empresa
        public bool LogoEmpresa(string login, string ruta)
        {
            bool insertado = false;
            ruta = ruta.Replace(@"\", @"\\");
            string sql = "update empresa set logo='" + ruta + "' where login='" + login + "';";
            /////////
            MySqlCommand comandoInsert = new MySqlCommand(sql, conexion);

            MySqlDataReader MyReader;

            try
            {
                MyReader = comandoInsert.ExecuteReader();  // Here our query will be executed and data saved into the database.
                while (MyReader.Read())
                {

                }
                MyReader.Close();
            }
            catch { }
     
            return insertado;
        }

    }

}

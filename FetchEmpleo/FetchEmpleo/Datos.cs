using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  FetchEmpleo
{
    public class Datos
    {
        const string IP = "127.0.0.1"; //red local
        const string BD = "proyectoFol";
        private string user;
        private string passwd;
        private bool conexion = false;

        daoEmpresa daoE = new daoEmpresa();
        daoOferta daoO = new daoOferta();
        daoInscripcion daoI = new daoInscripcion();
        daoCV_CP daoC = new daoCV_CP();
        daoDemandante daoD = new daoDemandante();

        #region PROPIEDADES
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Passwd
        {
            get { return passwd; }
            set { passwd = value; }
        }
        public bool Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        #endregion

        #region CONSTRUCTOR
        public Datos(string usr,string pass)
        {
            User = usr;
            Passwd = pass;
            try
            {
                //Conexión con las tablas que hacen falta en la parte de Empresas, faltan las demás
                if (daoE.Conectar(IP, BD, User, Passwd) && daoO.Conectar(IP, BD, User, Passwd) && daoI.Conectar(IP, BD, User, Passwd) && daoC.Conectar(IP, BD, User, Passwd) && daoD.Conectar(IP, BD, User, Passwd))
                    conexion = true;
            }
            catch
            {
                throw new Exception("Conexión fallida con la base de datos");
            }
        }
        #endregion


        #region MÉTODOS EMPRESA
        Empresa empresa = new Empresa();

        public Empresa SeleccionarEmpresa(string usuario)
        {
            return daoE.SeleccionarEmpresa(usuario);
        }
        public bool InsertarEmpresa(Empresa empresa)
        {
            return daoE.InsertarEmpresa(empresa);
        }
        public bool ModificarEmpresa(Empresa empresa)
        {
            return daoE.ModificarEmpresa(empresa);
        }
        public bool LogoDeEmpresa(string login, string ruta)
        {
            return daoE.LogoEmpresa(login, ruta);
        }
        #endregion

        #region MÉTODOS OFERTA
        public List<Oferta> SeleccionarMisOfertas(string usuario)
        {
            return daoO.SeleccionarMisOfertas(usuario);
        }
        public Oferta SeleccionarUnaOferta(int id)
        {
            return daoO.SeleccionarUnaOferta(id);
        }
        public bool InsertarOferta(Oferta unaOferta)
        {
            return daoO.InsertarOferta(unaOferta);
        }
        public bool ModificarOferta(Oferta unaOferta)
        {
            return daoO.ModificarOferta(unaOferta);
        }
        public bool BorrarOferta(Oferta unaOferta)
        {
            return daoO.BorrarOferta(unaOferta);
        }
        public int numOfertas(int idEmpresa)
        {
            return daoO.CountOfertas(idEmpresa);
        }
        #endregion

        #region MÉTODOS INSCRIPCION
        public List<Inscripcion> SeleccionarInscripcion(int idEmpresa)
        {
            return daoI.SeleccionarInscripcion(idEmpresa);
        }

        //Insertar

        //Modificar
        #endregion

        #region MÉTODOS CURRICULO/CARTA P.
        public CV_CP SeleccionarUnCV_CP(int id)
        {
            return daoC.SeleccionarUnCV_CP(id);
        }

        //Insertar

        //Modificar
        #endregion

        #region MÉTODOS DEMANDANTE
        public List<Demandante> SeleccionarCandidatos(int id)
        {
            return daoD.SeleccionarMisCandidatos(id);
        }

        //Insertar

        //Modificar
        #endregion
    }
}

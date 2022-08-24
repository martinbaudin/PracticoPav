using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    internal class Usuario
    {
        //Propiedad No Abreviada
        private string nombre;
        private string password;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Usuario()
        {
            nombre = password = string.Empty;
        }
        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }
        public bool validar()
        {
            string consultaSQL = "SELECT * FROM Usuarios WHERE usuario='"
                                 + this.Nombre + "' AND password='"
                                 + this.Password + "'";
            DBHelper oDB = new DBHelper();
            if (oDB.consultarDB(consultaSQL).Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}

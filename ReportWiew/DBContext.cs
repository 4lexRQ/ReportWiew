using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWiew
{
    public class DBContext
    {

        //Conexion con mi base de datos
        protected MySqlConnection connectionBD = new MySqlConnection("server=34.70.147.191" + "; port=3306" + "; user id=root" + "; password=tln36pkyg22" +
            "; database=devg8spmarket;");
        //Reader
        protected MySqlDataReader Reader;
        //Comandos
        protected MySqlCommand Command = new MySqlCommand();
    }
}

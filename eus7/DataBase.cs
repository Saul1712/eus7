using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace eus7
{
    public interface DataBase
    {

        SQLiteAsyncConnection GetConnection();  //DEFINE METODO DE CONEXION    

    }
}

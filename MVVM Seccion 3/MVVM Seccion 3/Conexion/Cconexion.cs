using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_Seccion_3.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-b1eaf-default-rtdb.firebaseio.com/");
    }
}

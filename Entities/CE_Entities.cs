using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CE_Entities
    {
        //Atributos para Login/Olvidar/Crear cuenta
        public string usuario { get; set; }
        public string cedula{ get; set; }
        public string password { get; set; }
        public string passwordtwo { get; set; }

        //Atributos Cotizacion
        public string cbVehiclecoti { get; set; }
        public string namecoti { get; set; }
        public string telefonocoti { get; set; }
        public string emailcoti { get; set; }

        //Panel Admin
        public string id { get; set; }
    }
}

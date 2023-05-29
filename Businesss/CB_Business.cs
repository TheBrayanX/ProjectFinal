using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Windows.Forms;
using System.Data;

namespace Businesss
{ 
    public class CB_Business   
    {
        CD_Data cD = new CD_Data();
        public void MySqlCreate(CE_Entities cE)
        {   
            if (cE.usuario == "" || cE.cedula == "" || cE.password == "")
            {
                MessageBox.Show("No has insertado nada. ");
            } else
            {
                cD.Create(cE);
                MessageBox.Show("Tú usuario fue creado con éxito.");
            }
        }
        public int MySqlRead(CE_Entities cE)
        {
            return cD.Read(cE);
        }

        public void MySqlUpdate(CE_Entities cE)
        {
             cD.Update(cE);
        }

        public void MySqlDelete(CE_Entities cE)
        {
            cD.Delete(cE);
        }

        public void MySqCreateTwo(CE_Entities cE)
        {
            if (cE.cbVehiclecoti == "" || cE.namecoti == "" || cE.telefonocoti == "" || cE.emailcoti == "")
            {
                MessageBox.Show("Estimado Cliente, tienes que completar los campos. ");
            } else
            {
                MessageBox.Show("En breves, un agente de ventas te contactará. ");
                cD.CreateTwo(cE);
            }
        }
        public DataSet Vista_Pedidos()
        {
            return cD.Listar();
        }
    }
}

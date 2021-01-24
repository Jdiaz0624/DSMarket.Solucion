using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionCorreosClienteDinamico
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();


        private decimal IdRegistro = 0;
        private decimal IdUsuario = 0;
        private decimal IdCliente = 0;
        private string Nombre = "";
        private string Correo = "";
        private string Accion = "";

        public ProcesarInformacionCorreosClienteDinamico(
        decimal IdRegistroCON,
        decimal IdUsuarioCON,
        decimal IdClienteCON,
        string NombreCON,
        string CorreoCON,
        string AccionCON)
        {
            IdRegistro = IdRegistroCON;
            IdUsuario = IdUsuarioCON;
            IdCliente = IdClienteCON;
            Nombre = NombreCON;
            Correo = CorreoCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EProcesarCorreosClientes Procesar = new Entidades.EntidadesEmpresa.EProcesarCorreosClientes();

            Procesar.IdRegistro = IdRegistro;
            Procesar.IdUsuario = IdUsuario;
            Procesar.IdCliente = IdCliente;
            Procesar.Cliente = Nombre;
            Procesar.Correo = Correo;

            var MAN = ObjData.ProcesarInformacionCorreoClientesOrigen(Procesar, Accion);
        }
    }
}

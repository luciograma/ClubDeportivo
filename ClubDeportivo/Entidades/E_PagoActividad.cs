using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_PagoActividad
    {
        private long id;
        private long noSocioId;
        private long actividadId;
        private DateTime fechaAbono;
        private double montoAbonado;
        private string medioDePago;
    }
}

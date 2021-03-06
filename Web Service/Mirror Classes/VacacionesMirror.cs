﻿using System;
using System.Runtime.Serialization;

namespace Web_Service.Mirror_Classes
{
    [DataContract]
    public class VacacionesMirror
    {
        [DataMember]
        public int VacacionesId { get; set; }

        [DataMember]
        public int TalentoHumano { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public DateTime FechaSalida { get; set; }

        [DataMember]
        public DateTime FechaEntrada { get; set; }

        [DataMember]
        public int DiasSolicitados { get; set; }

        [DataMember]
        public int FechaSolicitud { get; set; }//En la BaseDatos esta como int

        [DataMember]
        public DateTime FechaAprobacion { get; set; }

        [DataMember]
        public int EstatusId { get; set; }
    }
}

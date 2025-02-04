﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnoCalendario;
        private int _Cupo;
        private string _Descripcion;
        private int _IDComision;
        private int _IDMateria;
        public int AnoCalendario
        {
            get
            {
                return _AnoCalendario;
            }
            set
            {
                _AnoCalendario = value;
            }
        }
        public int Cupo
        {
            get
            {
                return _Cupo;
            }
            set
            {
                _Cupo = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }
        public int IDComision
        {
            get
            {
                return _IDComision;
            }
            set
            {
                _IDComision = value;
            }
        }
        public int IDMateria
        {
            get
            {
                return _IDMateria;
            }
            set
            {
                _IDMateria = value;
            }
        }
    }
}

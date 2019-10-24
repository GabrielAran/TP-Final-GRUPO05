using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Proyecto_final.Models
{
    public class Inmueble
    {
        private int _precio;
        private int _id;
        private string _barrio;
        private int _superficie;
        private int _ambientes;
        private bool _patio;
        private bool _terraza;
        private string _idTipo;
        private int _idAgente;
        private bool _reservado;
        private string _direccion;
        private int _baños;
        private int _habitaciones;

        
        public Inmueble() { }

        public Inmueble(int precio, int id, string barrio, int superficie, int ambientes, bool patio, bool terraza, string idTipo, int idAgente, bool reservado, string direccion, int baños, int habitaciones)
        {
            _precio = precio;
            _id = id;
            _barrio = barrio;
            _superficie = superficie;
            _ambientes = ambientes;
            _patio = patio;
            _terraza = terraza;
            _idTipo = idTipo;
            _idAgente = idAgente;
            _reservado = reservado;
            _direccion = direccion;
            _baños = baños;
            _habitaciones = habitaciones;
        }

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Barrio
        {
            get
            {
                return _barrio;
            }
            set
            {
                _barrio = value;
            }
        }

        public int Superficie
        {
            get
            {
                return _superficie;
            }
            set
            {
                _superficie = value;
            }
        }

        public int Ambientes
        {
            get
            {
                return _ambientes;
            }
            set
            {
                _ambientes = value;
            }
        }

        public bool Patio 
        {
            get
            {
                return _patio;
            }
            set
            {
                _patio = value;
            }
        }

        public bool Terraza 
        {
            get
            {
                return _terraza;
            }
            set
            {
                _terraza = value;
            }
        }

        public string idTipo
        {
            get
            {
                return _idTipo;
            }
            set
            {
                _idTipo = value;
            }
        }

        public int IDagente
        {
            get
            {
                return _idAgente;
            }
            set
            {
                _idAgente = value;
            }
        }

        public bool Reservado
        {
            get
            {
                return _reservado;
            }
            set
            {
                _reservado = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }

        public int Baños
        {
            get
            {
                return _baños;
            }
        }

        public int Habitaciones
        {
            get
            {
                return _habitaciones;
            }
        }

    }
}
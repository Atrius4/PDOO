using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaciónDoc
{
    class ValidadorDocumento
    {
        //Atributos - Estado
        private string tipo, genero, estadovalidacion;
        private long numero;
        private bool esValido;
        //Metodos - Comportamientos

        //Metodo Cosntructor
        public ValidadorDocumento()
        {
            tipo = "No Asignado";
            numero = 0;
            genero = "No Ingresado";
            esValido = false;
            estadovalidacion = "No se pudo Validar";
        }

        public long Numero {
            get { return numero; }
            set 
            {
                if (value >= 0) numero = value;
            }
        }

        public bool EsValido {
            get { return esValido; }
        }
        public string Genero {
            get { return genero; }
            set {
                if (value == "M" || value == "F")
                {
                    genero = value;
                }
                else
                {
                    esValido = false;
                    estadovalidacion = "Incorrecto por dato erróneo de género";
                }
            }
        }

        private void EjecutaValidacion()
        {
            //Se necesita longitud del documento
            int longitud = numero.ToString().Length;
            //Regla #1
            //cedula, hombre, longitud entre 3 y 8, rangos entre 1 y 19.999.999 y 70.000.000 y 99.999.999
        }
    }
}

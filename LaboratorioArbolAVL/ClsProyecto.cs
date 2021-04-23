using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioArbolAVL
{
    class ClsProyecto : Comparador
    {
        public int prioridad { get; set; }
        public string depto { get; set; }
        public string nombre { get; set; }
        public double monto { get; set; }


        public ClsProyecto(int prioridad, string depto, string nombre, double monto)
        {
            this.prioridad = prioridad;
            this.depto = depto;
            this.nombre = nombre;
            this.monto = monto;
        }

        public ClsProyecto()
        {
        }

        public bool igualQue(object q)
        {
            ClsProyecto aux = (ClsProyecto)q;
            return nombre == aux.nombre;
        }

        bool Comparador.menorQue(object q)
        {
            ClsProyecto aux = (ClsProyecto)q;
            byte[] valorASCII = Encoding.ASCII.GetBytes(nombre);
            byte[] valorASCII2 = Encoding.ASCII.GetBytes(aux.nombre);
            
            if (prioridad < aux.prioridad)
            {
                return true;
            }
            else 
            {
                if (depto == "Chiquimula")
                {
                    if (1 < obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 1 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Zacapa")
                {
                    if (2 < obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 2 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "El Progreso")
                {
                    if (3 < obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 3 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Alta Verapaz")
                {
                    if (4 < obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 4 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Baja Verapaz")
                {
                    if (5 < obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 5 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Guatemala") 
                {
                    if (6 < obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    //else
                    //{
                    //    return ordenamiento(valorASCII, valorASCII2);
                    //}
                }
                return ordenamiento(valorASCII, valorASCII2);
            }
        }

        public bool ordenamiento(byte[] valorASCII, byte[] valorASCII2)
        {
            for (int i = 0; i < valorASCII.Length; i++)
                if (valorASCII[i] < valorASCII2[i])
                    return true;
                else
                    return false;
            return false;
        }

        public int obtenerPrioridad(string depto)
        {
            if (depto == "Chiquimula")
            {
                return 1;
            }
            else if (depto == "Zacapa")
            {
                return 2;
            }
            else if (depto == "El Progreso")
            {
                return 3;
            }
            else if (depto == "Alta Verapaz")
            {
                return 4;
            }
            else if (depto == "Baja Verapaz")
            {
                return 5;
            }
            else
                return 6;
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        

        bool Comparador.mayorQue(object q)
        {
            ClsProyecto aux = (ClsProyecto)q;
            byte[] valorASCII = Encoding.ASCII.GetBytes(nombre);
            byte[] valorASCII2 = Encoding.ASCII.GetBytes(aux.nombre);
            
            if (prioridad > aux.prioridad)
            {
                return true;
            }
            else
            {
                if (depto == "Chiquimula")
                {
                    if (1 > obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 1 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Zacapa")
                {
                    if (2 > obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 2 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "El Progreso")
                {
                    if (3 > obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 3 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Alta Verapaz")
                {
                    if (4 > obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 4 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Baja Verapaz")
                {
                    if (5 > obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    else
                    {
                        ordenamiento(valorASCII, valorASCII2);
                    }
                    //return 5 < obtenerPrioridad(aux.depto);
                }
                else if (depto == "Guatemala")
                {
                    if (6 > obtenerPrioridad(aux.depto))
                    {
                        return true;
                    }
                    //else
                    //{
                    //    return ordenamiento(valorASCII, valorASCII2);
                    //}
                }
                return ordenamiento(valorASCII, valorASCII2);
            }
        }

        public bool ordenamiento2(byte[] valorASCII, byte[] valorASCII2)
        {
            for (int i = 0; i < valorASCII.Length; i++)
                if (valorASCII[i] > valorASCII2[i])
                    return true;
                else
                    return false;
            return false;
        }



        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool EsigualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool EsDistinto(object q)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {

            return "[" + prioridad + "  " + nombre + " " + monto + "]    ";
        }
    }
}

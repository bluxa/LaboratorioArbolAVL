using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioArbolAVL.ArbolBinario
{
    class ArbolBinarioBusqueda : ArbolBinario
    {
        public ArbolBinarioBusqueda() : base()
        {
        }

        public ArbolBinarioBusqueda(Nodo nodo) : base(nodo)
        {
        }

        public Nodo buscar(Object buscado)
        {
            Comparador dato;
            dato = (Comparador)buscado;
            if (raiz == null)
                return null;
            else
                return buscar(raizArbol(), dato);
        }

        protected Nodo buscar(Nodo raizSub, Comparador buscado)
        {
            if (raizSub == null)
                return null;
            else if (buscado.igualQue(raizSub.valorNodo()))
                return raizSub;
            else if (buscado.menorQue(raizSub.valorNodo()))
                return buscar(raizSub.subarbolIzdo(), buscado);
            else
                return buscar(raizSub.subarbolDcho(), buscado);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="buscado"></param>
        /// <returns></returns>
        public Nodo buscarIterativo(Object buscado)
        {
            Comparador dato;
            bool encontrado = false;
            Nodo raizSub = raiz;
            dato = (Comparador)buscado;
            while (!encontrado && raizSub != null)
            {
                if (dato.igualQue(raizSub.valorNodo()))
                    encontrado = true;
                else if (dato.menorQue(raizSub.valorNodo()))
                    raizSub = raizSub.subarbolIzdo();
                else
                    raizSub = raizSub.subarbolDcho();
            }
            return raizSub;
        }

        public Nodo buscarIterativoMio(Object buscado)
        {
            Comparador dato;
            bool encontrado = false;
            Nodo raizSub = raiz;
            Nodo raizSub2 = raiz;
            dato = (Comparador)buscado;
            while (!encontrado && raizSub != null)
            {
                if (dato.EsigualQue(raizSub.valorNodo()))
                    encontrado = true;

                else if (raizSub.subarbolIzdo() != null)
                    raizSub = raizSub.subarbolIzdo();

                else if (raizSub.subarbolDcho() != null)
                    raizSub = raizSub.subarbolDcho();

                //else if (raizSub.subarbolIzdo() == null && raizSub.subarbolDcho() != null)
                //    raizSub = raizSub.subarbolDcho();

                //else if (raizSub.subarbolDcho() == null && raizSub.subarbolIzdo() != null)
                //{
                //    raizSub = raizSub.subarbolDcho();
                //}

                //else if (raizSub.subarbolDcho() == null && raizSub.subarbolIzdo() == null)    
                if (dato.EsDistinto(raizSub2.valorNodo()))
                {
                    raizSub2 = raizSub2.subarbolDcho();

                    while (!encontrado && raizSub2 != null)
                    {
                        if (dato.EsigualQue(raizSub2.valorNodo()))
                            encontrado = true;
                        else if (raizSub2.subarbolIzdo() != null)
                            raizSub2 = raizSub2.subarbolIzdo();

                        else if (raizSub2.subarbolDcho() != null)
                            raizSub2 = raizSub2.subarbolDcho();

                        //else if (raizSub2.subarbolIzdo() == null && raizSub2.subarbolDcho() != null)
                        //    raizSub2 = raizSub2.subarbolDcho();

                        //else if (raizSub2.subarbolDcho() == null && raizSub2.subarbolIzdo() != null)
                        //{
                        //    raizSub2 = raizSub2.subarbolDcho();
                        //}
                    }
                    return raizSub2;
                }



            }
            return raizSub;


        }




        public Nodo buscarIterativoSer(Object buscado)
        {
            Comparador dato;
            bool encontrado = false;
            Nodo raizSub = raiz;
            Nodo raizSub2 = raiz;

            dato = (Comparador)buscado;
            while (!encontrado && raizSub != null)
            {
                if (dato.EsigualQue(raizSub.valorNodo()))
                {
                    encontrado = true;
                    return raizSub;
                }

                else if (dato.EsDistinto(raizSub.valorNodo()))
                {
                    while (raizSub.subarbolIzdo() != null)
                    {
                        raizSub = raizSub.subarbolIzdo();
                        if (dato.EsigualQue(raizSub.valorNodo()))
                        {
                            encontrado = true;
                            return raizSub;
                        }
                        if (dato.EsDistinto(raizSub2.valorNodo()))
                        {
                            while (raizSub2.subarbolDcho() != null)
                            {
                                raizSub2 = raizSub2.subarbolDcho();
                                if (dato.EsigualQue(raizSub2.valorNodo()))
                                {
                                    encontrado = true;
                                    return raizSub2;
                                }
                            }
                            break;
                        }

                    }
                }

            }
            return null;
        }




        public Nodo buscar2(Object buscado)
        {
            Comparador dato;
            dato = (Comparador)buscado;
            if (raiz == null)
                return null;
            else
                return buscar2(raizArbol(), dato);
        }

        protected Nodo buscar2(Nodo raizSub, Comparador buscado)
        {
            if (raizSub == null)
                return null;
            else if (buscado.EsigualQue(raizSub.valorNodo()))
                return raizSub;
            while (raizSub.subarbolIzdo() != null)
            {
                return buscar2(raizSub.subarbolIzdo(), buscado);
            }
            while (raizSub.subarbolDcho() != null)
            {
                return buscar2(raizSub.subarbolDcho(), buscado);
            }
            while (raizSub.subarbolIzdo() == null && raizSub.subarbolDcho() == null)
            {
                return buscar2(raizArbol().subarbolDcho(), buscado);
            }


            return null;
        }




        public Nodo buscarIterativo2(Object buscado)
        {
            Comparador dato;
            bool encontrado = false;
            Nodo raizSub = raiz;
            Nodo raizSub2 = raiz;
            dato = (Comparador)buscado;
            while (!encontrado && raizSub != null)
            {
                if (dato.EsigualQue(raizSub.valorNodo()))
                {
                    encontrado = true;
                }
                //SI ES DISTINTO RECORRE EL LADO IZQUIERDO    
                else if (dato.EsDistinto(raizSub.valorNodo()))
                {
                    //while sergio
                    raizSub = raizSub.subarbolIzdo();
                    while (!encontrado && raizSub != null)
                    {
                        if (dato.EsigualQue(raizSub.valorNodo()))
                        {
                            encontrado = true;
                        }

                        else if (dato.EsDistinto(raizSub.valorNodo()))
                        {
                            raizSub2 = raizSub2.subarbolDcho();
                            while (!encontrado && raizSub2 != null)
                            {
                                if (dato.EsigualQue(raizSub2.valorNodo()))
                                {
                                    encontrado = true;
                                    return raizSub2;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }

            }
            return raizSub;
        }




        public void insertar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = insertar(raiz, dato);
        }

        //método interno para realizar la operación
        protected Nodo insertar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
                raizSub = new Nodo(dato);
            else if (dato.menorQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = insertar(raizSub.subarbolIzdo(), dato);
                raizSub.ramaIzdo(iz);
            }
            else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = insertar(raizSub.subarbolDcho(), dato);
                raizSub.ramaDcho(dr);
            }
            else throw new Exception("Nodo duplicado");
            return raizSub;
        }


        public void eliminar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = eliminar(raiz, dato);
        }

        //método interno para realizar la operación
        protected Nodo eliminar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
                throw new Exception("No encontrado el nodo con la clave");
            else if (dato.menorQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = eliminar(raizSub.subarbolIzdo(), dato);
                raizSub.ramaIzdo(iz);
            }
            else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = eliminar(raizSub.subarbolDcho(), dato);
                raizSub.ramaDcho(dr);
            }
            else // Nodo encontrado
            {
                Nodo q;
                q = raizSub; // nodo a quitar del árbol
                if (q.subarbolIzdo() == null)
                    raizSub = q.subarbolDcho();
                else if (q.subarbolDcho() == null)
                    raizSub = q.subarbolIzdo();
                else
                { // tiene rama izquierda y derecha
                    q = reemplazar(q);
                }
                q = null;
            }
            return raizSub;
        }



        public Nodo eliminar2(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            if (raiz == null)
                return null;
            else
                return eliminar2(raiz, dato);
            //raiz = eliminar2(raizArbol(), dato);

        }

        //método interno para realizar la operación
        protected Nodo eliminar2(Nodo raizSub, Comparador dato)
        {
            //if (raizSub == null)
            //     throw new Exception("No encontrado el nodo con la clave");
            if (raizSub == null)
                return null;
            else if (dato.EsDistinto(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = eliminar2(raizSub.subarbolIzdo(), dato);
                raizSub.ramaIzdo(iz);

                if (dato.EsDistinto(raizSub.valorNodo()))
                {
                    Nodo dr;
                    dr = eliminar2(raizSub.subarbolDcho(), dato);
                    raizSub.ramaDcho(dr);
                }
            }

            else // Nodo encontrado
            {
                Nodo q;
                q = raizSub; // nodo a quitar del árbol
                if (q.subarbolIzdo() == null)
                    raizSub = q.subarbolDcho();
                else if (q.subarbolDcho() == null)
                    raizSub = q.subarbolIzdo();
                else
                { // tiene rama izquierda y derecha
                    q = reemplazar(q);
                }
                q = null;
            }
            return raizSub;
        }


        // método interno para susutituir por el mayor de los menores
        private Nodo reemplazar(Nodo act)
        {
            Nodo a, p;
            p = act;
            a = act.subarbolIzdo(); // rama de nodos menores
            while (a.subarbolDcho() != null)
            {
                p = a;
                a = a.subarbolDcho();
            }
            act.nuevoValor(a.valorNodo());
            if (p == act)
                p.ramaIzdo(a.subarbolIzdo());
            else
                p.ramaDcho(a.subarbolIzdo());
            return a;
        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TautologiaContingenciaContradiccion
{
    public class Operaciones
    {
        public bool Implicacion(Variable P, Variable Q)
        {
            if (P.Retorno() && !Q.Retorno())
                return false;
            return true;
        }
        public bool Conjuncion(Variable P, Variable Q)
        {
            if (P.Retorno() && Q.Retorno())
                return true;
            return false;
        }
        public bool Diyuncion(Variable P, Variable Q)
        {
            if (!P.Retorno() && !Q.Retorno())
                return false;
            return true;
        }
        public bool Bicondicional(Variable P, Variable Q)
        {
            if (P.Retorno() == Q.Retorno())
                return true;
            return false;
        }
        public bool DiyuncionExclusiva(Variable P, Variable Q)
        {
            if (P.Retorno() == Q.Retorno())
                return false;
            return true;
        }
        public Variable DevolverParentesis(Variable P, Variable Q,int accion)
        {
            bool aux;
            switch(accion)
            {
                case 0:
                    aux = Conjuncion(P, Q);
                    break;
                case 1:
                    aux = Diyuncion(P, Q);
                    break;
                case 2:
                    aux = DiyuncionExclusiva(P, Q);
                    break;
                case 3:
                    aux = Implicacion(P, Q);
                    break;
                default:
                    aux = Bicondicional(P, Q);
                    break;
            }
            return new Variable(aux);
        }
    }
}

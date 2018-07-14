using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TautologiaContingenciaContradiccion
{
    public class Variable
    {
        private bool Valor;
        public Variable(bool Negado, string Valor)
        {
            bool valor = (Valor == "V") ? true : false;
            if (Negado)
                this.Valor = !valor;
            else
                this.Valor = valor;
        }
        public Variable(bool Valor)
        {
            this.Valor = Valor;
        }
        public bool Retorno()
        {
            return Valor;
        }
    }
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Negocios;

/**
 *
 * @author Gabriel
 */
public class Variable {
    private boolean Valor;
        public Variable(boolean Negado, String Valor)
        {
            boolean valor = (Valor == "V") ? true : false;
            if (Negado)
                this.Valor = !valor;
            else
                this.Valor = valor;
        }
        public Variable(boolean Valor)
        {
            this.Valor = Valor;
        }
        public boolean Retorno()
        {
            return Valor;
        }
}

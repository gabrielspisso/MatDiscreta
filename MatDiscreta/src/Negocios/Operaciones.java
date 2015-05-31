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
public class Operaciones {
    public Variable P[] = new Variable[8];
    public Variable Q[] = new Variable[8];
    public Variable R[] = new Variable[8];
    public Operaciones (){
        for (int i = 0; i < 8; i++) {
            P[i] = new Variable((i<=4));//Se debe pasar un valor true o false, pase una condicion
            R[i] = new Variable((i%2==0));
        }
        for (int i = 0; i < 4; i++) {
            boolean aux = (i%2==0);
            for (int j = 0; j < 2; j++) {
                Q[i] = new Variable(aux);
            }
        }
    }

    public boolean Implicacion(Variable P, Variable Q){
            if (P.Retorno() && !Q.Retorno())
                return false;
            return true;
    }
    public boolean Conjuncion(Variable P, Variable Q){
        if (P.Retorno() && Q.Retorno())
                return true;
        return false;
    }
    public boolean Diyuncion(Variable P, Variable Q){
        if (!P.Retorno() && !Q.Retorno())
            return false;
        return true;
    }
    public boolean Bicondicional(Variable P, Variable Q){
        if (P.Retorno() == Q.Retorno())
            return true;
        return false;
    }
    public boolean DiyuncionExclusiva(Variable P, Variable Q){
        if (P.Retorno() == Q.Retorno())
            return false;
        return true;
    }
    public Variable DevolverParentesis(Variable P, Variable Q,int accion){
        boolean aux;
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

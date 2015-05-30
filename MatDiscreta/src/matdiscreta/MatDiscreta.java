/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package matdiscreta;

/**
 *
 * @author Gabriel
 */
public class MatDiscreta {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("Hello negras");
        Variable P[] = new Variable[8];
        Variable Q[] = new Variable[8];
        Variable R[] = new Variable[8];
        
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
    
}

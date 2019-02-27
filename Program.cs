using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program {

    public static void Main (string[] args) {

        Vector3 pos1 = new Vector3(0, 0, 0);
        Carro Carro1 = new Carro(pos1);

        Carro1.pintarTodo();
        Carro1.abretodo();
    }


}

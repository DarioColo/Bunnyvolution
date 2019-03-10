using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE
public class ClienteChain : MonoBehaviour {
	void Start () {
        Eslabon move1 = GetComponent<Eslabon>();
        Eslabon move2 = new Eslabon("Ohayoo");
        Eslabon move3 = new Eslabon("Konbanwa");
        Eslabon move4 = new Eslabon("Konnichiwa");

        move1.SetNext(move2);
        move2.SetNext(move3);
        move3.SetNext(move4);

        move1.Responsabilidad();

	}	
	void Update () {
		
	}
}
public class ClientChain1 : MonoBehaviour //PracticaPRE1
{
    void Start()
    {
        Eslabon1 uno = new Eslabon1("uno");
        Eslabon1 dos = new Eslabon1("dos");
        uno.SetNext(dos);
        uno.Responsability();
    }
}

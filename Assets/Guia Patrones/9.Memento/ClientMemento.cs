using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//5ª CLASE
public class ClientMemento : Remind {

    //estados
    public float life;
    public float gold;
	
	void Start () {
        memento = new MementoState(); //Creamos nuestro memento
        StartCoroutine(StartToRec()); //Iniciamos la grabacion de nuestro estado
	}
	void Update () {
		//Movimiento
	}

    public override void BeRemind(ParamsMemento wrappers)
    {
        //Ubicamos las cosas para saber las posiciones en los inidices y 
        //despues pasarlo como parametros a la grabadora
        transform.position = (Vector3)wrappers.parameters[0];
        transform.rotation = (Quaternion)wrappers.parameters[1];
        life = (float)wrappers.parameters[2];
        gold = (float)wrappers.parameters[3];
    }

    public override IEnumerator StartToRec()
    {
        while (true)
        {
            //Llamamos a la grabadora y le pasamos los parametros (pos, rot, vida, oro, etc)
            memento.Rec(new object[] { transform.position, transform.rotation, life, gold });
        }
    }
}

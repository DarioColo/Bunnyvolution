using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ManagerMemento : MonoBehaviour {

    List<Remind> allRewind; //Lista de objetos que pueden volver en el tiempo
	void Start () {
        allRewind = FindObjectsOfType<Remind>().ToList();
	}
	void Update () {
        //Detonantes para volver en el tiempo
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (var item in allRewind)
            {
                item.Action();
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//5ª CLASE - CLIENTE
//Clase que usa el patron
public class PlayerClient : MonoBehaviour {

    public View view; //V
    IController mouseController; //C
	
	void Start () {
        Model _m = new Model(transform); //M
        mouseController = new ControllerMouse(_m, view);		 
	}
	void Update () {
		//Controller.OnUpdate(); <-----modificamos al model
	}
}

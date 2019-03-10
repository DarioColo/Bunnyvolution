using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//2ª CLASE
//
public class Model { //No hereda de mono porque tiene datos que no van a interactuar con unity

    public event Action<int> onDamage = delegate { }; //Mas adelante guardamos metodos acá
    Transform xf;
    String _name;

    public Model(Transform t) { xf = t; }
    
    //Resto de las funciones que una vez llamadas modifican al model en si y al view.
    public void OnMove(Vector3 p) { xf.position += p; }
    public void TakeDamage() { /*etc...*/ }
    public string ReturnName() { return _name; } //Aca tiene que ver con el view. puede haber una funcion que lo modifique, modificando asi al view
}

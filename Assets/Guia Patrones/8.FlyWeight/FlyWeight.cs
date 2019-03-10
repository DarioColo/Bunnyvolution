using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1ª CLASE
public class FlyWeight { //No hace falta que sea mono porque no interactua con unity

    //Variables compartidass
    public int life;
    public float speed;
    public Vector3 direction;
}
public class FlyWeight1 //PracticaPRE1
{
    public int life;
    public float speed;
    public void Move() { }
}
public class FlyWeight2 //PracticaPRE2
{
    public int life;
    public float speed;
}
public class FlyWeight3
{
    public string nname;
    public int life;
    public float speed;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE
public class FlyWeightPointer { //Tampoco mono

    //Readonly para evitar modificaciones
    public static readonly FlyWeight StateNormal = new FlyWeight
    {
        life = 10,  //<-------------comas! no ";"
        speed = 50,
        direction = Vector3.zero,
    };

    public static readonly FlyWeight StateEnemies = new FlyWeight
    {
        life = 5,
        speed = 80,
        direction = Vector3.forward,
    };
}
public class FlyweightPointer1 //PractiaPRE1
{
    public static readonly FlyWeight1 StateNormal = new FlyWeight1
    {
        life = 10,
        speed = 50,        
    };
    public static readonly FlyWeight1 StateEnemy = new FlyWeight1
    {
        life = 5,
        speed = 70,
    };
}
public class FlyWeightPointer2 //PracticaPRE2
{
    public static readonly FlyWeight2 StateNormal = new FlyWeight2
    {
        life = 5,
        speed = 50,
    };
    public static readonly FlyWeight2 StateEnemy = new FlyWeight2
    {
        life = 10,
        speed = 70,
    };
}
public class FlyWeightPointer3
{
    public static readonly FlyWeight3 StateNormal = new FlyWeight3
    {
        nname = "sanchez",
        life = 1000,
        speed = 1000,
    };
}

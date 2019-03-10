using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE
//Productos de las fabricas concretas.
public class Circle : IShape
{
    public void Shape()
    {
        //DEVOLVER CIRCULO como un prefab 
    }
}
public class Square : IShape
{
    public void Shape()
    {
        //DEVOLVER CUADRADO como un prefab 
    }
}
public class FormaCircular : IShape3
{
    public void Shape() { }
}

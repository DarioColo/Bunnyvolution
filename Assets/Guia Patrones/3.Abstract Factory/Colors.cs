using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE
//Productos de las fabricas concretas.
public class Blue : IColor
{
    public void Color()
    {
        //DEVOLVER COLOR AZUL recibe el prefab al que le coloca el color
    }
}
public class Red : IColor
{
    public void Color()
    {
        //DEVOLVER COLOR ROJO recibe el prefab al que le coloca el color
    }
}
public class Violet : IColor1 //PracticaPRE1
{
    public void Color() { }
}
public class FormaGeometrica : IShape1 { public void Shape() { } }

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4ª CLASE
//Fabrica concreta
public class ColorFactory : AbstractFactory
{
    //Devuelve el obj con la interfaz, dependiendo de lo que se le pida por parametro 
    public override IColor GetColor(string c)
    {
        if (c == "AZUL") return new Blue();
        if (c == "ROJO") return new Red();
        else return null;
    }

    public override IShape GetShape(string s)
    {
        throw new NotImplementedException();  //Nada porque no es su area
    }
}
public class ColorFactory1 : AbstractFactory1 //PracticaPRE1
{
    public override IColor1 GetColor(string color)
    {
        if (color == "violeta") return new Violet();
        else return null; //O un color base
    }
    public override IShape1 GetShape(string shape) { throw new NotImplementedException(); }
}
public class ShapeFactory1 : AbstractFactory1
{
    public override IColor1 GetColor(string color) { throw new NotImplementedException(); }
    public override IShape1 GetShape(string shape)
    {
        if (shape == "forma") return new FormaGeometrica();
        else return null; //O una forma base
    }
}

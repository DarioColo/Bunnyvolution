using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4ª CLASE
//Fabrica concreta
public class ShapeFactory : AbstractFactory
{
    public override IColor GetColor(string c)
    {
        throw new NotImplementedException(); //Nada porque no es su area
    }

    //Devuelve el obj con la interfaz, dependiendo de lo que se le pida por parametro 
    public override IShape GetShape(string s)
    {
        if (s == "CIRCULO") return new Circle();
        if (s == "CUADRADO") return new Square();
        else return null;
    }
}
public class FabricaForma : FactoriaAbstracta
{
    public override IShape3 GetShape(string s)
    {
        if (s == "formacircular") return new FormaCircular();
        else return null;
    }
}

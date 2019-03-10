using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE
public class Eslabon : MonoBehaviour, IChain {
    IChain _next;
    string _transform;
    public Eslabon(string transform)
    {
        _transform = transform;
    }
    public void SetNext(IChain next)
    {
        _next = next;
    }
    public void Responsabilidad()
    {
        //ACCION
        Debug.Log(_transform);     
        if (_next != null) _next.Responsabilidad(); //Continuar la cadena repitiendo accion si existe un next
    }

}
public class Eslabon1 : IChain1 //PracticaPRE1
{
    IChain1 _next;
    string _name; //Para el ejemplo de cadena
    public Eslabon1(string name) { _name = name; } //para el ejemplo de cadena
    public void SetNext(IChain1 next) { _next = next; }
    public void Responsability()
    {
        //ACCION
        Debug.Log(_name); //Para el ejemplo de cadena

        if (_next != null) _next.Responsability();
    }
}
public class Eslabon2 : IChain2 //PracticaPRE2
{
    IChain2 _next;
    public void SetNext(IChain2 next) { _next = next; }
    public void Responsability()
    {
        //ACCION
        if (_next != null) _next.Responsability();
    }
}

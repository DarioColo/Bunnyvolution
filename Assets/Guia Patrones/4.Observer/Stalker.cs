using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4ª CLASE - Suscriptores
public class Stalker : MonoBehaviour, IObserver {

    IObservable _observado; //A quien se va a observar.

    void Awake()
    {
        _observado = FindObjectOfType<Observado>(); //Lo buscamos
        _observado.Subscribe(this); //y nos subscribimos a él
    }

    public void OnNotify(string pass)
    {
        if (pass == "jump") Jump();
        //if (pass == "life") Life();
    }  
    public void Jump() { /*Codigo...*/ }
    public void Life() { /*Codigo...*/ }

    //Al morir nos desuscribimos
    public void OnDie() { _observado.UnSubscibe(this); } 
}
public class Suscriptor : MonoBehaviour, IObserver1 //PracticaPRE1
{
    IObservable1 _observado;
    void Awake()
    {
        _observado = FindObjectOfType<Observado1>();
        _observado.Subscribe(this);
    }
    public void Jump() { }
    public void Walk() { }
    public void OnNotify(string pass)
    {
        if (pass == "jump") Jump();
        if (pass == "walk") Walk();
    }
}
public class Suscriptor1 : MonoBehaviour, IObserver2 //PracticaPRE2
{
    IObservable2 _observado;
    void Awake()
    {
        _observado = FindObjectOfType<Observado2>();
        _observado.Subscribe(this);
    }
    void Kill() { }
    public void OnNotify(string pass)
    {
        if (pass == "matar") Kill();
    }
}
public class Stalker3 : MonoBehaviour, IObserver3
{
    IObservable3 _target;
    void Awake()
    {
        _target = FindObjectOfType<Observado3>();
        _target.Subscribe(this);
    }
    void Shoot() { }
    public void OnNotify(string pass)
    {
        if (pass == "disparar") Shoot();
    }
}
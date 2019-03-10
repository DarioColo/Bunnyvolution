using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3º CLASE - Revista
public class Observado : MonoBehaviour, IObservable { //Es mono para que los stalkers puedan usar FindObject

    //Lista de los stalkers.
    List<IObserver> _observadores = new List<IObserver>(); 

    //Funciones para guardar/quitar stalkers
    public void Subscribe(IObserver stalker){
        if (!_observadores.Contains(stalker)) _observadores.Add(stalker);
    }
    public void UnSubscibe(IObserver stalker){
        if (_observadores.Contains(stalker)) _observadores.Remove(stalker);
    } 

    //Cuando se detona un cambio se recorre a los observadores y se les notifica.
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var stalker in _observadores) {
                //Al pasarle tal string va a llamar a la funcion correspondiente.
                stalker.OnNotify("jump"); 
            }
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            foreach (var stalker in _observadores)
            {
                stalker.OnNotify("life");
            }
        }
    }
}
public class Observado1 : MonoBehaviour, IObservable1 //PracticaPRE1    
{
    List<IObserver1> _suscriptores = new List<IObserver1>();
    public void Subscribe(IObserver1 obs) { if(!_suscriptores.Contains(obs)) _suscriptores.Add(obs); }
    public void UnSubscribe(IObserver1 obs) { if(_suscriptores.Contains(obs)) _suscriptores.Remove(obs); }
    void Update()
    {
        if (Input.GetMouseButton(1)) {
            foreach (var suscriptor in _suscriptores)
            {
                suscriptor.OnNotify("jump");
            }
        }
    }
}
public class Observado2 : MonoBehaviour, IObservable2 //PracticaPRE2
{
    List<IObserver2> _suscriptores = new List<IObserver2>();
    public void Subscribe(IObserver2 obs) { if (!_suscriptores.Contains(obs)) _suscriptores.Add(obs); }
    public void UnSubscribe(IObserver2 obs) { if (_suscriptores.Contains(obs)) _suscriptores.Remove(obs); }
    void Update() {
        if (Input.GetMouseButton(0)) {
            foreach (var suscriptor in _suscriptores)
            {
                suscriptor.OnNotify("matar");
            }
        }
    }
}
public class Observado3 : MonoBehaviour, IObservable3
{
    List<IObserver3> _suscriptores = new List<IObserver3>();
    public void Subscribe(IObserver3 obs) { if (!_suscriptores.Contains(obs)) _suscriptores.Add(obs); }
    public void Unsubscribe(IObserver3 obs) { if (_suscriptores.Contains(obs)) _suscriptores.Remove(obs); }
    void Update()
    {
        //si aprieto una tecla
        foreach (var item in _suscriptores)
        {
            item.OnNotify("disparar");
        }
    }
}
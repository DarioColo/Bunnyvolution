using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE - Interfaz - revista
public interface IObservable{

    void Subscribe(IObserver observer);
    void UnSubscibe(IObserver observer);
}
public interface IObservable1 //PracticaPRE1
{
    void Subscribe(IObserver1 obs);
    void UnSubscribe(IObserver1 obs);
}
public interface IObservable2 //PracticaPRE2
{
    void Subscribe(IObserver2 obs);
    void UnSubscribe(IObserver2 obs);
}
public interface IObservable3
{
    void Subscribe(IObserver3 obs);
    void Unsubscribe(IObserver3 obs);
}
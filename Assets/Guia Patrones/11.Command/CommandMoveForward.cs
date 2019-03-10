using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE
public class CommandMoveForward : ICommand //Clase de la acción
{
    Transform _transform; //Tipo al que command va a modificar con la acción
    public CommandMoveForward(Transform transform) //Constructor para setear el tipo en el momento de la creación
    {
        _transform = transform;
    }
    public void Move()
    {
        _transform.position += Vector3.forward;
    }

    public void Redo()
    {
        _transform.position += -Vector3.forward; //Siempre accion contraria a la accion original
    }
}
public class CommandMoveForward1 : ICommand1 //PracticaPRE1
{
    Transform _transform;
    public CommandMoveForward1(Transform t) { _transform = t; }
    public void Move() { _transform.position += Vector3.forward * 5 * Time.deltaTime; }
    public void Redo() { _transform.position += -Vector3.forward * 5 * Time.deltaTime; }
}
public class CommandMoveForward2 : ICommand2 //PracticaPRE2
{
    Transform _t;
    public CommandMoveForward2(Transform t) { _t = t; }
    public void Move() { _t.position += Vector3.forward; }
    public void Redo() { _t.position += -Vector3.forward; }
}

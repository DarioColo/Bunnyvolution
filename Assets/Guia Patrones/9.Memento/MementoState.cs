using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1º CLASE
public class ParamsMemento
{
    public object[] parameters; //Datos a recordar {posicion, vida, oro, etc}
    public ParamsMemento(params object[] p)
    {
        parameters = new object[p.Length];
        for (int i = 0; i < p.Length; i++)
        {
            parameters[i] = p[i]; //Copiamos de un array a otro
        }
    }
}
public class ParamsMemento1
{
    public object[] parameters;
    public void ParamsMemento(params object[] p)
    {
        parameters = new object[p.Length];
        for (int i = 0; i < p.Length; i++)
        {
            parameters[i] = p[i];
        }
    }
}
public class ParamsMemento2
{
    public object[] parameters;
    public ParamsMemento2(params object[] p)
    {
        parameters = new object[p.Length];
        for (int i = 0; i < p.Length; i++)
        {
            parameters[i] = p[i];
        }
    }
}

//2º CLASE
public class MementoState {

    bool isRemember;
    List<ParamsMemento> rememberState; //Lista de parametros
    public MementoState() { rememberState = new List<ParamsMemento>(); }
    public ParamsMemento Remember() //Volver estados atrás
    {
        isRemember = true;
        var currentState = rememberState[rememberState.Count - 1]; //El anteultimo dato, o sea el estado anterior al actual
        rememberState.RemoveAt(rememberState.Count - 1); //Sacamos para poder seguir retrocediendo
        isRemember = false;

        return currentState;
    }
    public void Rec(params object[] p) //Cuando no esta "recordando" sigue "grabando" estados
    {
        if (isRemember) return;
        rememberState.Add(new ParamsMemento(p));
    }
}
public class MementoState1
{
    bool isRemember;
    List<ParamsMemento2> rememberState;
    public MementoState1() { rememberState = new List<ParamsMemento2>(); }
    public ParamsMemento2 Remember()
    {
        isRemember = true;
        var currentState = rememberState[rememberState.Count - 1];
        rememberState.RemoveAt(rememberState.Count - 1);
        isRemember = false;
        return currentState;
    }
    public void Rec(params object[] p)
    {
        if (isRemember) return;
        rememberState.Add(new ParamsMemento2(p));
    }
}
public class MementoState2
{
    bool isRemember;
    List<ParamsMemento2> rememberState;
    public MementoState2() { rememberState = new List<ParamsMemento2>(); }
    public ParamsMemento2 Remember()
    {
        isRemember = true;
        var currentState = rememberState[rememberState.Count - 1];
        rememberState.RemoveAt(rememberState.Count - 1);
        isRemember = false;
        return currentState;
    }
    public void Rec(params object[] p)
    {
        if (isRemember) return;
        rememberState.Add(new ParamsMemento2(p));
    }
}

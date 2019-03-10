using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASES - Componentes
public class Enemy : IComposite
{
    List<IComposite> components; //Lista de componentes
    string _name; //Datos en comun

    public Enemy(string n) { _name = n; } //Aca obvio pasa lo necesario
    public void Add(IComposite comp) { components.Add(comp); }
    public void Remove(IComposite comp) { components.Remove(comp); }
    public string SetName(string newName) { return _name = newName; } //Etc...
}
public class Enemy1 : IComposite3
{
    List<IComposite3> _components;
    string _name;
    public Enemy1(string name) { _name = name; }
    public void Add(IComposite3 comp) { }
    public void Remove(IComposite3 comp) { }
}
public class Boss : IComposite
{
    List<IComposite> components;
    string _name;

    public void Add(IComposite comp) { components.Add(comp); }
    public void Remove(IComposite comp) { components.Remove(comp); }
    public string SetName(string newName) { return _name = newName; }
}

public class Bullet : IComposite1 //PracticaPRE
{
    List<IComposite1> components = new List<IComposite1>();
    string _name;
    int _life;

    public void Add(IComposite1 comp) { components.Add(comp); }
    public void Remove(IComposite1 comp) { components.Remove(comp); }

    public void SetLife(int life) { _life = life; }
    public void SetName(string newName) { _name = newName; }
}
public class Component : IComposite2
{
    List<IComposite2> components = new List<IComposite2>();

    public void Add(IComposite2 comp) { components.Add(comp); }
    public void Remove(IComposite2 comp) { components.Remove(comp); }
}
public class Component1 : IComposite3
{
    List<IComposite3> _componentes = new List<IComposite3>();

    public void Add(IComposite3 comp)
    {
        _componentes.Add(comp);
    }

    public void Remove(IComposite3 comp)
    {
        _componentes.Remove(comp);
    }
}
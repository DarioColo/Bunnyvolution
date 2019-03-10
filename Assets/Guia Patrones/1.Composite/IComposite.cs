using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1ª CLASE
//Es usada por las componentes (clases) para ser tratadas como lo mismo.
public interface IComposite {
    void Add(IComposite comp); //Agregar componente
    void Remove(IComposite comp); //Remover componente

    //Otras funciones en comun
    string SetName(string newName);
}

public interface IComposite1 //PracticaPre1
{
    void Add(IComposite1 comp);
    void Remove(IComposite1 comp);
    void SetName(string newName);
    void SetLife(int life);
}
public interface IComposite2 //PracticaPRE2
{
    void Add(IComposite2 comp);
    void Remove(IComposite2 comp);
}
public interface IComposite3 //Pra3
{
    void Add(IComposite3 comp);
    void Remove(IComposite3 comp);
}

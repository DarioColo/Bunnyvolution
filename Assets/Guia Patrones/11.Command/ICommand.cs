using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1ª CLASE
public interface ICommand  {
    void Move(); //Acción, Instrucción, comando...etc
    void Redo(); //OPCIONAL, para hacer un redo de las acciones
}
public interface ICommand1 //PracticaPRE1
{
    void Move();
    void Redo();
}
public interface ICommand2 //PracticaPRE2
{
    void Move();
    void Redo();
}

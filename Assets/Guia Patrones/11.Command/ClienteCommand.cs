using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE
public class ClienteCommand : MonoBehaviour {

    ICommand _command; //Accion
    Stack<ICommand> _redos; //Stack para apilar redos, se puede hacer un IEnumerator para que lo haga solo, o por cada vez que se presiona una tecla
    //ICommand _redo; //Redo

	void Start () {
        _redos = new Stack<ICommand>();
	}
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _command = new CommandMoveForward(this.transform); //Creo y guardo la accion
            _command.Move(); //Que haga su accion

            _redos.Push(_command); //Lo apilo en el stack
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            // if(_redo != null) _redo.Redo(); //Con solo un redo
            // StartCoroutine(StartRedos()); //Con corutinas
            if (_redos.Count > 0) _redos.Pop().Redo(); //Apretando cada vez una tecla
        }
	}

    //--------------------------------------------------------
    public IEnumerator StartRedos() //Redo con coroutines
    {
        while (_redos.Count > 0) //Mientras la pila no este vacia
        {
            _redos.Pop().Redo(); //Saca el ultimo y ejecuta la accion CONTRARIA 
            yield return new WaitForSeconds(1);
        }
    }
}
public class ClientCommand1 : MonoBehaviour //PracticaPRE1
{
    ICommand1 _command;
    Stack<ICommand1> _redo;
    void Start() { _redo = new Stack<ICommand1>(); }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _command = new CommandMoveForward1(transform);
            _command.Move();
            _redo.Push(_command);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_redo.Count > 0) _redo.Pop().Redo();
        }
    }
}
public class ClientCommand2 : MonoBehaviour //PracticaPRE2
{
    ICommand2 _command;
    Stack<ICommand2> _redos;
    void Start() { _redos = new Stack<ICommand2>(); }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _command = new CommandMoveForward2(transform);
            _command.Move();
            _redos.Push(_command);
        }
        if (Input.GetKeyDown(KeyCode.R)) { if (_redos.Count > 0) _redos.Pop().Redo(); }
    }
}

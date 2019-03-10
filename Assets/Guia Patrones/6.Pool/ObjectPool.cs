using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE
public class ObjectPool : MonoBehaviour {

    int initialAmount = 10; //Cantidad a instanciar y guardar

    public GameObject prefab; //GO que sea ipoolobject
    Stack<IPoolObject> _object; //Lista de GOs

	void Start () {
        //
        var comp = prefab.GetComponent<IPoolObject>();
       
        _object = new Stack<IPoolObject>();  //Inicializamos lista
        CreateObjects(); //Creamos objs

    }
    void CreateObjects() {
        for (int i = 0; i < initialAmount; i++)
        {
            var obj = Instantiate(prefab); //Instanciamos uno
            obj.transform.parent = transform; //Seteamos su parent
            obj.SetActive(false); //Desactivado
            obj.name = "asd" + i; //ID
            _object.Push(obj.GetComponent<IPoolObject>()); //Pa la lista
        }
    }

    //Aca van las mismas funciones de la interfaz IPoolObject. Desde aca 
    //se llaman a las funciones de cada obj por su interfaz
    public IPoolObject Acquire() {
        //Si nos quedamos sin objetos, creamos otra vez
        if (_object.Count == 0) CreateObjects();

        var o = _object.Pop(); //obtenemos el ultimo
        o.OnAcquire(); //llamamos a la funcion (o sea activarlo)
        return o; //lo devolvemos
    }
    public void Release(IPoolObject o) {
        o.OnRelease(); //llamamos a la funcion (o sea desactivarlo)
        _object.Push(o); //Lo volvemos a meter al stack
    }
}
public class Pool : MonoBehaviour //PracticaPRE1
{
    int _initialAmmount = 10;
    Stack<IPoolObject1> _objects;
    public GameObject prefab;
    void Start()
    {
        _objects = new Stack<IPoolObject1>();
        CreateObjects();
    }
    void CreateObjects()
    {
        for (int i = 0; i < _initialAmmount; i++)
        {
            var obj = Instantiate(prefab);
            obj.transform.parent = transform;
            obj.SetActive(false);
            _objects.Push(obj.GetComponent<IPoolObject1>());
        }
    }
    public IPoolObject1 Acquire()
    {
        if (_objects == null) CreateObjects();
        var obj = _objects.Pop();
        obj.OnAcquire();
        return obj;
    }
    public void Release(IPoolObject1 obj)
    {
        obj.OnRelease();
        _objects.Push(obj);
    }
}
public class Pool1 : MonoBehaviour //PracticaPRE2
{
    int _initialAmmount = 10;
    Stack<IPoolObject> _objects;
    public GameObject prefab;
    void Start()
    {
        _objects = new Stack<IPoolObject>();
        CreateObjects();
    }
    void CreateObjects()
    {
        for (int i = 0; i < _initialAmmount; i++)
        {
            var obj = Instantiate(prefab);
            obj.transform.parent = transform;
            obj.SetActive(false);
            _objects.Push(obj.GetComponent<IPoolObject>());
        }
    }
    public IPoolObject Acquire()
    {
        if (_objects == null) CreateObjects();
        var obj = _objects.Pop();
        obj.OnAcquire();
        return obj;
    }
    public void Release(IPoolObject obj)
    {
        obj.OnRelease();
        _objects.Push(obj);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE
public class ClientFlyWeight : MonoBehaviour {

    int _life;
    float _speed;

	void Start () {
        _life = FlyWeightPointer.StateNormal.life;
	}
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            _life = FlyWeightPointer.StateEnemies.life;
            _speed = FlyWeightPointer.StateNormal.speed;
        }
	}
}
public class ClientFlyWeight1 : MonoBehaviour //PracticaPRE1
{
    int _life;
    float _speed;
    void start()
    {
        _life = FlyweightPointer1.StateNormal.life;
        _speed = FlyweightPointer1.StateNormal.speed;
    }
}
public class ClientFlyWeight2 //PracticaPRE2
{
    int _life;
    float _speed;
    void Start()
    {
        _life = FlyWeightPointer2.StateEnemy.life;
    }
}
public class ClientFlyweight
{
    float life;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            life = FlyWeightPointer3.StateNormal.life;
        }
    }
}

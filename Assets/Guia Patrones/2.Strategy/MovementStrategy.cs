using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE - Todas las clases que implementen la estrategia
public class MovementStrategy : MonoBehaviour {
	
}
public class MoveFastStrategy : MonoBehaviour, IStrategy {

    Transform _transform;
    float _speed = 10;

    public MoveFastStrategy(Transform transform) {
        _transform = transform;
    }

    public void Move()
    {
        _transform.transform.position += transform.forward * _speed * Time.deltaTime;
    }
}

public class MoveSlowStrategy : MonoBehaviour, IStrategy {

    Transform _transform;
    float _speed = 5;

    public MoveSlowStrategy(Transform transform) {
        _transform = transform;
    }

    public void Move()
    {
        _transform.transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
public class JumpStrategy : IStrategy1 //PracticaPRE1
{
    Transform _transform;

    public JumpStrategy(Transform t) { _transform = t; }
    public void Move() { /*accion de saltar*/ }
}
public class MoveForwardStrategy : IStrategy2 //PracticaPRE2
{
    Transform _transform;
    float speed = 5;
    public MoveForwardStrategy(Transform t) { _transform = t; }
    public void Move()
    {
        _transform.position += _transform.forward * speed * Time.deltaTime;
    }
}
public class StrategyMoverAdelante : IStrategy3
{
    Transform _transform;
    float _speed = 5;
    public StrategyMoverAdelante(Transform t) { _transform = t; }
    public void Move()
    {
        _transform.position += _transform.forward * _speed * Time.deltaTime;
    }
}
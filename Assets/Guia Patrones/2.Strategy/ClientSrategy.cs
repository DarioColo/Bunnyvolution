using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE - CLIENTE - usar las estrategias
public class ClientSrategy : MonoBehaviour {

    IStrategy _currentMoveStrategy;
    IStrategy _moveFastStrategy;
    IStrategy _moveSlowStrategy;

    void Awake() {
        _moveFastStrategy = new MoveFastStrategy(transform);
        _moveSlowStrategy = new MoveSlowStrategy(transform);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) _currentMoveStrategy = _moveFastStrategy;
        if (Input.GetKey(KeyCode.B)) _currentMoveStrategy = _moveSlowStrategy;

        if(_currentMoveStrategy != null)
            _currentMoveStrategy.Move();
    }
}

public class ClientStrategy1 : MonoBehaviour //PracticaPRE1
{
    IStrategy1 _currentStrategy;
    IStrategy1 _jumpStrategy;
    void Awake() {
        _jumpStrategy = new JumpStrategy(transform);
    }
    void Update()
    {
        if (Input.GetMouseButton(1)) { _currentStrategy = _jumpStrategy; }
        if (_currentStrategy != null) _currentStrategy.Move();
    }
}
public class ClientStrategy2 : MonoBehaviour //PracticaPRE2
{
    IStrategy2 _currenS;
    IStrategy2 _moveS;

    void Awake()
    {
        _moveS = new MoveForwardStrategy(transform);
    }
    void Update()
    {
        if (Input.GetMouseButton(1)) { _currenS = _moveS; }
        if (_currenS != null) _currenS.Move();
    }
}
public class StrategyClient : MonoBehaviour
{
    IStrategy3 _currentStrategy;
    IStrategy3 _moverAdelante;
    void Awake() { _moverAdelante = new StrategyMoverAdelante(transform); }
    void Update()
    {
        //si aprieto una tecla
        _currentStrategy = _moverAdelante;
        if (_currentStrategy != null) _currentStrategy.Move();
    }
}

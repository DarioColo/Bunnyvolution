using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4º CLASE - CONTROLES
public class ControllerMouse : IController
{
    Model _model; //Tiene referencia a ambos.
    View _view;

    //Constructor
    //Lleno las variables y establezco las referencias
    public ControllerMouse(Model m, View v)
    {
        _model = m;
        _view = v;
        _model.onDamage += _view.RepaintLife; //Sin parentesis porque no llamo al metodo para ejecutarlo sino para guardarlo.
    }

    //Detonadores de cambios
    public override void OnUpdate()
    {
        //Cambios en el modelo
        if (Input.GetMouseButton(0))
            _model.OnMove(Vector3.forward);

        /*
         if(recibo daño)
            _model.TakeDamage();
         */ 
    }
}

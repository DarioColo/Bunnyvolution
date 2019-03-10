using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Interactua con la ui 

//3ª CLASE
//(En este casi es unb view de salida)
public class View : MonoBehaviour {

    //ej de info a mostrar:
    public TextMesh myLife;
    string _name;
    Animator _anim;

    //Funciones que van a actualizar o cambiar la info que se le muestre al usuario
    //Para actualizar la vida:
    public void RepaintLife(int life) { myLife.text = life.ToString(); }
    public void PrintName(string name) { /*mostrar nombre*/ }
    public void PlayAnimation() { /*_anim.Idle.Play();*/ }
}

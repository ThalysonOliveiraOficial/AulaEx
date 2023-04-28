using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    float _f1;
    float _f2;

    [SerializeField] int _i1;
    [SerializeField] int _i2;

    [SerializeField] string _t1;
    string _t2;

    [SerializeField] bool _b1;
    bool _b2;

    // > Maior
    // < Menor
    // >= Maior ou Igual
    // <= Menor ou Igual
    // != Diferente
    // == Igual
    // && e
    // || ou

    // Start is called before the first frame update
    void Start()
       
    {

        if(_i1==1)
        {
            Debug.Log("Fase 1 liberada");
        }
        else
        {
            Debug.Log("Fase 1 bloqueado");
        }


        if(_t1== "multiplicação")
        {
            Debug.Log(_i1 * _i2);
           
        }
        else
        {
            Debug.Log(_i1 + _i2);
        }



        if(_i1==2)
        {
            _t1 = "Passagem liberada";
       
        }

        else
        {
            _t1 = "Passagem Bloqueada";
        }
        Debug.Log(_t1);

        if (_i1 == _i2 && _b1 == true)
        {
            Debug.Log("Entrar na Fase");
        }
    }




    void Update()
    {

    }
}
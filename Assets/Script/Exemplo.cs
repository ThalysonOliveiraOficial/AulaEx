using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{
    [SerializeField] int _number;
    [SerializeField] string _text;
    [SerializeField] string _text2 = "não quero pizza";
    [SerializeField] bool _check;
    [SerializeField] float _fNumber;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Variavel Number é: " + _number);
        _number = 2;
        Debug.Log("Valor novo do Number é: " + _number);

        _text = "Quero Pizza";
        Debug.Log("Primeiro texto é " + _text);

        _text = _text2;
        Debug.Log(_text);

        Debug.Log("Boleana" + _check);

        _check = true;
        Debug.Log(_check);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_check);
    }
}

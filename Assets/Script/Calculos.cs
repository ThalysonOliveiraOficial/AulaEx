using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos : MonoBehaviour
{
    [SerializeField] float _n1;
    [SerializeField] float _n2;

    // Start is called before the first frame update
    void Start()
    {
        _n1 = _n1/_n2; //divisão
        Debug.Log("divisão de N1 com N2 é " + _n1);

        _n1 = _n1 * _n2;
        Debug.Log("multiplicação de N1 com N2 é " + _n1);

        _n1 = _n1 + 1;
        _n1 += 1;
        _n1 -= 1;
        _n1++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

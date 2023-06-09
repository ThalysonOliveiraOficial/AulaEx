using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTexto : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] string _texto;

    // Start is called before the first frame update
    void Start()
    {
        if (_texto == "Cube")
        {
            _cube.SetActive(true);
        }
        else
        {
            _cube.SetActive(false);
        }
        //-------------------------

        if(_texto == "Sphere")
        {
            _sphere.SetActive(true);
        }
        
        else
        {
            _sphere.SetActive(false);
        }
        //-------------------------

        if(_texto == "Capsule")
        {
            _capsule.SetActive(true);
        }

        else
        {
            _capsule.SetActive(false);
        }
        //--------------------------

        if (_texto == "Cylinder")
        {
            _cylinder.SetActive(true);
        }
        else
        {
            _cylinder.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

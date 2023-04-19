using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Declarar 3 classes de texto
    //Implementar valor somente na 1°
    //Alterar a 1° variavel

    //Na função Start
    //Concatenar a 1° e 2° na 3° Variavel

    [SerializeField] string _nome = "Jadiscreidilene";
    [SerializeField] string _sobrenome;
    [SerializeField] string _nomeCompleto;

    // Start is called before the first frame update
    void Start()
    {
        _nome = "Kedirene";
        _nomeCompleto = _nome + " " + "de" + " " + _sobrenome;

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

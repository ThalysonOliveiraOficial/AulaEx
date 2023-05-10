using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaMenu : MonoBehaviour
{
    [SerializeField] GameObject _painelInicial;
    [SerializeField] GameObject _painelCarregar;
    [SerializeField] GameObject _personjogo;

    // Start is called before the first frame update

    public void AtivarPainelIniciar()
    {
        _painelInicial.SetActive(true);
        _painelCarregar.SetActive(false);
        _personjogo.SetActive(false);
    }

    public void  AtivarPainelCarregar()
    {
        _painelInicial.SetActive(false);
        _painelCarregar.SetActive(true);
        _personjogo.SetActive(false);
    }

    public void AtivarPainelPerson()
    {
        _painelInicial.SetActive(false);
        _painelCarregar.SetActive(false);
        _personjogo.SetActive(true);
    }
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    */
}
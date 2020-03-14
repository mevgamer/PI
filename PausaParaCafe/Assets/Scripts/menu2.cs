using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class menu2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        options opcao = new options();
        opcao.AplicarPreferencias();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CenaOptions() {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("opcao");
        } 
    }
    public void IniciarJogo()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("fase1BETA");
        }
    }
    public void Sair()
    {
        Application.Quit();
    }

}

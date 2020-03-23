using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endfs1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        options opcao = new options();
        opcao.AplicarPreferencias();
    }
    public void proximo()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("fs2_1");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

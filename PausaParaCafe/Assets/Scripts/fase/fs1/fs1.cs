using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fs1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextF()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("end_fs1");
        }
    }

    public void Voltar()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("start_fs1");
        }
    }
    public void Errou()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

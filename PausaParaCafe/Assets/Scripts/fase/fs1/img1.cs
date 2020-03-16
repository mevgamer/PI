using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class img1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Quest1()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("question_fs1");
        }
    }

    public void Sair()
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fs2_1 : MonoBehaviour
{
    
    public Text DisplayContagem;
    public float Contagem = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        options opcao = new options();
        opcao.AplicarPreferencias();
    }

    // Update is called once per frame
    void Update()
    { 
        timeCountDown();
    }
    public void timeCountDown()
    {
        if (Contagem > 0.0f)
        {
            Contagem -= Time.deltaTime;
            DisplayContagem.text = Contagem.ToString("F0");
        }
        else
        {
            overTime();
        }
    }
    public void overTime()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("overTime2");
    }
    public void Sair()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
        }
    }

    public void NextF()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("end_fs2");
        }
    }

    public void Errou()
    {
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("errou2");
        }
    }

}

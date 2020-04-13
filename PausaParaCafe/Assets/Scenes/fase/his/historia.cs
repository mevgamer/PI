using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class historia : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

    }

    public void hist1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("his1");
    }

    public void hist2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("his2");
    }

    public void hist3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("his3");
    }

    public void start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("start_fs1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

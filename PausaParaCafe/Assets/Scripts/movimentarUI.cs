using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentarUI : MonoBehaviour
{

    public bool mouse;
    

        private void OnMouseDown()
    {
        mouse = true;
        this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        
    }

  

    private void OnMouseUp()
    {
        mouse = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoverUI()
    {
        if(mouse == true)
        {
            OnMouseDown();
        }
        else
        {
            OnMouseUp();

        }
    }



}

// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{

    bool cliclou = false;

    Vector3 PosAnt;

    void Start()
    {
        clicou = false;
    }

    void Update()
    {

        if (Input.GetMouseButtonUp(0){

            clicou = false;

        }

        if (clicou)
        {

            guiTexture.pixelInset.x += Input.mousePosition.x - PosAnt.x;
            guiTexture.pixelInset.y += Input.mousePosition.y - PosAnt.y;
            PosAnt = Input.mousePosition;

        }

    }

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0){

            clicou = true;
            PosAnt = Input.mousePosition;

        }


    }
}
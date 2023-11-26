using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public GameObject panelObject;
    public GameObject panelRestart;

    // Update is called once per frame
    void Update()
    {
        // Verifica si se ha presionado alguna tecla
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destruye el GameObject actual
            panelObject.SetActive(false);
            panelRestart.SetActive(true);
        }
    }
}

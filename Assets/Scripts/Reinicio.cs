using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Si se presiona la tecla "R", reiniciar la escena
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartCurrentScene();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    // Método para reiniciar la escena actual
    void RestartCurrentScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}

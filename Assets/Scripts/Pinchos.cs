using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si la colisi�n involucra al jugador
        if (collision.collider.CompareTag("Player"))
        {
            // Reiniciar la escena
            ReiniciarEscena();
        }
    }

    // M�todo para reiniciar la escena
    void ReiniciarEscena()
    {
        // Obtener el �ndice de la escena actual
        int escenaActual = SceneManager.GetActiveScene().buildIndex;

        // Cargar la misma escena para reiniciarla
        SceneManager.LoadScene(escenaActual);
    }
}
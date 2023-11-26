using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPolvo : MonoBehaviour
{
    public AudioClip sonidoPolvo; // Asigna el sonido de polvo a través del inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Añade un componente AudioSource si no existe
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprueba si la colisión es con una pared (puedes ajustar esto según tu diseño)
        if (collision.gameObject.CompareTag("Ground"))
        {
            ReproducirSonidoPolvo();
        }
    }

    void ReproducirSonidoPolvo()
    {
        if (sonidoPolvo != null && audioSource != null)
        {
            // Reproduce el sonido de polvo
            audioSource.PlayOneShot(sonidoPolvo);
        }
    }
}

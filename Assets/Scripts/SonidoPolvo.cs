using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPolvo : MonoBehaviour
{
    public AudioClip sonidoPolvo; // Asigna el sonido de polvo a trav�s del inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // A�ade un componente AudioSource si no existe
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprueba si la colisi�n es con una pared (puedes ajustar esto seg�n tu dise�o)
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

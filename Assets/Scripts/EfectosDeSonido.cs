using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosDeSonido : MonoBehaviour
{
    public AudioClip hitSound;  // Asigna el efecto de sonido desde el Editor de Unity
    private AudioSource audioSource;
    private bool hasPlayed = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Añade un AudioSource al objeto del jugador si no hay ninguno
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si aún no se ha reproducido el sonido y la colisión es con una pared o suelo
        if (!hasPlayed && collision.gameObject.CompareTag("Ground"))
        {
            // Reproduce el efecto de sonido
            audioSource.PlayOneShot(hitSound);
            hasPlayed = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    // Nombre de la escena a la que se cambiará
    public GameObject nivelactual;
    public GameObject nivelsiguiente;
    public GameObject personaje;
    public Rigidbody2D rbpersonaje;
    public AudioClip clipactual;
    public AudioClip clipsiguiente;

    // Agrega un AudioSource para reproducir la música
    private AudioSource audioSource;

    private void Start()
    {
        // Asegúrate de que haya un AudioSource adjunto a este GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Establece la música actual al iniciar
        audioSource.clip = clipactual;
        audioSource.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entró en el trigger es el jugador
        if (other.CompareTag("Player"))
        {
            // Reinicia la posición del personaje al (0, 0, 0)
            personaje.transform.position = new Vector3(0f, 0f, 0f);
            // Quítale toda la fuerza al personaje
            rbpersonaje.velocity = Vector2.zero;

            // Cambia la música al siguiente nivel
            CambiarMusica(clipsiguiente);

            nivelsiguiente.SetActive(true);
            nivelactual.SetActive(false);
        }
    }

    private void CambiarMusica(AudioClip nuevaMusica)
    {
        // Cambia la música y la reproduce
        audioSource.clip = nuevaMusica;
        audioSource.Play();
    }
}

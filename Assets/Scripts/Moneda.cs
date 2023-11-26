using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private bool recogida = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !recogida)
        {
            Debug.Log("¡Moneda recogida!");
            Destroy(gameObject);
            recogida = true;
        }
    }
}

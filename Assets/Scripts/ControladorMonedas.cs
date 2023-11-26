using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorMonedas : MonoBehaviour
{
    public TextMeshProUGUI contadorText;
    private int contadorMonedas = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Moneda"))
        {
            contadorMonedas++;
            Debug.Log("Moneda recogida. Contador actual: " + contadorMonedas);
            ActualizarContador();
            Destroy(other.gameObject);
        }
    }

    private void ActualizarContador()
    {
        if (contadorText != null)
        {
            contadorText.text = "Monedas: " + contadorMonedas;
        }
    }
}

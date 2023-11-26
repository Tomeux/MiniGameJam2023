using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public float raycastLength = 1.0f; // Longitud del rayo para detectar la pared
    public LayerMask wallLayer; // Capa de la pared

    private void Update()
    {
        // Obtener la posición actual del jugador
        Vector3 playerPosition = transform.position;

        // Lanzar un rayo hacia abajo desde los pies del jugador
        RaycastHit hit;
        if (Physics.Raycast(playerPosition, Vector3.down, out hit, raycastLength, wallLayer))
        {
            HandleWallTouch(hit.normal);
        }
        else if (Physics.Raycast(playerPosition, Vector3.up, out hit, raycastLength, wallLayer))
        {
            HandleWallTouch(-hit.normal);
        }
        else if (Physics.Raycast(playerPosition, Vector3.left, out hit, raycastLength, wallLayer))
        {
            HandleWallTouch(hit.normal, 90f);
        }
        else if (Physics.Raycast(playerPosition, Vector3.right, out hit, raycastLength, wallLayer))
        {
            HandleWallTouch(hit.normal, -90f);
        }
    }

    private void HandleWallTouch(Vector3 wallNormal, float additionalRotation = 0f)
    {
        // Calcular la rotación necesaria para que los pies del jugador estén alineados con la normal de la pared
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, wallNormal);

        // Aplicar la rotación al jugador
        transform.rotation = rotation;

        // Aplicar rotación adicional si es necesario
        transform.Rotate(Vector3.up, additionalRotation);
    }
}

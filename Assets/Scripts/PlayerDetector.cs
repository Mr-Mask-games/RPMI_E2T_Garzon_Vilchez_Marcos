using UnityEngine;

/// <summary>
/// Script que detecta objetos mergeables delante del jugador usando un Raycast
/// </summary>
public class PlayerDetector : MonoBehaviour
{
    // Distancia máxima de detección del Raycast
    public float detectionRange;

    // Referencia al material del jugador
    public Material playerMaterial;

    // Color en el que se resaltará el jugador
    public Color highlightColor;

    // Color original del jugador
    public Color originalColor;

    // Registra si ya está resaltado
    //private bool isHighlighted;

    // Update se ejecuta una vez por frame
    private void Update()
    {
        // Lanzamos un Raycast para detectar objetos mergeables
        bool isHighlighted = (Physics.Raycast(transform.position, transform.forward, detectionRange, LayerMask.GetMask("Mergeable")));
            if (!isHighlighted)
            {
            print("no hay nada");
            // Restaura el color original
            playerMaterial.color = originalColor;
        }
        else
        {
            if (isHighlighted)
            {
                print("objeto a la vista");
                // Resalta al jugador cambiando su color
                playerMaterial.color = highlightColor;
                
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.forward * detectionRange);
    }
}
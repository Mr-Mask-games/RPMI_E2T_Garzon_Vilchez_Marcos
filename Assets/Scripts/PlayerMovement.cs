using UnityEngine;

/// <summary>
/// Script que controla el movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // Velocidad de movimiento del jugador
    public float speed;

    // Update se ejecuta una vez por frame
    private void Update()
    {
        // Comprobamos qué tecla se está pulsando para el movimiento del jugador
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
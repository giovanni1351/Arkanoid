using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public KeyCode moveLeft = KeyCode.A;      // Move a raquete para cima
    public KeyCode moveRight = KeyCode.D;    // Move a raquete para baixo
    public float speed = 10.0f;             // Define a velocidade da raquete
    public float boundX = 2.25f;            // Define os limites em X
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete

    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>(); // Obt�m o componente Rigidbody2D anexado ao GameObject
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.linearVelocity; // Obt�m a velocidade atual da raquete
        if (Input.GetKey(moveLeft))
        {             // Velocidade da Raquete para ir para cima
            vel.x = -speed;
        }
        else if (Input.GetKey(moveRight))
        {      // Velocidade da Raquete para ir para cima
            vel.x = speed;
        }
        else
        {
            vel.x = 0;                          // Velociade para manter a raquete parada
        }
        rb2d.linearVelocity = vel;                    // Atualizada a velocidade da raquete

        var pos = transform.position;           // Acessa a Posi��o da raquete
        if (pos.x > boundX)
        {
            pos.x = boundX;                     // Corrige a posicao da raquete caso ele ultrapasse o limite superior
        }
        else if (pos.x < -boundX)
        {
            pos.x = -boundX;                    // Corrige a posicao da raquete caso ele ultrapasse o limite inferior
        }
        transform.position = pos;               // Atualiza a posi��o da raquete
    }
}

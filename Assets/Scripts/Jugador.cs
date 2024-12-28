using UnityEngine;

public class Jugador : MonoBehaviour
{

    private Rigidbody rb;

    public float speed = 13f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        //crear vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal * speed, rb.linearVelocity.y, moveVertical * speed);

        //asignar el movimiento a la velocidad en el RigidBody
        rb.linearVelocity = movement;

    }

    private void OnCollisionEnter(Collision collision)
    {
        //si choca con un objeto llamado Collectible lo destruye
        if (collision.transform.CompareTag("Collectible"))
        {
            Destroy(collision.gameObject);
        }
    }

}

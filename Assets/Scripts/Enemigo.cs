using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;
    private Transform playerTransform;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        playerTransform = FindAnyObjectByType<Jugador>().transform; //pilla el transform de Jugador
    }
    void Update()
    {
        navMeshAgent.destination = playerTransform.position; //en cada frame busca la posici�n del jugador
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //obtiene el �ndice de la escena activa actual y la vuelve a cargar
        }
    }
}

using UnityEngine;

public class Collectible : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.CompareTag("Player"))
        {

            //encuentra el GameManager en la escena y llama al método AddCollectible
            var gameManager = FindAnyObjectByType<GameManager>();

            if (gameManager != null)
            {
                gameManager.AddCollectible();
            }

            Destroy(gameObject); //destruye el GameObject del script

        }
    }

}

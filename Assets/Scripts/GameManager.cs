using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;

    public TMP_Text collectiblesNumbersText;
    private int collectiblesNumber;

    public TMP_Text totalCollectiblesNumbersText;
    private int totalCollectiblesNumber;

    void Start()
    {
        totalCollectiblesNumber = transform.childCount; //cuenta los elementos que tiene como hijos la clase
        totalCollectiblesNumbersText.text = totalCollectiblesNumber.ToString();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("WIN");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //carga la nueva escena +1
        }
    }

    public void AddCollectible()
    { 
        audioSource.Play();

        collectiblesNumber++;
        collectiblesNumbersText.text = collectiblesNumber.ToString();
    }

}

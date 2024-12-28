using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager musicManager;

    void Start()
    {
        //mantiene solo un musicManager
        if (musicManager == null)
        {
            musicManager = this;
            DontDestroyOnLoad(this.gameObject); 
        }
        else 
        {
            Destroy(this.gameObject);
        }
    }

    
}

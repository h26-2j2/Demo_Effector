using UnityEngine;
using UnityEngine.EventSystems;

public class Jeu : MonoBehaviour
{
    public string test;
    void Awake()
    {
        Jeu instance = GameObject.FindFirstObjectByType<Jeu>();

        if (instance != null && instance.gameObject != this.gameObject)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }


}

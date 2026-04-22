using UnityEngine;

public class GenerateurBoite : MonoBehaviour
{
    public GameObject prefabBoite;
    public float delaiGenerateur = 1f;
    public float delaiDestructeur = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GenererBoite", 0, delaiGenerateur);
    }

    // Update is called once per frame
    void GenererBoite()
    {
        GameObject clone = Instantiate(prefabBoite, transform.position, transform.rotation, transform.parent);
        Destroy(clone, delaiDestructeur);
    }
}

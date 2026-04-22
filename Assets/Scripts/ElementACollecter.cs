using UnityEngine;

public class ElementACollecter : MonoBehaviour
{

    public float limiteGc;
    public float limiteDr;
    public float limiteHaut;
    public JeuRapidite jeuRapidite;

    public string couleur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float positionX = Random.Range(limiteGc, limiteDr);
        transform.position = new Vector2(positionX, limiteHaut);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mur")
        {
            float positionX = Random.Range(limiteGc, limiteDr);
            transform.position = new Vector2(positionX, limiteHaut);
        }
    }

    public void AuClic()
    {
        float positionX = Random.Range(limiteGc, limiteDr);
        transform.position = new Vector2(positionX, limiteHaut);
        if (couleur == "bleu")
        {
            jeuRapidite.miseAJourPoints(1);
        }
    }
}

using UnityEngine;
using TMPro;
public class JeuRapidite : MonoBehaviour
{
    public int points = 0;
    public TMP_Text textePoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miseAJourPoints(0);
    }

    public void miseAJourPoints(int nouveauPoints)
    {
        points += nouveauPoints;
        textePoints.text = $"x {points}";
    }
}

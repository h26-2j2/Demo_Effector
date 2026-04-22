using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BoutonDemarrer : MonoBehaviour
{

    public void AuClic()
    {
        SceneManager.LoadScene("SelectionMenu");
    }
}

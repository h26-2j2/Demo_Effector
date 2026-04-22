using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class GestionCamera : MonoBehaviour
{
    public List<Transform> positions;
    public int indexPosition = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangerCamera();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {

            indexPosition--;
            if (indexPosition < 0)
            {
                indexPosition = positions.Count - 1;
            }
            ChangerCamera();
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {

            indexPosition++;
            if (indexPosition >= positions.Count)
            {
                indexPosition = 0;
            }
            ChangerCamera();
        }
    }

    void ChangerCamera()
    {
        Transform positionCamera = positions[indexPosition];
        Vector3 nouvellePosition = positionCamera.position;
        nouvellePosition.Set(nouvellePosition.x, nouvellePosition.y, -10);
        transform.position = nouvellePosition;
    }
}

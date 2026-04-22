using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class DragBoite : MonoBehaviour
{
    Rigidbody2D rigid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void DebutDrag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector3 nouvellePosition = Camera.main.ScreenToWorldPoint(pointerEventData.position);
        nouvellePosition.z = 0;
        transform.position = nouvellePosition;
        rigid.bodyType = RigidbodyType2D.Static;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector3 nouvellePosition = Camera.main.ScreenToWorldPoint(pointerEventData.position);
        nouvellePosition.z = 0;
        transform.position = nouvellePosition;
    }
    public void FinDrag(BaseEventData baseEventData)
    {
        rigid.bodyType = RigidbodyType2D.Dynamic;
    }
}

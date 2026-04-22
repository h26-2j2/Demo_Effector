using UnityEngine;
using UnityEngine.InputSystem;

public class DeplacementPerso : MonoBehaviour
{
    public InputAction deplacementAction;
    public InputAction sautAction;

    public float vitesse = 5f;
    public float forceSaut = 15f;
    public bool estAuSol;
    public GameObject groundCheck;
    public LayerMask layer;
    Rigidbody2D rigid;

    void OnEnable()
    {
        deplacementAction.Enable();
        sautAction.Enable();
    }
    void OnDisable()
    {
        deplacementAction.Disable();
        sautAction.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        estAuSol = Physics2D.Raycast(groundCheck.transform.position, Vector2.down, 0.1f, layer);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float direction = deplacementAction.ReadValue<float>();
        if (direction != 0)
        {
            rigid.linearVelocityX = direction * vitesse;
        }


        if (estAuSol && sautAction.WasPressedThisFrame())
        {
            rigid.AddForce(Vector2.up * forceSaut, ForceMode2D.Impulse);
        }
        rigid.linearVelocityX = Mathf.Clamp(rigid.linearVelocityX, -25, 25);
        rigid.linearVelocityY = Mathf.Clamp(rigid.linearVelocityY, -25, 25);
    }
}

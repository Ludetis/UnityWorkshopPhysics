using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI.Table;


public class Movement : MonoBehaviour
{

    private Vector3 moveDirection = Vector3.zero;

    public GameObject animatedCharacter;
    public float speed=5f;
    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveDirection * speed;        
        
        animatedCharacter.transform.rotation = 
            Quaternion.Euler(0, Vector3.SignedAngle(Vector3.forward, moveDirection, Vector3.up), 0);
        
        Animator a = animatedCharacter.GetComponent<Animator>();
        if (moveDirection.magnitude != 0)
        {
            a.Play("Walking");
        } else
        {
            a.Play("Standing");
        }
        
    }
}

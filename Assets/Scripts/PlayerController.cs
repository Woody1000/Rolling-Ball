using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool grounded;
    public LayerMask whatIsGround;

    private Rigidbody2D _myRigidbody;
    private Collider2D _myCollider;

    // Start is called before the first frame update
    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();

        _myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(_myCollider, whatIsGround);

        _myRigidbody.velocity = new Vector2(moveSpeed, _myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                _myRigidbody.velocity = new Vector2(_myRigidbody.velocity.x, jumpForce);
            }
        }
    }
}

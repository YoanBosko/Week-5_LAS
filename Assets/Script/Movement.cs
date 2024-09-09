using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public UnityEvent IdleEvent;
    public UnityEvent WalkRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(movement.x), 1, 1);
        }
        if (movement.x == 0 && movement.y == 0)
        {
            IdleEvent?.Invoke();
        }
        else if (Mathf.Abs(movement.x) > 0.01 || Mathf.Abs(movement.y) > 0.01 )
        {
            WalkRight?.Invoke();
        }
    }
    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}

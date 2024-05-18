using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    public float speed = 1f; // швидкість руху героя
    public float jump = 4f; // висота стрибка
    private bool isGrounded;

    SpriteRenderer sr;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        // left: -1
        // right: 1
        
        // переміщуємо героя, використовуючи швидкість [speed]
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;

        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)))
            rb.AddForce(new Vector3(0, jump), ForceMode2D.Impulse);

        if (move < 0) sr.flipX = true;
        
        if (move > 0) sr.flipX = false;
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }
}

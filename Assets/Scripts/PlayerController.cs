using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigid;
    public Animator anim;
    private float moveInput;

    private bool kanan = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = -1 * Input.GetAxis("Horizontal");
        //Debug.Log(moveInput);
        anim.SetFloat("Speed", Mathf.Abs(moveInput));
        rigid.velocity = new Vector2(moveInput * speed, rigid.velocity.y);

        if (moveInput < 0 && kanan == false)
        {
            Flip();
        }
        if(moveInput > 0 && kanan == true)
        {
            Flip();
        }
    }
    void Flip()
    {
        kanan = !kanan;
        Vector3 Scalar = transform.localScale;
        Scalar.x *= -1;
        transform.localScale = Scalar;
    }
}

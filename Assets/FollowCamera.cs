using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject follow;
    private Camera cam;
    public Vector3 offside;

    private float moveInput;
    public float leftLimit;
    public float rightLimit;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = -1 * Input.GetAxis("Horizontal");
       
        if (moveInput < 0)
        {
            cam.transform.position = (follow.transform.position + offside + new Vector3(-2.8f, 0f, 0f));
            cam.transform.position = new Vector3(Mathf.Clamp(transform.position.x, rightLimit, leftLimit),
            transform.position.y, transform.position.z);
        }
        if (moveInput > 0)
        {
            cam.transform.position = (follow.transform.position + offside + new Vector3(2.8f, 0f, 0f));
            cam.transform.position = new Vector3(Mathf.Clamp(transform.position.x, rightLimit, leftLimit),
            transform.position.y, transform.position.z);

        }
        
    }
}

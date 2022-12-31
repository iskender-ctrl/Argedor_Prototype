using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed, mouseSpeed;
    [SerializeField] GameObject cameraRot;
    [SerializeField]
    float yaw = 0f;
    float pitch = 0f;
    Rigidbody rb;
    Animator anim;
    float x, z;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            anim.SetInteger("legs", 2);
        }
        else
        {
            anim.SetInteger("legs", 5);
        }

        //transform.Translate(x, 0, z);

        yaw += mouseSpeed * Input.GetAxis("Mouse X");
        pitch -= mouseSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(0, yaw, 0);
    }
    /*private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        z = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;
        rb.MovePosition(transform.position + (transform.right * x + transform.up * z) * speed);
    }*/
}

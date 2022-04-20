using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector3 jump = new Vector3(0, 2, 0);
    private float horizontalInput;
    private float jumpForce = 4;
    public bool isGrounded = true;
    private Rigidbody playerRB;
    public bool hasPowerUp = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRB.velocity = Vector2.up * jumpForce;
            isGrounded = false;

        }
       
    }
   
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            speed = 10.0f;

        }
        

    }
}

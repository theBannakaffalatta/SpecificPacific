using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float HorizontalSpeed;
    public float VerticalSpeed;
    public float jumpForce;

    public float WalkingSpeed;
    public float RunningSpeed;

    private Rigidbody rb;
    public bool grounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        grounded = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeed;

        transform.Translate(x, 0, z);

        if (Input.GetKey("left shift"))
        {
            VerticalSpeed = RunningSpeed;
        }

        else
        {
            HorizontalSpeed = WalkingSpeed;
            VerticalSpeed = WalkingSpeed;
        }

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            grounded = false;
            Debug.Log("Jump");
        }
    }
}
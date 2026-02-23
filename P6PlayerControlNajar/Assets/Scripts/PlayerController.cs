using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float forwardInput;
    private float horizontalInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    // Start is called once before the first execution of Update after the MonoBehavior is created
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        // Axis setup
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}

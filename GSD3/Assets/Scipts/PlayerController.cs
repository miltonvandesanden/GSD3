using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;

	// Use this for initialization
	void Start(){}
	
	// Update is called once per frame
	void Update()
    {
        rotateCamera();
        handleMovement();
    }

    public void rotateCamera()
    {
        transform.Rotate(new Vector3(/*Input.GetAxis("Mouse Y")/*transform.rotation.y*/0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotationSpeed);
    }

    public void handleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        print("BLUB");
    }
}

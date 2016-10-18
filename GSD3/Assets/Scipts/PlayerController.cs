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
            transform.Translate(calculateMovement(transform.forward));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(calculateMovement(transform.forward));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(calculateMovement(transform.right));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(calculateMovement(transform.right));
        }
    }

    public Vector3 calculateMovement(Vector3 direction)
    {
        return direction * Time.deltaTime * movementSpeed;
    }

    void OnCollisionEnter(Collision col){}
}

using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float input = -1 * Input.GetAxis("Horizontal");

        transform.RotateAround(Vector3.zero, new Vector3(0, 0, 1), input * Time.deltaTime * rotationSpeed);
    }
}

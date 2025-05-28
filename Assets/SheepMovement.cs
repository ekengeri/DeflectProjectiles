using UnityEngine;
using UnityEngine.UIElements;

public class SheepMovement : MonoBehaviour
{

    private bool hasBeenBlocked = false;

    public GameObject flock;
    public GameObject dog;

    public Collider2D flockCollider;
    public Collider2D dogCollider;

    public float sheepSpeed = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, 1), Random.Range(0, 360));

        flock = GameObject.FindGameObjectWithTag("Flock");
        dog = GameObject.FindGameObjectWithTag("Dog");

        flockCollider = flock.GetComponent<Collider2D>();
        dogCollider = dog.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * sheepSpeed * Time.deltaTime;

        if (Mathf.Abs(transform.position.x) > 10 || Mathf.Abs(transform.position.y) > 10)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit a thing");

        if (!hasBeenBlocked && collision.collider == dogCollider)
        {
            hasBeenBlocked = true;
            transform.Rotate(new Vector3(0, 0, 1), 180);
        }

        if (hasBeenBlocked && collision.collider == flockCollider)
        {
            Debug.Log("KILL");
            Destroy(gameObject);
        }
    }
}

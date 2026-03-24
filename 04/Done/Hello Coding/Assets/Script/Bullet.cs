using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletLife = 3f;
    private float bulletSpeed = 6f;
    Rigidbody rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.linearVelocity = transform.forward * bulletSpeed;
        Destroy(gameObject, bulletLife);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerInput>().Die();
        }
    }
}

using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float speed;

    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        direction = Vector3.ClampMagnitude(direction, 1f);

        _rigidbody.linearVelocity = direction * speed;
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}

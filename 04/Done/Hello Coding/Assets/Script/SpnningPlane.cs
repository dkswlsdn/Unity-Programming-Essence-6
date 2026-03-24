using UnityEngine;

public class SpnningPlane : MonoBehaviour
{
    Transform _transform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Rotate(new Vector3(0, Time.deltaTime * 90, 0));
    }
}

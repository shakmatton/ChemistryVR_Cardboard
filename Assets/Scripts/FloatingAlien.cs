using UnityEngine;

public class FloatingAlien : MonoBehaviour
{
    public float amplitude = 0.1f;
    public float speed = 1f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position =
            startPos +
            Vector3.up * Mathf.Sin(Time.time * speed) * amplitude;
    }
}
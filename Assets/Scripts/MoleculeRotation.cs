using UnityEngine;

public class MoleculeRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 15f;

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.World);
    }
}
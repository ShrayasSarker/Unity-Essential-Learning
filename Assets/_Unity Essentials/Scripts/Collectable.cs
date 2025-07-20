using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float rotationSpeed = 50.0f; // Speed at which the collectable rotates.
    public GameObject onCollectEffect; // Effect to instantiate when collected. 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0); // Rotate the collectable object around the Y-axis.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the colliding object has the "Player" tag.
        {
            Destroy(gameObject); // Destroy the collectable object.
            Instantiate (onCollectEffect, transform.position, transform.rotation); // Instantiate the collect effect at the collectable's position and rotation.
        }
    }

}
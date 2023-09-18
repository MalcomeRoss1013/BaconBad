using UnityEngine;

public class Hammer : MonoBehaviour
{
    public float knockbackForce = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a "Destroyer" object.
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            // Calculate the knockback direction.
            Vector3 knockbackDirection = transform.position - collision.contacts[0].point;
            knockbackDirection.Normalize();

            // Apply the knockback force using Rigidbody.AddForce.
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyExploder : MonoBehaviour
{

   
   public GameObject explosionPrefab; // Assign your explosion prefab in the Inspector
    public int maxExplosions = 2; // Set the maximum number of explosions allowed

    private int explosionsCount = 0; // Counter for explosions

    private void OnCollisionEnter(Collision collision)
    {
        if (explosionsCount < maxExplosions && collision.gameObject.CompareTag("Destroyer"))
        {
            Explode(); // Call a method to trigger the explosion
        }
    }

    private void Explode()
    {
        // Instantiate the explosion effect at the enemy's position
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        // Increase the explosion count
        explosionsCount++;

        // Destroy the enemy object
        Destroy(gameObject);

        // Check if the maximum number of explosions has been reached
        if (explosionsCount >= maxExplosions)
        {
            // Do any additional logic when the maximum explosions are reached
            Debug.Log("Maximum explosions reached!");
        }
    }
}

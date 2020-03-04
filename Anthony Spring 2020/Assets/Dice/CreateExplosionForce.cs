using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateExplosionForce : MonoBehaviour
{

    public float radius = 5f; 
    public float force = 700f;
    public Vector3Data ExplosionLocation;

    public void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(ExplosionLocation.Value, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, ExplosionLocation.Value, radius);
                Debug.Log("Exploding???");
            }
        }
    }
}

using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class CharacterControllerMovements : MonoBehaviour
{
    
    public Rigidbody rotator;
    public Vector3 Movement, Rotation;

    public void Start()
    {
        Movement.Set(0,50,0);
    }

    public void Jump()
    {
        rotator.AddForce(Movement);
    }

    public void AddRoll()
    {
        Rotation.Set(Random.Range(-100,100), Random.Range(-100,100), Random.Range(-100,100));
        rotator.AddTorque(Rotation);
    }
}
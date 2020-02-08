using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorsPrototype : MonoBehaviour
{
    public void Explode()
    {
        Transform.Destroy(gameObject);
    }
}

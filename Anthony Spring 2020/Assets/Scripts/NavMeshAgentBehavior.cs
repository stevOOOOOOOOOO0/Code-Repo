using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentBehavior : MonoBehaviour
{

    public NavMeshAgent Controller;
    public Transform Destination;
    
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Controller.SetDestination(Destination.position);
    }
    
    public void StopHunting()
    {
        Destination = Controller.transform;
    }

    public void StartHunting(Transform Location)
    {
        Destination = Location;
    }
}

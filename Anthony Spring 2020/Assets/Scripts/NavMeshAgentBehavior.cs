using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentBehavior : MonoBehaviour
{

    public NavMeshAgent Controller;
    public Vector3 Destination;
    
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Controller.SetDestination(Destination);
    }
    
    public void StopHunting()
    {
        Destination = Controller.transform.position;
    }

    public void StartHunting(Vector3 Location)
    {
        Destination = Location;
    }
}

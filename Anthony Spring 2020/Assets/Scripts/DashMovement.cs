using UnityEngine;
using UnityEngine.AI;

public class DashMovement : MonoBehaviour
{
    
    private NavMeshAgent navMeshAgent;
    public Transform OldLocation;
    public GameObject ActivateMe;
    
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void Dash()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit == true)
        {
            setLocation(OldLocation, transform);
            setRotationToLookAt(OldLocation, transform);
            StartMoveAction(hit.point);
        }
    }
    
    public void setLocation(Transform setee, Transform setTo)
    {
        setee = setTo;
    }

    public void setRotationToLookAt(Transform setee, Transform LookAt)
    {
        setee.LookAt(LookAt);
    }
    
    public void StartMoveAction(Vector3 destination)
    {
        MoveTo(destination);
    }
    
    public void MoveTo(Vector3 destination)
    {
        //controller.Move(destination);
        navMeshAgent.Warp(destination);
    }
    
    public static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
    
    public void Activate()
    {
        ActivateMe.SetActive(true);
        ActivateMe.transform.position = OldLocation.position;
        ActivateMe.transform.rotation = OldLocation.rotation;
    }
}

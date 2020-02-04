using UnityEngine;
using UnityEngine.AI;


public class CharacterMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public GameObject ActivateMe;
    private RaycastHit hit;
    
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    public void InteractWithMovement()
    {
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit)
        {
            Activate();
            navMeshAgent.Warp(hit.point);
        }
    }

    public static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    public void setLocation(Transform setee, Transform setTo)
    {
        setee.position = setTo.position;
    }

    public void setRotationToLookAt(Transform setee, Transform lookAt)
    {
        setee.LookAt(lookAt);
    }
    
    public void Activate()
    {
        ActivateMe.SetActive(true);
        ActivateMe.transform.position = transform.position;
        ActivateMe.transform.LookAt(hit.point);
    }
}

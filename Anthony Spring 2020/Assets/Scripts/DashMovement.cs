using UnityEngine;
using UnityEngine.AI;


public class DashMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private RaycastHit hit;
    public GameObjectListSO AfterImages;
    
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
    
    public void UpdateAnimator()
    {
        Vector3 velocity = navMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
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
        AfterImages.GOList[0].SetActive(true);
        print(AfterImages.GetFirstObj().activeInHierarchy);
        AfterImages.GetFirstObj().transform.position = transform.position;
        AfterImages.GetFirstObj().transform.LookAt(hit.point);
        AfterImages.FirstToLast();
    }
}
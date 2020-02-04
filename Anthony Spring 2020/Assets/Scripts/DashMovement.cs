using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class DashMovement : MonoBehaviour
{

    private Vector3 movementVector;
    private NavMeshAgent navMeshAgent;
    private RaycastHit hit;
    private Vector3 OldLocation;
    public GameObjectListSO AfterImages;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    public void BaseMovement()
    {
        movementVector.Set(Input.GetAxis("Vertical") * .25f, 0, -Input.GetAxis("Horizontal") * .25f);
        navMeshAgent.Move(movementVector);
    }

    public void NavMeshWarp()
    {
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit)
        {
            navMeshAgent.Warp(hit.point);
        }
    }
    
    private static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    public void SetOldLocation()
    {
        OldLocation = transform.position;
    }

    public void Activate()
    {
        AfterImages.GOList[0].transform.position = OldLocation;
        StartCoroutine(FaceTowards(AfterImages.GOList[0], hit.point));
    }

    public IEnumerator FaceTowards(GameObject Looker, Vector3 lookAt)
    {
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        while (hasHit)
        {
            Looker.transform.LookAt(lookAt);
            yield return new WaitForSeconds(0);
        }
    }
    /*private NavMeshAgent navMeshAgent;
    private RaycastHit hit;
    public GameObjectListSO AfterImages;
    private Vector3 movementVector;
    public float speed;
    
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void BaseMovement()
    {
        movementVector.Set(Input.GetAxis("Vertical") * speed, 0, -Input.GetAxis("Horizontal") * speed);
        navMeshAgent.Move(movementVector);
    }
    
    public void Dash()
    {
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit)
        {
            Activate();
            navMeshAgent.Warp(hit.point);
        }
    }

    private static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void Activate()
    {
        //AfterImages.SetFirstActive();
        //print(AfterImages.GetFirstObj().activeInHierarchy);
        AfterImages.GOList[0].transform.position = transform.position;
        AfterImages.GOList[0].transform.LookAt(hit.point);
        //AfterImages.FirstToLast();
    }*/
}
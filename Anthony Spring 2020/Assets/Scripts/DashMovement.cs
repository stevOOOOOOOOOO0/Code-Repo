using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class DashMovement : MonoBehaviour
{

    private Vector3 movementVector, newPosition;
    public CharacterController Controller;
    private RaycastHit hit;
    public AfterImagesSOPrototype AfterImageSO;

    public void BaseMovement()
    {
        AfterImageSO.Location = transform;
        movementVector.Set(Input.GetAxis("Vertical") * .25f, 0, -Input.GetAxis("Horizontal") * .25f);
        Controller.Move(movementVector);
    }

    public void NavMeshWarpToClick()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            newPosition = Vector3.MoveTowards(AfterImageSO.Location.position, hit.point, 1f);
            //Controller.transform.position.Set(newPosition);
        }
    }
}
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class DashMovement : MonoBehaviour
{

    private Vector3 movementVector, newPosition;
    public CharacterController Controller;
    private RaycastHit hit;
    private Vector3 moveDirection;

    public void BaseMovement()
    {
        movementVector.Set(Input.GetAxis("Vertical") * .25f, 0, -Input.GetAxis("Horizontal") * .25f);
        Controller.Move(movementVector);
    }

    public void CharacterControllerMoveToClick()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            moveDirection = hit.point - transform.position;
            moveDirection -= Vector3.forward * 1;
            moveDirection.Set(moveDirection.x, 0, moveDirection.z);
            Controller.Move(moveDirection);
        }
    }
}
using UnityEngine;

public class CharacterControllerMovement : MonoBehaviour
{
    private Vector3 movementVector, direction, DestinationPlaceHolder;
    public CharacterController Controller;
    public float Gravity, MovementMultiplier;
    public Transform Destination;
    public bool HuntingBool;

    public void JumpToHeight(float Height)
    {
        movementVector.Set(0f, Height, 0f);
        Controller.Move(movementVector);
        Gravity = -9.8f;
    }

    public void MoveX(float xValue)
    {
        movementVector.Set(xValue, 0, 0);
        Controller.Move(movementVector * Time.deltaTime);
    }
    
    public void MoveY(float zValue)
    {
        movementVector.Set(0, 0, zValue);
        Controller.Move(movementVector * Time.deltaTime);
    }

    public void Update()
    {
        if (HuntingBool)
        {
            DestinationPlaceHolder = Destination.position;
            DestinationPlaceHolder.y = transform.position.y;
            direction = transform.position - DestinationPlaceHolder;
            direction *= -1;
            Controller.Move(direction.normalized * MovementMultiplier * Time.deltaTime);
        }
        
        movementVector.Set(0f, Gravity -= 9.8f * Time.deltaTime, 0f);
        Controller.Move(movementVector * Time.deltaTime);
    }

    public void SetDestination(Transform newDestination)
    {
        Destination = newDestination;
    }

    public void Hunting(bool huntbool)
    {
        HuntingBool = huntbool;
    }

    public void SetLocation()
    {
        Controller.enabled = false;
        transform.position = Destination.position;
        Controller.enabled = true;
        Controller.Move(direction * Time.deltaTime);
    }
    
}

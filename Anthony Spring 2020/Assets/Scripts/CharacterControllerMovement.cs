using UnityEngine;

public class CharacterControllerMovement : MonoBehaviour
{
    private Vector3 movementVector, direction;
    public CharacterController Controller;
    public float Gravity, MovementMultiplier;
    public Transform Destination;
    public bool HuntingBool;

    public void JumpToHeight(float Height)
    {
        movementVector.Set(0f, Height, 0f);
        Controller.Move(movementVector * Time.deltaTime);
    }

    public void MoveX(float xValue)
    {
        movementVector.Set(xValue, 0f, 0f);
        Controller.Move(movementVector * Time.deltaTime);
    }
    
    public void MoveY(float zValue)
    {
        movementVector.Set(0f, 0f, zValue);
        Controller.Move(movementVector * Time.deltaTime);
    }

    public void Update()
    {
        if (HuntingBool)
        {
            direction = transform.position - Destination.position;
            direction *= -1;
            Controller.Move(direction.normalized * MovementMultiplier * Time.deltaTime);
        }
        
        movementVector.Set(0f, Gravity, 0f);
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
        direction = transform.position - Destination.position;
        direction *= -1;
        Controller.Move(direction * Time.deltaTime);
    }
    
}

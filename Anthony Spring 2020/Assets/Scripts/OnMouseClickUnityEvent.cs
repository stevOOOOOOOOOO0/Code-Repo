using UnityEngine;
using UnityEngine.Events;

public class OnMouseClickUnityEvent : MonoBehaviour
{
    public UnityEvent onMouseClick;

    public void OnMouseDown()
    {
        onMouseClick.Invoke();
        print("we in it");
    }
}

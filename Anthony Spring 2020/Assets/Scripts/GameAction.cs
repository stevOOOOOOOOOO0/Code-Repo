using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : ScriptableObject
{
    public UnityAction Raise;
    
    public void RaiseAction()
    {
        Raise();
    }
}

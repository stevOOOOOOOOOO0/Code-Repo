using UnityEngine;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{

    public void DebugThisShit(string Information)
    {
        Debug.Log(Information);
    }
}

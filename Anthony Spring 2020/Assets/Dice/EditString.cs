using UnityEngine;

public class EditString : MonoBehaviour
{

    public StringData EditThis;

    public void EditStringTo(string replacement)
    {
        EditThis.Value = replacement;
    }


}

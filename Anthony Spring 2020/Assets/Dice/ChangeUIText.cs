using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeUIText : MonoBehaviour
{
    public Text text;
    public StringData textData;

    public void Start()
    {
        text = GetComponent<Text>();
    }

    public void SetTextToStringData()
    {
        text.text = textData.Value;
    }
}

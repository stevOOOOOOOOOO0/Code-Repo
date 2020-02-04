using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class GameObjectListSO : ScriptableObject
{
    public List<GameObject> GOList;
    private GameObject Object;

    public void FirstToLast()
    {
        Object = GOList[0];
        GOList.Remove(GOList[0]);
        GOList.Add(Object);
    }

    public GameObject GetFirstObj()
    {
        return GOList[0];
    }
}

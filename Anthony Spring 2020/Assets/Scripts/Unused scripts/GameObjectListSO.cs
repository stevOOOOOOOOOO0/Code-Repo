using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class GameObjectListSO : ScriptableObject
{
    public List<GameObject> GOList;
    private GameObject Object;

    public void OnStart()
    {
        for (int i = 0; i < GOList.Count; i++)
        {
            Instantiate(GOList[i]);
        }
    }

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

    public void SetFirstActive()
    {
        GOList[0].SetActive(true);
    }
    
    public void SetFirstDisable()
    {
        GOList[0].SetActive(false);
    }
}

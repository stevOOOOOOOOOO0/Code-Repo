using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

[CreateAssetMenu]
public class AfterImagesSOPrototype : ScriptableObject
{
    public GameObject Base;
    public List<GameObject> AfterImages, AfterImagesActive;
    public Transform Location;
    private bool Work;

    public void Start()
    {
        AfterImages.Clear();
        AfterImagesActive.Clear();
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        AfterImages.Add(Instantiate(Base));
        
        foreach (var VARIABLE in AfterImages)
        {
            VARIABLE.SetActive(false);
        }
    }

    public void Activate()
    {
        if (AfterImages.Count > 0)
        {
            Work = true;
            AfterImages[0].SetActive(true);
            AfterImagesActive.Add(AfterImages[0]);
            AfterImages.Remove(AfterImages[0]);
        }
        else
        {
            Work = false;
        }
    }

    public void SetLocation()
    {
        if (Work)
        {
            AfterImagesActive[AfterImagesActive.Count - 1].transform.position = Location.position;
        }
    }

    public void SetRotation()
    {
        if (Work)
        {
            AfterImagesActive[AfterImagesActive.Count - 1].transform.LookAt(Location);
        }
    }
    

    public void CastTheRay()
    {
        if (Work)
        {
            RaycastHit hit;
            if (Physics.Raycast(AfterImagesActive[AfterImagesActive.Count - 1].transform.position, AfterImagesActive[AfterImagesActive.Count - 1].transform.forward, out hit, Vector3.Distance(AfterImagesActive[AfterImagesActive.Count - 1].transform.position, Location.position)))
            {
                if (hit.collider.gameObject.layer == 9)
                {
                    hit.collider.gameObject.GetComponent<EnemyBehaviorsPrototype>().InvokeOnHit();
                }
            }
        }
    }

    
    public void Move()
    {
        AfterImagesActive[AfterImagesActive.Count - 1].GetComponent<MoveOverTime>().Location = Location.position;
        AfterImagesActive[AfterImagesActive.Count - 1].GetComponent<MoveOverTime>().Time = .25f;
        AfterImagesActive[AfterImagesActive.Count - 1].GetComponent<MoveOverTime>().waitTime = .5f;
        AfterImagesActive[AfterImagesActive.Count - 1].GetComponent<MoveOverTime>().StartWaitTime();
    }

    public void Disable()
    {
        AfterImages.Add(AfterImagesActive[AfterImagesActive.Count - 1]);
        AfterImages[AfterImages.Count - 1].SetActive(false);
    }
}

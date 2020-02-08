using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AfterImagesSOPrototype : ScriptableObject
{
    public GameObject Base;
    public List<GameObject> AfterImages, AfterImagesActive;
    public Transform Location;
    private bool Work;
    public UnityEvent RayCollision;

    public void Start()
    {
        AfterImages.Clear();
        AfterImagesActive.Clear();
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

    public void StartDisableCoroutine()
    {
        //StartCoroutine(DisableCoroutine());
    }
    
    public IEnumerator DisableCoroutine()
    {
        if (Work)
        {
            yield return new WaitForSeconds(3);
            Debug.Log("3 seconds over");
            AfterImages.Add(AfterImagesActive[AfterImagesActive.Count - 1]);
            AfterImages[AfterImages.Count - 1].gameObject.SetActive(false);
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
                    RayCollision.Invoke();
                    //hit.collider.gameObject.SendMessage("Explode");
                }
            }

            Debug.DrawRay(AfterImagesActive[AfterImagesActive.Count - 1].transform.position, AfterImagesActive[AfterImagesActive.Count - 1].transform.forward * Vector3.Distance(AfterImagesActive[AfterImagesActive.Count - 1].transform.position, Location.position), Color.green, 3f);
        }
    }
}

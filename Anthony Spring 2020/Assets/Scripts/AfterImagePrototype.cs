using System.Collections;
using UnityEngine;

[CreateAssetMenu]
public class AfterImagePrototype : MonoBehaviour
{
    
    private Transform AfterImage;
    public Transform Location;

    public void Start()
    {
        AfterImage = GetComponent<Transform>();
        AfterImage.gameObject.SetActive(false);
    }

    public void Activate()
    {
        AfterImage.gameObject.SetActive(true);
    }

    public void SetLocation()
    {
        AfterImage.position = Location.position;
    }

    public void SetRotation()
    {
        AfterImage.transform.LookAt(Location);
    }

    public void StartDisableCoroutine()
    {
        StartCoroutine(DisableCoroutine());
    }
    
    public IEnumerator DisableCoroutine()
    {
        yield return new WaitForSeconds(3);
        AfterImage.gameObject.SetActive(false);
    }

    public void CastTheRay()
    {
        RaycastHit hit;
        Physics.Raycast(AfterImage.position, AfterImage.forward, out hit, Vector3.Distance(AfterImage.position, Location.position));
        Debug.DrawRay(AfterImage.position, AfterImage.forward * Vector3.Distance(AfterImage.position, Location.position), Color.green, 3f);
    }
}
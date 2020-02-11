using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MoveOverTime : MonoBehaviour
{

    private bool CanMove = false;
    public Vector3 Location, OldLocation;
    public float Time, waitTime;
    public UnityEvent AfterMoveEvent;

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            Time += UnityEngine.Time.deltaTime / .1f;
            transform.position = Vector3.Lerp(OldLocation, Location, Time);
            if (transform.position == Location)
            {
                CanMove = false;
                AfterMoveEvent.Invoke();
            }
        }
    }

    public IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(.25f);
        CanMove = true;
    }

    public void StartWaitTime()
    {
        OldLocation = transform.position;
        StartCoroutine(WaitTime());
    }
    
}

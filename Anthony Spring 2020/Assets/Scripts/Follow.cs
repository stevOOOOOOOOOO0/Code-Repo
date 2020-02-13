using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform FollowMe;
    public Vector3 Offset;
    private Vector3 DesiredPosition;
    public float Smoothness;
    public bool Following = true;

    void Update()
    {
        if (Following)
        {
            DesiredPosition = FollowMe.position + Offset;
            transform.position = Vector3.Lerp(transform.position, DesiredPosition, Smoothness);
        }
    }

    public void StartFollowing()
    {
        Following = true;
    }

    public void StopFollowing()
    {
        Following = false;
    }
}

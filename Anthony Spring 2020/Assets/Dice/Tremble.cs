﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Tremble : MonoBehaviour
{

    public Vector3 Movement;
    public float Shaking;


    public void startCoroutine()
    {
        StartCoroutine(Trembling());
    }

    private IEnumerator Trembling()
    {
        Shaking = 3;
        while (Shaking > 0)
        {
            Movement.Set(Random.Range(-2, 2), Random.Range(-2, 2), Random.Range(-2, 2));
            transform.position += Movement;
            Movement = Movement / -2;
            Shaking -= 1 * Time.deltaTime;
        }
        yield return new WaitForSeconds(0f);
    }
}

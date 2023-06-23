using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float lookSpeed;
    Rigidbody rigidBody;

    public static float actualSpeed;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Quaternion lookRotation = Quaternion.LookRotation(Camera.main.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, lookSpeed * Time.deltaTime);
        rigidBody.velocity = transform.forward * actualSpeed;
    }
}

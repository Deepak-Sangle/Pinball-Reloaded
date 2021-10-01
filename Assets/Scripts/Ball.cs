using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    public Rigidbody rigidBody;
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
}

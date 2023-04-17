using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    [SerializeField]

    Rigidbody mFallBody;

    private void OnTriggerEnter(Collider other)
    {
        mFallBody.useGravity = true;   
    }
}

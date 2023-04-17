using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Moveable : MonoBehaviour
{
    private NavMeshAgent mAgent;

    [SerializeField]
    private Transform mTarget;

    private void Awake()
    {
        mAgent= GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mAgent.SetDestination(mTarget.position);
        }
    }

}

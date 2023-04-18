using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class PathFinder : MonoBehaviour
{
    public NavMeshAgent mNavMeshAgent = null;
    public Vector3[] mPath = null;

    public void Awake()
    {
        this.Init();
    }

    public void Init()
    {
        // ���� �÷��̾�� ������� �ʰ� �� ã�� �뵵�θ� ����Ѵ�.
        mNavMeshAgent.updatePosition = false;
        mNavMeshAgent.updateRotation = false;
        mNavMeshAgent.isStopped = true;
        Debug.Log("[PathFinder] NavMeshAgent Disabled");
    }

    public Vector3[] GetPath(Vector3 start, Vector3 ended)
    {
        NavMeshPath path = new NavMeshPath();

        this.transform.position = start;
        mNavMeshAgent.nextPosition = start;
        if(mNavMeshAgent.CalculatePath(ended, path))
        {
            mPath = path.corners;
            return mPath;
        }

        return null;
    }
}

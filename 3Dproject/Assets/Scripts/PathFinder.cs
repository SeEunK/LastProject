using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class PathFinder : MonoBehaviour
{
    public static PathFinder Instance;
    public NavMeshAgent mNavMeshAgent = null;
    public Vector3[] mPath = null;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Instance.Init();
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
       
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
        ResetPath();
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

 

    public void ResetPath()
    {
        mPath = null;
    }
}

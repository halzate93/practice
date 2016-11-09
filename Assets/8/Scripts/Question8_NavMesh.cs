using UnityEngine;
using System.Collections;

public class Question8_NavMesh : MonoBehaviour {

    private Vector3 pos;
    private Ray posRay;
    private RaycastHit posRayHit;

    private Transform target;
    private Camera sceneCamera;
    private NavMeshAgent navMeshAgent;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Target").transform;
        sceneCamera = FindObjectOfType<Camera>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        posRay = sceneCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(posRay, out posRayHit, 25))
        {
            pos = posRayHit.point;
        }

        if (Input.GetMouseButtonDown(0))
        {
            target.position = new Vector3(pos.x, 0, pos.z);
        }

        navMeshAgent.SetDestination(target.position);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    [SerializeField]
    Transform _destination = null;

    NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attatched to " + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void FixedUpdate()
    {
        SetDestination();
    }

    private void SetDestination()
    {
        Vector3 targetVector = _destination.transform.position;
        _navMeshAgent.SetDestination(targetVector);
    }
}

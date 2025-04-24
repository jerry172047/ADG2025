using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent47 : MonoBehaviour
{
    public Transform x,y;
    public NavMeshAgent navMesh;
    public Target currentTarget;
    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.SetDestination(x.position);
        currentTarget = Target.A;
    }

    // Update is called once per frame
    void Update()
    {
        if(navMesh.remainingDistance <= 0.1f)
        {
            Vector3 newDestination = new Vector3(0,0,0);
            if (currentTarget == Target.A)
            {
                newDestination = y.position;
                currentTarget = Target.B;
            }
            else
            {
                newDestination = x.position;
                currentTarget = Target.A;
            }
            navMesh.SetDestination(newDestination);
        }
    }

}
public enum Target
{
    A,
    B
}
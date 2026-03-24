using UnityEngine;
using UnityEngine.AI;
<<<<<<< HEAD
public class AgentSimpleController : MonoBehaviour
{

    public Transform Target;


=======

public class AgentSimpleController : MonoBehaviour
{
    public Transform Target;
>>>>>>> bb9a0dcf567ad211e681bad355a35bf8078058f8
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

<<<<<<< HEAD
    void Update()
    {
        if (Target != null)
        {
            agent.SetDestination(Target.position);
=======
    
    void Update()
    {
        if(Target != null)
        {
            agent.SetDestination(Target.position);
            //agent.

>>>>>>> bb9a0dcf567ad211e681bad355a35bf8078058f8
        }
    }
    public void HasPath()
    {
<<<<<<< HEAD

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;


=======
        print(agent.hasPath);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if(agent == null || agent.path == null) return;

        Vector3[] corners = agent.path.corners;


        for (int i = 0; i < corners.Length - 1; i++)
        {
            Gizmos.DrawLine(corners[i], corners[i + 1]);
            Gizmos.DrawSphere(corners[i], 0.2f);
        }
>>>>>>> bb9a0dcf567ad211e681bad355a35bf8078058f8
    }
}

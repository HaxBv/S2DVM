using UnityEngine;
using UnityEngine.AI;

public class AgentSimpleController : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent agent;
    public Vector3 InitialPosition;
    public Vector3 OriginalBallPosition;

    public bool ChangeTeleportBall;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        InitialPosition = transform.position;


        OriginalBallPosition = Target.position;
    }

    
    void Update()
    {
        if(Target != null)
        {
            agent.SetDestination(Target.position);
            //agent.

        }
    }
    public void HasPath()
    {
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
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {

            if (!ChangeTeleportBall)
            {
                Target.transform.position = InitialPosition;
                ChangeTeleportBall = true;
                return;
            }
            else
            { 

                Target.transform.position = OriginalBallPosition;
                ChangeTeleportBall = false;
                return;
            }
            
        }
    }
}

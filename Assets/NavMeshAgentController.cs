using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentController : MonoBehaviour
{
    public Transform targetA;
    public Transform targetB;
    public Transform targetC;
    private NavMeshAgent agent;
    private Transform currentTarget;
    private Quaternion desiredRotation;

    public float rotationSpeed = 5f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (agent == null)
        {
            Debug.LogError("NavMeshAgent component not found!");
        }
        else
        {
            SetDestination(targetA);
        }
    }

    void Update()
    {
        if (agent.remainingDistance < 0.1f)
        {
            if (currentTarget == targetA)
            {
                SetDestination(targetB);
            }
            else if (currentTarget == targetB)
            {
                SetDestination(targetC);
            }
            else if (currentTarget == targetC)
            {
                SetDestination(targetA);
            }
        }

        // Smoothly rotate towards the desired direction
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, Time.deltaTime * rotationSpeed);
    }

    void SetDestination(Transform destination)
    {
        currentTarget = destination;
        agent.SetDestination(destination.position);

        // Calculate direction to the destination
        Vector3 direction = (destination.position - transform.position).normalized;
        direction.y = transform.forward.y; // Maintain the same y component as the forward vector

        if (direction != Vector3.zero)
        {
            // Calculate desired rotation towards the destination
            desiredRotation = Quaternion.LookRotation(direction);

            // Adjust for the initial rotation of the asset (if needed)
            desiredRotation *= Quaternion.Euler(0, -110, 0); // Adjust if necessary
        }
    }
}
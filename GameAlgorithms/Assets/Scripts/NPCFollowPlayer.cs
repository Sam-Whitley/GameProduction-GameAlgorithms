using UnityEngine;
using UnityEngine.AI;

public class NPCFollowPlayer : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField] Transform target;

    private void Awake() 
    { 
        agent = GetComponent<NavMeshAgent>(); 
    }

    void Start()
    {
        
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}

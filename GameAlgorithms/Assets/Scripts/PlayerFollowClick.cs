using UnityEngine;
using UnityEngine.AI;

public class PlayerFollowClick : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField] public GameObject NPCFollower;

    private void Awake() 
    { 
        agent = GetComponent<NavMeshAgent>(); 
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
                agent.SetDestination(hit.point);
        }
    }
}

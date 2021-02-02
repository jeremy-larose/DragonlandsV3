using UnityEngine;
using UnityEngine.AI;

public class NavMeshMover : IMover
{
    private readonly Player _player;
    private NavMeshAgent _navMeshAgent;

    public NavMeshMover( Player player )
    {
        _player = player;
        _navMeshAgent = _player.GetComponent<NavMeshAgent>();
        _navMeshAgent.enabled = true;
    }
    
    public void Tick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo))
            {
                _navMeshAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
using UnityEngine;

public class MoveDestination : MonoBehaviour {
  public Transform goal;
   
  void Update () {
    NavMeshAgent agent = GetComponent<NavMeshAgent>();
    agent.destination = goal.position; 
  }
}

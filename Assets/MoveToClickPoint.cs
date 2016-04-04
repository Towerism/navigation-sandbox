using UnityEngine;
    
public class MoveToClickPoint : MonoBehaviour {
  public const int MaximumRayLength = 100;

  NavMeshAgent agent;
        
  void Start() {
    agent = GetComponent<NavMeshAgent>();
  }
        
  void Update() {
    if (Input.GetMouseButtonDown(0))
      setDestination();
  }

  void setDestination() {
    RaycastHit hit;
    if (collideRaycastFromClickPoint(out hit))
      agent.destination = hit.point;
  }

  bool collideRaycastFromClickPoint(out RaycastHit hit) {
    Ray castFromClickPoint = Camera.main.ScreenPointToRay(Input.mousePosition); 
    return Physics.Raycast(castFromClickPoint, out hit, MaximumRayLength);
  }
}

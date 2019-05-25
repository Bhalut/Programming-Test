using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 DirectionTarget(Vector3 target)
    {
        var pointer = target - transform.position;
        var distance = pointer.magnitude;
        var forward = pointer / distance;
        
        return forward;
    }
}

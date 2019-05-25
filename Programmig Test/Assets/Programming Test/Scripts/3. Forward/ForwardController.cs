using UnityEngine;

public class ForwardController : MonoBehaviour
{
    public Transform target;

    private Player _player;

    private void Awake()
    {
        _player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(_player.DirectionTarget(target.position));
    }
}

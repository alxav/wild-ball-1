using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 correction;
    private Transform _transform;
    
    void Awake()
    {
        _transform = transform;
    }
    
    void Update()
    {
        var positionTarget = target.position;
        var position = new Vector3(positionTarget.x + correction.x, positionTarget.y + correction.y,
            positionTarget.z + correction.z);

        _transform.position = position;
    }
}

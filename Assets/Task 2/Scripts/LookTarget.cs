using UnityEngine;

public class LookTarget : MonoBehaviour
{

    [SerializeField] private Transform target;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    void Update()   
    {
        _transform.LookAt(target);
    }
}

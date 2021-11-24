using UnityEngine;

public class JoystickController : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float speed;
    
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    void Update()
    {
        var x = joystick.Horizontal; 
        var z = joystick.Vertical; 
        if (x == 0 && z == 0) return;

        var position = _transform.position;
        position = Vector3.MoveTowards(position,new Vector3(position.x + x, position.y, position.z + z), Time.deltaTime * speed);
        _transform.position = position;
    }
}

using UnityEngine;

[CreateAssetMenu]
public class PlayerSetting : ScriptableObject
{
    [SerializeField] private Vector3 startPosition;
    
    public Vector3 StartPosition => startPosition;
}

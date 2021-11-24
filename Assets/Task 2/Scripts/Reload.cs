using UnityEngine;

public class Reload : MonoBehaviour
{
    [SerializeField] private PlayerSetting playerSetting;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = playerSetting.StartPosition;
        }
    }
}

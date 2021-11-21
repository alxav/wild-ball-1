using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SetTitle : MonoBehaviour
{

    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void Start()
    {
        var indexActiveScene = SceneManager.GetActiveScene().buildIndex;
        text.text = "Level " + indexActiveScene;
    }
}

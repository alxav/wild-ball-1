using UnityEngine;
using UnityEngine.UI;

public class ElementLevel : MonoBehaviour
{
    [SerializeField] private Text info;
    private int index;
    private Helpers helpers;

    private void Awake()
    {
        helpers = new Helpers();
    }

    public void SetIndex(int index)
    {
        this.index = index;
        info.text = index.ToString();
    }

    public void Load() => helpers.LoadScene(index);

}

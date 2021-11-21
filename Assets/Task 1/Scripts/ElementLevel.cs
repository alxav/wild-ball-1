using UnityEngine;

public class ElementLevel : MonoBehaviour
{
    private int index;
    private Helpers helpers;

    private void Awake()
    {
        helpers = new Helpers();
    }

    public void SetIndex(int index) => this.index = index;
    
    public void Load() => helpers.LoadScene(index);

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Helpers
{
    public void SetVisible(GameObject panel, bool isVisible)
    {
        if (panel)
            panel.SetActive(isVisible);
    }
    
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

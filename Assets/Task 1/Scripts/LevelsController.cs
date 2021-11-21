using UnityEngine;

public class LevelsController : MonoBehaviour
{
    [SerializeField] private LevelsSettings levelsSettings;

    private Helpers helpers;

    private void Awake()
    {
        helpers = new Helpers();
    }
    
    public void LoadMenu() => helpers.LoadScene(levelsSettings.IndexMenu);
    
    public void Reload() => helpers.Reload();


}

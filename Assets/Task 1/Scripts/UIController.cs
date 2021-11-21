using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject levelsPanel;

    private Helpers helpers;

    private void Awake()
    {
        helpers = new Helpers();
    }

    public void OpenMainPanel() => helpers.SetVisible(mainPanel, true);
    public void CloseMainPanel() => helpers.SetVisible(mainPanel, false);
    
    public void OpenLevelsPanel() => helpers.SetVisible(levelsPanel, true);
    public void CloseLevelsPanel() => helpers.SetVisible(levelsPanel, false);
    


}

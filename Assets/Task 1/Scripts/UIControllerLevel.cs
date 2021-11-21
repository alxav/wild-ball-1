using UnityEngine;

public class UIControllerLevel : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    private Helpers helpers;

    private void Awake()
    {
        helpers = new Helpers();
    }

    public void OpenPausePanel() => helpers.SetVisible(pausePanel, true);
    public void ClosePausePanel() => helpers.SetVisible(pausePanel, false);
}

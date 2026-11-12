using UnityEngine;

public class MenuUIController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject rulesPanel;
    [SerializeField] private GameObject instructionsPanel;
    [SerializeField] private GameObject aboutPanel;

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        rulesPanel.SetActive(false);
        instructionsPanel.SetActive(false);
        aboutPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ShowRules()
    {
        mainMenu.SetActive(false);
        rulesPanel.SetActive(true);
        instructionsPanel.SetActive(false);
        aboutPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void ShowInstructions()
    {
        mainMenu.SetActive(false);
        rulesPanel.SetActive(false);
        instructionsPanel.SetActive(true);
        aboutPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void ShowAbout()
    {
        mainMenu.SetActive(false);
        rulesPanel.SetActive(false);
        instructionsPanel.SetActive(false);
        aboutPanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
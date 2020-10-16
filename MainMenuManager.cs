using UnityEngine;

/* Simple script to handle inputs on UI inputs in a 3D modeler application. 
 * Different functions are assigned to various UI elements.
 */

public class MainMenuManager : MonoBehaviour
{
    // Decorations
    public GameObject menuBackground;

    // Other menus
    public GameObject optionsMenu;
    public GameObject monitorMenu;
    public GameObject shapesMenu;

    // Saved input
    private GameObject activeMenu;
    private bool menuActive = false;
    
    // Initial click on white button in top right corner of the screen
    public void OnMainMenuButtonClick()
    {
        if (!menuActive)
        {
            OpenMenu();
        }
        else
        {
            CloseMenu();
        }
    }

    // Used when navigating between different menus
    public void OnMenuButtonClick(GameObject nextMenu)
    {
        activeMenu.SetActive(false);
        nextMenu.SetActive(true);
        activeMenu = nextMenu;
    }

    // Opens main menu after UI button click
    private void OpenMenu()
    {
        menuBackground.SetActive(true);
        optionsMenu.SetActive(true);
        activeMenu = optionsMenu;
        menuActive = true;
    }

    // Closes main menu after UI button click
    private void CloseMenu()
    {
        menuBackground.SetActive(false);
        activeMenu.SetActive(false);
        activeMenu = null;
        menuActive = false;
    }
}

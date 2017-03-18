using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class for Main Menu
public class changeSceneMain : MonoBehaviour
{
    public Canvas mainMenu;
    public Button designMenuButton;
    public Button constructionMenuButton;

    // Variable for loading design menu
    public void designMenu(string sceneToDesign)
    {
        Application.LoadLevel(sceneToDesign);
    }

    // Variable for loading contruction menu
    public void constructionMenu(string sceneToConstruction)
    {
        Application.LoadLevel(sceneToConstruction);
    }

    // Variable for exiting application
    public void Exit()
    {
        Application.Quit();
    }
}

// Class for construction environment
public class changeSceneTest : MonoBehaviour
{
    public Canvas constructionMenu;
    public Button infoTag;
    public Button ruler;
    public Button grid;
    public Button camera;
    public Button displayType;
    public Button opaque;
    public Button wireframe;

    public void ribbonMenu()
    {
        // Initialize buttons for construction environment
        constructionMenu = 
        constructionMenu = constructionMenu.GetComponent<Canvas>();
        infoTag = infoTag.GetComponent<Button>();
        ruler = ruler.GetComponent<Button>();
        grid = grid.GetComponent<Button>();
        camera = camera.GetComponent<Button>();
        displayType = displayType.GetComponent<Button>();

        // Initialize buttons for display type
        opaque = opaque.GetComponent<Button>();
        wireframe = wireframe.GetComponent<Button>();
    }

    public void constructionRibbonPress()
    {
        infoTag.enabled = true;
        ruler.enabled = true;
        grid.enabled = true;
        camera.enabled = true;
        displayTypePress();
    }

    public void constructionRibbonNoPress()
    {
        infoTag.enabled = false;
        ruler.enabled = false;
        grid.enabled = false;
        camera.enabled = false;
    }

    // Vairable for loading display type menu
    public void displayTypePress()
    {
        displayType.enabled = true;
        opaque.enabled = true;
        wireframe.enabled = true;
    }

    // Vairable for loading component menu
    public void componentMenu(string sceneToComponents)
    {
        Application.LoadLevel(sceneToComponents);
    }
}
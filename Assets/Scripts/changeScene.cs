using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public Canvas mainMenu;
    public Button designMenu;
    public Button constructionMenu;

	// Use this for initialization
	public void changeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
	}
}

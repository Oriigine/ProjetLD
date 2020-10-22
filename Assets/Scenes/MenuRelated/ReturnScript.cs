using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnScript : MonoBehaviour
{

    public Button Return;

    public void ReturnButton()
    {
        Debug.Log("oui");
        SceneManager.LoadScene("MainMenuScene");
    }

}

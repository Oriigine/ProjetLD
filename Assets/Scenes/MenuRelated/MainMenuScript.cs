using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public Button AndreaButton;
    public Button YoanButton;
    public Button MondhorButton;



    public void AndreaButtonOnClick()
    {
        SceneManager.LoadScene("Andrea");
    }

    public void YoanButtonOnClick()
    {
        SceneManager.LoadScene("Yoan");
    }

    public void MondhorButtonOnClick()
    {
        SceneManager.LoadScene("Mondhor");
    }


}

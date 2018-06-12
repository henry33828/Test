using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputName : MonoBehaviour {

    public Text PlayerLastName;
    public Text PlayerFirstName;

    public void EnterPlayerLastName(Text enterLastName)
    {
        PlayerLastName.text = enterLastName.text;
    }

    public void EnterPlayerFirstName(Text enterFirstName)
    {
        PlayerFirstName.text = enterFirstName.text;
    }

    public void Click() {
        SceneManager.LoadScene("Room");
    }
}

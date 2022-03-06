using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public static string persistentUserName;

    // Start is called before the first frame update
    void Start()
    {
        if ( (persistentUserName != null))
        {
            userName.text = persistentUserName;
        }
    }


    public void setUserName()
    {
        // it is called by the username gui once the username will be inserted
        persistentUserName = userName.text;
        SceneManager.LoadScene(1);
    }
}

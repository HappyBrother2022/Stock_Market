using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayWithFriendDialog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closeBtnClicked()
    {
        gameObject.SetActive(false);
    }

    public void submitBtnClicked()
    {
        PlayerPrefs.SetInt("gameMode", 0);
        SceneManager.LoadScene("Game");
    }
}

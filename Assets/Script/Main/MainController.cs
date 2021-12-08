using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainController : MonoBehaviour
{
    public GameObject playWithFriendDlg;
    public GameObject WelcomeDialog;
    public GameObject ProfilePage;
    public GameObject leaderBoardDialog;
    // Start is called before the first frame update
    void Start()
    {
        WelcomeDialog.SetActive(true);
        leaderBoardDialog.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Premium_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void Learning_btnClicked() {
        PlayerPrefs.SetInt("gameMode", 4);
        SceneManager.LoadScene("Game");
    }

    public void Training_btnClicked() {
        PlayerPrefs.SetInt("gameMode", 4);
        SceneManager.LoadScene("Game");
    }

    public void Stock_btnClicked() {
        PlayerPrefs.SetInt("gameMode", 1);
        SceneManager.LoadScene("Game");
    }

    public void Crypto_btnClicked() {
        PlayerPrefs.SetInt("gameMode", 2);
        SceneManager.LoadScene("Game");
    }

    public void Forex_btnClicked() {
        PlayerPrefs.SetInt("gameMode", 3);
        SceneManager.LoadScene("Game");
    }

    public void PlayWithFriendBtnClicked()
    {
        playWithFriendDlg.SetActive(true);
    }

    public void ProfileBtnClicked()
    {
        WelcomeDialog.SetActive(false);
        ProfilePage.SetActive(true);
    }
}

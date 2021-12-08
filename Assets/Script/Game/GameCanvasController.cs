using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameCanvasController : MonoBehaviour
{

    public GameObject vsRankDialog;
    public GameObject multiRankDialog;
    // Start is called before the first frame update
    void Start()
    {
        
        if(PlayerPrefs.GetInt("gameMode") == 0)
        {
            vsRankDialog.SetActive(true);
        }else if(PlayerPrefs.GetInt("gameMode") == 1)
        {
            multiRankDialog.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HomePageBtnClicked()
    {
        SceneManager.LoadScene("Main");
    }

    
}

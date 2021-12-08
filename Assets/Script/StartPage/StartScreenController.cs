using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenController : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject loginCanvas;
    public GameObject registerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loginStartBtnClicked()
    {
        startCanvas.SetActive(false);
        loginCanvas.SetActive(true);
        registerCanvas.SetActive(false);
    }

    public void registerStartBtnClicked()
    {
        startCanvas.SetActive(false);
        loginCanvas.SetActive(false);
        registerCanvas.SetActive(true);
    }

    public void backBtnClicked()
    {
        startCanvas.SetActive(true);
        loginCanvas.SetActive(false);
        registerCanvas.SetActive(false);
    }
}

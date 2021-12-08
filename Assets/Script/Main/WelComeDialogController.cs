using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelComeDialogController : MonoBehaviour
{
    public GameObject ProfileDialog;
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

    public void profileBtnClicked()
    {
        gameObject.SetActive(false);
    }
}

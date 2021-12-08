using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomToggle : MonoBehaviour
{
    public GameObject []selectGroup;
    public GameObject []unselectGroup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSelect()
    {
        for(int i = 0; i < selectGroup.Length; i++) {
            selectGroup[i].SetActive(gameObject.GetComponent<Toggle>().isOn);
        }
        for (int i = 0; i < unselectGroup.Length; i++)
        {
            unselectGroup[i].SetActive(!gameObject.GetComponent<Toggle>().isOn);
        }
    }
}

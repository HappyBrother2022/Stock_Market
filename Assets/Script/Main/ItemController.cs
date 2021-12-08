using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemController : MonoBehaviour
{
    public int type = 0;
    public int state = 1;
    public GameObject border;
    public GameObject unlockBtn;
    public GameObject equipBtn;
    public Image itemImg;
    public string imgUrl;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void equipBtnClicked()
    {
        GameObject.Find("ProfilePage").GetComponent<ProfileController>().setEquip(gameObject, type);
    }

    public void unlockBtnClicked()
    {
        unlockBtn.SetActive(false);
    }

    public void setData(string url, int tp)
    {
        imgUrl = url;
        type = tp;
        itemImg.sprite = Resources.Load<Sprite>(url);
        if (type == 0)
        {
            unlockBtn.SetActive(false);
        }
    }

    public void setEquip()
    {
        border.SetActive(true);
        equipBtn.SetActive(false);
    }
    public void setUnEquip()
    {
        border.SetActive(false);
        equipBtn.SetActive(true);
    }
}

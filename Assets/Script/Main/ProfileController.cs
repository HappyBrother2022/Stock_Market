using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProfileController : MonoBehaviour
{
    public GameObject avatarContent;
    public GameObject ringContent;
    public GameObject weaponContent;
    public GameObject itemObj;
    public Image avatar;
    public Image avatar1;
    // Start is called before the first frame update
    void Start()
    {
        initAvatarContent();
        initRingContent();
        initWeaponContent();
    }

    void initAvatarContent()
    {
        float posx = avatarContent.transform.GetChild(0).position.x, posy = avatarContent.transform.GetChild(0).position.y;
        for(int i = 0; i < Global.avatar_url.Length; i++)
        {
            float tmpx = posx + (i % 6) * 152 * Global.getRatio();
            float tmpy = posy - (i / 6) * 190 * Global.getRatio();
            GameObject cloneItem = Instantiate(itemObj, new Vector3(tmpx, tmpy, 0), itemObj.transform.rotation, avatarContent.transform);
            cloneItem.GetComponent<ItemController>().setData(Global.avatar_path + Global.avatar_url[i], 0);
        }
        avatarContent.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (Global.avatar_url.Length / 6 + ((Global.avatar_url.Length % 6) > 0 ? 1 : 0)) * 190 * Global.getRatio());

    }

    void initRingContent()
    {
        float posx = avatarContent.transform.GetChild(0).position.x, posy = avatarContent.transform.GetChild(0).position.y;
        for (int i = 0; i < Global.ring_url.Length; i++)
        {
            float tmpx = posx + (i % 6) * 152 * Global.getRatio();
            float tmpy = posy - (i / 6) * 190 * Global.getRatio();
            GameObject cloneItem = Instantiate(itemObj, new Vector3(tmpx, tmpy, 0), itemObj.transform.rotation, ringContent.transform);
            cloneItem.GetComponent<ItemController>().setData(Global.ring_path + Global.ring_url[i], 1);
        }
        ringContent.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (Global.ring_url.Length / 6 + ((Global.ring_url.Length % 6) > 0 ? 1 : 0)) * 190 * Global.getRatio());
    }

    void initWeaponContent()
    {
        float posx = avatarContent.transform.GetChild(0).position.x, posy = avatarContent.transform.GetChild(0).position.y;
        for (int i = 0; i < Global.weapon_url.Length; i++)
        {
            float tmpx = posx + (i % 6) * 152 * Global.getRatio();
            float tmpy = posy - (i / 6) * 190 * Global.getRatio();
            GameObject cloneItem = Instantiate(itemObj, new Vector3(tmpx, tmpy, 0), itemObj.transform.rotation, weaponContent.transform);
            cloneItem.GetComponent<ItemController>().setData(Global.weapon_path + Global.weapon_url[i], 2);
        }
        weaponContent.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (Global.weapon_url.Length / 6 + ((Global.weapon_url.Length % 6) > 0 ? 1 : 0)) * 190 * Global.getRatio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setEquip(GameObject item, int type)
    {
        if(type == 0)
        {
            for(int i = 0; i < avatarContent.transform.childCount; i++)
            {
                avatarContent.transform.GetChild(i).GetComponent<ItemController>().setUnEquip();
            }
            avatar.sprite = Resources.Load<Sprite>(item.GetComponent<ItemController>().imgUrl);
            avatar1.sprite = Resources.Load<Sprite>(item.GetComponent<ItemController>().imgUrl);
        }
        else if(type == 1)
        {
            for (int i = 0; i < ringContent.transform.childCount; i++)
            {
                ringContent.transform.GetChild(i).GetComponent<ItemController>().setUnEquip();
            }
        }else if(type == 2)
        {
            for (int i = 0; i < weaponContent.transform.childCount; i++)
            {
                weaponContent.transform.GetChild(i).GetComponent<ItemController>().setUnEquip();
            }
        }
        item.GetComponent<ItemController>().setEquip();
    }

    public void closeBtnClicked()
    {
        gameObject.SetActive(false);
    }
}

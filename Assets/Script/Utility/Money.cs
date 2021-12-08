using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class Money : MonoBehaviour
{
    // Start is called before the first frame update
    public int remain_money = -1;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        try{
            string s = "";
            if(remain_money == -1)
                remain_money = int.Parse(gameObject.GetComponent<TextMeshProUGUI>().text);
            int temp = remain_money;
            while(temp / 1000 != 0) {
                if(s != "")
                    s = string.Concat(",", s);
                if(temp % 1000 < 100 && temp % 100 >= 10) {
                    string t = "";
                    t = string.Concat("0", (temp % 1000).ToString());
                    s = string.Concat(t, s);    
                }else if(temp % 1000 < 10){
                    string t = "";
                    t = string.Concat("00", (temp % 1000).ToString());
                    s = string.Concat(t, s);
                }else
                    s = string.Concat((temp % 1000).ToString(), s);
                temp = temp / 1000;
            }
            if(s != "")
                s = string.Concat(",", s);
            s = string.Concat(temp, s);
            gameObject.GetComponent<TextMeshProUGUI>().text = string.Concat("$",s);
        }catch{
            
        }
    }

    void setMoney(int mon) {
        remain_money = mon;
    }
}

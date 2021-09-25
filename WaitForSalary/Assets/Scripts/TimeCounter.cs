using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{

    public Text LeftDay;
    public Image TimeCount;
    public GameObject[] foods;
    private int len;
    // Start is called before the first frame update
    void Start()
    {
         len=foods.Length;  
    }

    // Update is called once per frame
    void Update()
    { 
        int speed=int.Parse(LeftDay.text);
        if(speed==0){
            Application.LoadLevel(0);
        }
        else if(TimeCount.fillAmount<0.001f){
            TimeCount.fillAmount=1;
            speed-=1;
            LeftDay.text=speed.ToString();
            int i=Random.Range(0,len);
            foods[i].GetComponent<Image>().color=new Color(0,0,0,0.5f);
            foods[i].GetComponent<Button>().enabled=false;
        }
        else{
            TimeCount.fillAmount-=0.1f*speed*Time.deltaTime;

        }
        
    }
}

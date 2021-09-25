using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{

    public Text LeftDay;
    public Image TimeCount;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        else{
            TimeCount.fillAmount-=0.1f*speed*Time.deltaTime;

        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessing : MonoBehaviour
{
    public PostProcessVolume volume;
    //public Bloom _Bloom;
    public Text Day;
    public ColorGrading _Color;
    public float i;
    public DepthOfField _Depth;
  


    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out _Color);
        volume.profile.TryGetSettings(out _Depth);
        _Color.saturation.value=0;
        _Color.hueShift.value=0;
        _Depth.focalLength.value=0;
        i= 10;
        }

    // Update is called once per frame
    void Update()
    {  if(i>=1f){
         i-=0.5f*Time.deltaTime;}
       else{
         i=1f;
       }
        _Color.saturation.value=Random.Range(-100/i,100/i);
        _Color.hueShift.value=Random.Range(-100/i,100/i);
        _Depth.focalLength.value=100/i+50;   


        
            
    }

    public void Eat(){
        i+=1;
    }
    

}

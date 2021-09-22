using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class PostProcessingControl : MonoBehaviour
{

    public Text Day;
    public Volume v;
    public Bloom b;
    public Vignette vg;
    // Start is called before the first frame update
    void Start()
    {
        v=GetComponent<Volume>();
        v.profile.TryGet(out b);
        v.profile.TryGet(out vg);
        
    }

    // Update is called once per frame
    void Update()
    {

        b.scatter.value=0.1f;
        vg.intensity.value=0.5f;


        
    }
}

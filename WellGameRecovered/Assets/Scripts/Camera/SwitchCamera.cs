using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchCamera : MonoBehaviour {

    public float time = 0.0f;
    public Camera MainCamera;
    public Camera CameraTwo;
    public Animator anim;
   
    
	// Use this for initialization
	void Start ()
    {
        //Debug.Log("Dooop");
        //anim = GetComponent<Animator>();
        MainCamera.enabled = false;
        CameraTwo.enabled = true;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        /*Debug.Log(anim.GetBool("Finished"));

        
       if (anim.GetBool("Finished"))
        {
            Debug.Log("Booop");
            MainCamera.enabled = true;
            CameraTwo.enabled = false;
        }
        */

        if (time >= 5.5f)
        {
            MainCamera.enabled = true;
            CameraTwo.enabled = false;            
            
        }
    
	}
}


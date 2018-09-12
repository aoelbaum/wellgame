using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reticle : MonoBehaviour
{

    public Image customImage;
    public Image reticleImage;
 
    
   
    void Start()
    {
        customImage.enabled = false;
        
    }

    private void OnMouseOver()
    {
        customImage.enabled = true;
        reticleImage.enabled = false;


        enabled = true;
    }
    
    

	private void OnMouseExit()
    {
        
        customImage.enabled = false;
        reticleImage.enabled = true;
        
        
        enabled = true;

    }
    
}

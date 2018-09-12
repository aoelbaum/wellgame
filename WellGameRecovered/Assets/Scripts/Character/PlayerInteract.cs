
using UnityEngine;

public class PlayerInteract : MonoBehaviour {
    
    
    Camera cam;
    public Interactable focus;
    
    
	
	void Start()
    {
        cam = Camera.main;

        /*

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        */
        
    }
	void Update ()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;  
            
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        */

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
                
            }
        }
       
       
	}

    void SetFocus (Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();
            
            focus = newFocus;
        }
       
        newFocus.OnFocused(transform);

    }
    void RemoveFocus()
    {
        if (focus != null)
            focus.OnDefocused();

        focus = null;
    }

    
    
   
   
    
}

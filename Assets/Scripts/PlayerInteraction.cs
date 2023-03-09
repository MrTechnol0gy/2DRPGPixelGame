using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField] GameObject currentInterObj = null;
    [SerializeField] InteractionObject currentInterObjScript = null;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && currentInterObj == true)
        {
            CheckInteraction();
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = null;
            currentInterObjScript = null;
        }
    }

    public void CheckInteraction()
    {
       currentInterObjScript.DebugTest();
       if (currentInterObjScript.interType == InteractionObject.InteractableType.nothing)
       {
            currentInterObjScript.Nothing();
       }
       else if (currentInterObjScript.interType == InteractionObject.InteractableType.info)
       {
            currentInterObjScript.Info();
       }
       else if (currentInterObjScript.interType == InteractionObject.InteractableType.pickup)
       {
            currentInterObjScript.Pickup();
       }
       else if (currentInterObjScript.interType == InteractionObject.InteractableType.dialogue)
       {
            currentInterObjScript.Dialogue();
       }
    }
}

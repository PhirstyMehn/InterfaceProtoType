using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScanning : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    private InteractionManager interactionManager;
    private bool canInteract;
    [SerializeField] Material highlightMaterial;
    [SerializeField] Material originalFlavorMaterial; //original material color
    [SerializeField] private Transform mouseHighlight;
    [SerializeField] private InteractionUIController interactionUIController;
    

    void Update()
    {
        if(mouseHighlight != null)
        {
            mouseHighlight.GetComponent<MeshRenderer>().material = originalFlavorMaterial;
            mouseHighlight = null;
            interactionUIController.ClearText();
        }
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out RaycastHit raycastHit, float.MaxValue))
        {
            GameObject targetHit = raycastHit.collider.gameObject;
            if (targetHit.GetComponent<InteractionManager>())
            {
                interactionManager = (InteractionManager)targetHit.GetComponent<InteractionManager>();
                canInteract = interactionManager.GetIsInteractable();
                
            }
            if(canInteract == true)
            {
                
                mouseHighlight = targetHit.transform;
                if(mouseHighlight.GetComponent<MeshRenderer>().material != highlightMaterial)
                {
                    originalFlavorMaterial = mouseHighlight.GetComponent<MeshRenderer>().material;
                    mouseHighlight.GetComponent <MeshRenderer>().material = highlightMaterial;
                }                
                ObjectController l_ObjectController = (ObjectController)targetHit.GetComponent<ObjectController>();
                if (l_ObjectController != null)
                {
                    
                    InteractionUIController.instance.TellAboutObject(
                        l_ObjectController.GetName(), l_ObjectController.GetCurrentHealth(), l_ObjectController.GetMaxHealth());
                }
            }
        }
    }
}

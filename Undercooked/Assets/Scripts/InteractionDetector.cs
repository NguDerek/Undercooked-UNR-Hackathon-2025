using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionDetector : MonoBehaviour
{
    private IInteractable interactableInRange = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract(InputAction.CallbackContext context){
        if(context.performed){
            interactableInRange?.Interact();
        }
    } 
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.TryGetComponent(out IInteractable interactable) && interactable.CanInteract()){
            interactableInRange = interactable;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.TryGetComponent(out IInteractable interactable) && interactable == interactableInRange){
            interactableInRange = null;
        }
    }
}

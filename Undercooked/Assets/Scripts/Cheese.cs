using UnityEngine;

public class Cheese : MonoBehaviour, IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public bool CanInteract()
    {
        return !(FindFirstObjectByType<GameManager>().GetComponent<GameManager>().handsFull());
    }

    public void Interact()
    {
        if(!CanInteract())
        {
            return;
        }
        FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("Cheese");
    }

}


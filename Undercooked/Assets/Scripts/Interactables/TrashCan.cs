using UnityEngine;

public class TrashCan : MonoBehaviour, IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public bool CanInteract()
    {
        return FindFirstObjectByType<GameManager>().GetComponent<GameManager>().handsFull();
    }

    public void Interact()
    {
        if(!CanInteract())
        {
            return;
        }
        SoundEffectManager.Play("Trash");
        FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("None");
    }

}

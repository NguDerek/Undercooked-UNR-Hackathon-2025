using UnityEngine;

public class FryingPan : MonoBehaviour, IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public bool CanInteract()
    {
        return FindFirstObjectByType<GameManager>().GetComponent<GameManager>().cookPatty();
    }

    public void Interact()
    {
        if(CanInteract())
        {
            SoundEffectManager.Play("Frying");
            FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("Cooked Patty");
        }
    }
}

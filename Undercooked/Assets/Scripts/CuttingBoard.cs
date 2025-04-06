using UnityEngine;

public class CuttingBoard : MonoBehaviour, IInteractable
{
    public bool isOpened {get; private set;}
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
        if(CanInteract())
        {
            bool canChop = FindFirstObjectByType<GameManager>().GetComponent<GameManager>().chopIngredient();
            string ingredient = FindFirstObjectByType<GameManager>().GetComponent<GameManager>().getInventory();
            if(ingredient == "Lettuce")
                FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("Chopped Lettuce");
            else if(ingredient == "Tomato")
                FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("Chopped Tomato");
            else if(ingredient == "Cheese")
                FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("Chopped Cheese");
        }
        return;
    }

}

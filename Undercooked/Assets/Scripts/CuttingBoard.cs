using UnityEngine;

public class CuttingBoard : MonoBehaviour, IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public bool CanInteract()
    {
        return FindFirstObjectByType<GameManager>().GetComponent<GameManager>().chopIngredient();
    }

    public void Interact()
    {
        if(CanInteract())
        {
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

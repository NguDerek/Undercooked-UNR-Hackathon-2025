using UnityEngine;
using UnityEngine.SceneManagement; //for scene manager
using TMPro; //for TextMeshProUGUI
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI heldItem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool handsFull()
    {
        if(heldItem.text == "Held Item: None")
        {
            return false;
        }
        return true;
    }

    public bool chopIngredient(string ing)
    {
        if(heldItem.text == "Held Item: Lettuce" || heldItem.text == "Held Item: Tomato" || heldItem.text == "Held Item: Cheese")
        {
            return true;
        }
        return false;
    }

    public bool cookPatty()
    {
        if(heldItem.text == "Raw Patty")
        {
            return true;
        }
        return false;
    }
    public void updateInventory(string ing)
    {
        heldItem.text = "Held Item: " + ing;
    }
}

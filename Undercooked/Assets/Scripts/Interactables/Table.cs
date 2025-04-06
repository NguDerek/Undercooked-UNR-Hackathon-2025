using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Table : MonoBehaviour, IInteractable
{
    public string itemOnTable;
    public List<Sprite> spriteChoices;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemOnTable = "None";
    }

    public bool CanInteract()
    {
        return (FindFirstObjectByType<GameManager>().GetComponent<GameManager>().handsFull() && itemOnTable == "None") || (!(FindFirstObjectByType<GameManager>().GetComponent<GameManager>().handsFull()) && !(itemOnTable == "None"));
    }

    public void Interact()
    {
        if(!CanInteract())
        {
            return;
        }
        if(itemOnTable == "None")
        {
            itemOnTable = FindFirstObjectByType<GameManager>().GetComponent<GameManager>().getInventory();
            FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("None");
            switch(itemOnTable)
            {
                case "Lettuce":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[1];
                    break;
                case "Chopped Lettuce":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[2];
                    break;
                case "Tomato":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[3];
                    break;
                case "Chopped Tomato":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[4];
                    break;
                case "Cheese":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[5];
                    break;
                case "Chopped Cheese":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[6];
                    break;
                case "Raw Patty":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[7];
                    break;
                case "Cooked Patty":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[8];
                    break;
                case "Bun":
                    GetComponent<SpriteRenderer>().sprite = spriteChoices[9];
                    break;
            }
        }
        else
        {
            FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory(itemOnTable);
            itemOnTable = "None";
            GetComponent<SpriteRenderer>().sprite = spriteChoices[0];
        }
        
    }
}
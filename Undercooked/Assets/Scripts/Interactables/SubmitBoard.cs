using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;

public class SubmitBoard : MonoBehaviour, IInteractable
{
    public int orderNum;
    public int stepNum;
    public List<Sprite> spriteChoices;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orderNum = 1;
        stepNum = 1;
    }

    public bool CanInteract()
    {
        bool interact = false;
        string inv = FindFirstObjectByType<GameManager>().GetComponent<GameManager>().getInventory();
        switch(orderNum)
        {
            case 1:
                if(stepNum == 1)
                    interact = (inv == "Bun");
                else if(stepNum == 2)
                    interact = (inv == "Cooked Patty");
                else if(stepNum == 3)
                    interact = true;
                break;
            case 2:
                if(stepNum == 1)
                    interact = (inv == "Bun");
                else if(stepNum == 2)
                    interact = (inv == "Cooked Patty");
                else if(stepNum == 3)
                    interact = (inv == "Chopped Cheese");
                else if(stepNum == 4)
                    interact = true;
                break;
            case 3:
                if(stepNum == 1)
                    interact = (inv == "Bun");
                else if(stepNum == 2)
                    interact = (inv == "Cooked Patty");
                else if(stepNum == 3)
                    interact = (inv == "Chopped Lettuce");
                else if(stepNum == 4)
                    interact = (inv == "Chopped Tomato");
                else if(stepNum == 5)
                    interact = true;
                break;
            case 4:
                if(stepNum == 1)
                    interact = (inv == "Bun");
                else if(stepNum == 2)
                    interact = (inv == "Cooked Patty");
                else if(stepNum == 3)
                    interact = (inv == "Chopped Cheese");
                else if(stepNum == 4)
                    interact = (inv == "Chopped Lettuce");
                else if(stepNum == 5)
                    interact = (inv == "Chopped Tomato");
                else if(stepNum == 6)
                    interact = true;
                break;
        }
        return interact;
    }

    public void Interact()
    {
        if(!CanInteract())
        {
            return;
        }
        if(stepNum == orderNum + 2)
        {
            GetComponent<SpriteRenderer>().sprite = spriteChoices[0];
            stepNum = 0;
            orderNum++;
            FindFirstObjectByType<GameManager>().GetComponent<GameManager>().checkForWin(orderNum);
        }
        FindFirstObjectByType<GameManager>().GetComponent<GameManager>().updateInventory("None");
        if(stepNum == 1)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[1];
        else if(stepNum == 2)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[2];
        else if(stepNum == 3 && orderNum == 3)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[4];
        else if(stepNum == 3)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[3];
        else if(stepNum == 4 && orderNum == 3)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[5];
        else if(stepNum == 4)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[6];
        else if(stepNum == 5)
            GetComponent<SpriteRenderer>().sprite = spriteChoices[7];
        stepNum++;
    }

}

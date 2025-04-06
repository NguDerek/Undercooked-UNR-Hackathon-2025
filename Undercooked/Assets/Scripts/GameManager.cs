using UnityEngine;
using UnityEngine.SceneManagement; //for scene manager
using TMPro; //for TextMeshProUGUI
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Threading;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI heldItem;
    public Image heldItemVisual;
    public List<Sprite> spriteChoices;
    //private int currentSprite = 0;
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

    public bool chopIngredient()
    {
        if(heldItem.text == "Held Item: Lettuce" || heldItem.text == "Held Item: Tomato" || heldItem.text == "Held Item: Cheese")
        {
            return true;
        }
        return false;
    }

    public bool cookPatty()
    {
        if(heldItem.text == "Held Item: Raw Patty")
        {
            return true;
        }
        return false;
    }
    public void updateInventory(string ing)
    {
        heldItem.text = "Held Item: " + ing;
        setSprite();        
    }

    public string getInventory()
    {
        return heldItem.text.Substring(11);
    }

    public void setSprite()
    {
        string spriteName = heldItem.text.Substring(11);
        switch(spriteName)
        {
            case "None":
                heldItemVisual.sprite = spriteChoices[0];
                break;
            case "Lettuce":
                heldItemVisual.sprite = spriteChoices[1];
                break;
            case "Chopped Lettuce":
                heldItemVisual.sprite = spriteChoices[2];
                break;
            case "Tomato":
                heldItemVisual.sprite = spriteChoices[3];
                break;
            case "Chopped Tomato":
                heldItemVisual.sprite = spriteChoices[4];
                break;
            case "Cheese":
                heldItemVisual.sprite = spriteChoices[5];
                break;
            case "Chopped Cheese":
                heldItemVisual.sprite = spriteChoices[6];
                break;
            case "Raw Patty":
                heldItemVisual.sprite = spriteChoices[7];
                break;
            case "Cooked Patty":
                heldItemVisual.sprite = spriteChoices[8];
                break;
            case "Bun":
                heldItemVisual.sprite = spriteChoices[9];
                break;
        }
    }

    public void checkForWin(int w)
    {
        if(w == 5)
        {
            Thread.Sleep(2000);
        }
    }

    
}

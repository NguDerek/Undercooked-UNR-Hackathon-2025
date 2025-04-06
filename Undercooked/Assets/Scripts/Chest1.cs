using UnityEngine;

public class Chest1 : MonoBehaviour, IInteractable
{
    public bool isOpened {get; private set;}
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public bool CanInteract(){
        throw new System.NotImplementedException();
    }

    public void Interact(){
        throw new System.BotImplementedException();
    }

    private void OpenChest(){

    }
}

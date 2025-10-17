using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Switch : Stuff, IInteractable
{
    public Switch() { 
        Name = "Switch";
    }
    public bool isInteractable { get => CanUse; set => CanUse = value; }
    [SerializeField]
    bool isOn = false;
    Animator animator;
    public Identity InteracTo;
    IInteractable IInteract
    {
        get
        {
            return InteracTo as IInteractable;
        }
    }

    public void Interact(Player player)
    {
        isOn = !isOn;
        if (IInteract != null)
        {
            IInteract.Interact(player);
        }
    }
}


using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Box : Stuff, IDestoryable, IInteractable
{
    public Box() {
        Name = "Box";
    }
    public GameObject DropItem;
    public bool isInteractable 
    { 
        get => CanUse; 
        set => CanUse = value; 
    }
    public int health 
    {
        get => _health;
        set => _health = value;
    }
    public int maxHealth 
    { 
        get => _maxHealth; 
        set => _maxHealth = value;
    }

    private int _health;
    private int _maxHealth = 25;

    Rigidbody rb;

    public override void SetUP()
    {
        base.SetUP();
        rb = GetComponent<Rigidbody>();
    }

    public event Action<IDestoryable> OnDestroy;

    public void Interact(Player player)
    {
        rb.isKinematic = !rb.isKinematic;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
        {
            Destroy(gameObject);
            Debug.Log($"{Name} destroyed");
        }
    }
}

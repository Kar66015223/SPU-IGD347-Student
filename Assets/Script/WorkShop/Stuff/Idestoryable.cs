using UnityEngine;

public interface IDestoryable
{
    int health { get; set; }

    int maxHealth { get; set; }

    void TakeDamage(int damageAmount);

    event System.Action<IDestoryable> OnDestroy;
}

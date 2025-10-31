using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public void TakeDamage(int amount, DataPlayer dataPlayer)
    {
        dataPlayer.Health -= amount;
        Debug.Log($"{dataPlayer.PlayerName} took {amount} damage. Health: {dataPlayer.Health}");
        if (dataPlayer.Health <= 0)
        {
            Debug.Log($"{dataPlayer.PlayerName} has been defeated!");
        }
    }
}

using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void SaveProgress(DataPlayer dataPlayer)
    {
        Debug.Log($"Saving game for {dataPlayer.PlayerName} to local file...");
        // Logic for saving player data to a file
    }
}

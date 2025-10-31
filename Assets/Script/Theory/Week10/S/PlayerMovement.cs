using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public void Move(DataPlayer dataPlayer, float deltaX, float deltaY)
    {
        dataPlayer.PositionX += deltaX;
        dataPlayer.PositionY += deltaY;
        Debug.Log($"{dataPlayer.PlayerName} moved to ({dataPlayer.PositionX}, {dataPlayer.PositionY})");
    }
}

using UnityEngine;
using UnityEngine.EventSystems;

public class TouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum Direction { Left, Right }
    public Direction direction;
    private PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (direction == Direction.Left)
            player.MoveLeft();
        else if (direction == Direction.Right)
            player.MoveRight();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        player.StopMoving();
    }
}
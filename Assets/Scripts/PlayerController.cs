using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

#if UNITY_ANDROID
    private int moveDirection = 0;
#endif

    public void MoveLeft()
    {
#if UNITY_ANDROID
        moveDirection = -1;
#endif
    }

    public void MoveRight()
    {
#if UNITY_ANDROID
        moveDirection = 1;
#endif
    }

    public void StopMoving()
    {
#if UNITY_ANDROID
        moveDirection = 0;
#endif
    }

    void Update()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        // Movimiento con teclas A y D
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
#elif UNITY_ANDROID
        transform.Translate(Vector2.right * moveDirection * speed * Time.deltaTime);
#endif
    }
}
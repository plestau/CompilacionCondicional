using UnityEngine;

public class CanvasController : MonoBehaviour
{
    void Start()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        gameObject.SetActive(false); // Oculta el Canvas en PC
#elif UNITY_ANDROID
        gameObject.SetActive(true); // Muestra el Canvas en Android
#endif
    }
}
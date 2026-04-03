using UnityEngine;

public class AbriEnlace : MonoBehaviour
{
    public void AbrirURL(string url)
    {
        Debug.Log("CLICK: " + url);
        Application.OpenURL(url);
    }
}
using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    public void AbrirURL(string url)
    {
        Application.OpenURL(url);
    }
}

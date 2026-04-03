using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TMP_Text textoObjetivo;
    public float incremento = 4f;
    public float tamanioMin = 18f;
    public float tamanioMax = 72f;

    public void AumentarFuente()
    {
        if (textoObjetivo.fontSize < tamanioMax)
        {
            textoObjetivo.fontSize += incremento;
        }
    }

    public void DisminuirFuente()
    {
        if (textoObjetivo.fontSize > tamanioMin)
        {
            textoObjetivo.fontSize -= incremento;
        }
    }
}
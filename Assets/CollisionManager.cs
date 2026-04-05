using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Animator bubble1Animator;
    public Animator bubble2Animator;
    public Animator bubble3Animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Fuego")
        {
            Debug.Log("Unity está sobre el fuego");

            bubble1Animator.SetBool("isBubbling", true);
            bubble2Animator.SetBool("isBubbling", true);
            bubble3Animator.SetBool("isBubbling", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Fuego")
        {
            Debug.Log("Unity salió del fuego");

            bubble1Animator.SetBool("isBubbling", false);
            bubble2Animator.SetBool("isBubbling", false);
            bubble3Animator.SetBool("isBubbling", false);
        }
    }
}
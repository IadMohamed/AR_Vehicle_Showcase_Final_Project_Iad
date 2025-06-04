using UnityEngine;

public class CarAnimationController : MonoBehaviour
{
    public Animator carAnimator; // Assign your Animator in the Inspector
    public string triggerName = "Play"; // Animator trigger to set

    public void PlayAnimation()
    {
        if (carAnimator != null)
        {
            carAnimator.SetTrigger(triggerName);
        }
        else
        {
            Debug.LogWarning("Animator not assigned.");
        }
    }
}

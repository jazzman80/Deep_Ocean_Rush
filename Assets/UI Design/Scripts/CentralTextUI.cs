using UnityEngine;

public class CentralTextUI : MonoBehaviour
{
    [SerializeField] EventBus eventBus;
    [SerializeField] Animator animator;

    private void Start()
    {
        eventBus.countdownCompleteEvent.AddListener(FlyAway);
    }

    private void FlyAway()
    {
        animator.Play("Flyaway");
    }
}

using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ChangeAnimation()
	{
        int randomInt = UnityEngine.Random.Range(0, 3);
        animator.SetInteger("triggerIndex", randomInt);
    }
}

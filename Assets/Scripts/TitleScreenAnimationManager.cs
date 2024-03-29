using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenAnimationManager : MonoBehaviour
{

    [SerializeField] Animator animator;
    private string currentState;

    public const string TITLESCREEN_IDLE = "titlescreen_idle";
    public const string TITLESCREEN_FADE_IN = "titlescreen_fadein";
    public const string TITLESCREEN_FADE_OUT = "titlescreen_fadeout";

    public void ChangeAnimationState(string newState)
    {
        if (newState == currentState)
        {
            return;
        }

        animator.Play(newState);
        currentState = newState;
    }
    public float GetCurrentAnimationDuration()
    {
        return animator.GetCurrentAnimatorStateInfo(0).length;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public Animator animator;

    protected override void Die()
    {
        Debug.Log("Die() called");
        if (animator != null)
        {
            Debug.Log("SetTrigger DieTrigger called");
            animator.SetTrigger("DieTrigger");
        }
        else
        {
            Debug.LogError("Animator is not assigned in the Inspector!");
        }
        Debug.Log("Game Over!");
        Destroy(gameObject, 1f); // 1f = thời gian animation nổ
    }
}
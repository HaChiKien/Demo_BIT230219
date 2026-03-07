using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public Animator animator;

    public static int LivingEnemyCount;

    private void Awake()
    {
        LivingEnemyCount++;
    }

    protected override void Die()
    {
        LivingEnemyCount--;
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
        Destroy(gameObject, 1f); // 1f = thời gian animation nổ
    }
    void Update()
    {
        if (animator != null && animator.GetCurrentAnimatorStateInfo(0).IsName("EnemyExplosion"))
        {
            Debug.Log("EnemyExplosion animation is playing.");
        }
    }
}
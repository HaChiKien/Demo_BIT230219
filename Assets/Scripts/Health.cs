using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int defaultHealthPoint = 100;
    protected int healthPoint;

    protected virtual void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public virtual void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    private void Awake()
    {
        health = maxHealth;
    }
    private void Update()
    {
        if (health <= 0)
        {
            health = 0;
            gameObject.SetActive(false);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

}

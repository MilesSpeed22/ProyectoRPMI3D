using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Player Health")]
    [SerializeField] float health;
    [SerializeField] float maxHealth = 100f;
    [SerializeField] RectTransform healthFill;
    Vector3 originalScale;
    void Start()
    {
        health = maxHealth;
        originalScale = healthFill.localScale;
    }

    void Update()
    {
        
    }


    public void Death()
    {
        if (health <= 0)
        {
            //Esto esta de prueba
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            health -= 1;
            health = Mathf.Clamp(health, 0, maxHealth);
            UpdateBar();
        }
    }

    void UpdateBar()
    {
        float percent = health / maxHealth;

        healthFill.localScale = new Vector3(originalScale.x * percent, originalScale.y, originalScale.z);
    }
}

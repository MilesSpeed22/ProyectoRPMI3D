using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Player Health")]
    [SerializeField] float health;
    [SerializeField] float maxHealth = 100f;
    void Start()
    {
        health = maxHealth;  
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
            Debug.Log("Daño");
        }
    }
}

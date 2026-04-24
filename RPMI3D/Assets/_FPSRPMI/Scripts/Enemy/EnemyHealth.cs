using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Health System Configuration")]
    [SerializeField] float health;
    [SerializeField] float maxHealth;

    [Header("Feedback config")]
    [SerializeField] Material damagedMat; //Material de feedback de daño
    [SerializeField] MeshRenderer enemyRend; //Renderer del modelo
    [SerializeField] GameObject deathVfx;
    Material baseMat; //MAterial base del modelo
    GameObject model;
    MeshRenderer modelRend;


    private void Start()
    {
        model = GameObject.Find("Body");
        modelRend = model.GetComponent<MeshRenderer>();
        health = maxHealth;
    }

    private void Update()
    {
        HealthManagement();
    }

    void HealthManagement()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

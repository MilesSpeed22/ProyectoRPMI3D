using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    [Header("Health System Configuration")]
    [SerializeField] float health;
    [SerializeField] float maxHealth;

    [Header("Feedback config")]
    [SerializeField] Material damagedMat;
    [SerializeField] MeshRenderer enemyRend;
    [SerializeField] GameObject deathVfx;
    Material baseMat;
    GameObject model;
    MeshRenderer modelRend;

    [SerializeField] TargetManager targetManager;

    private void Start()
    {
        model = GameObject.Find("Body").gameObject;
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
            targetManager.TargetElimination();
            gameObject.SetActive(false);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

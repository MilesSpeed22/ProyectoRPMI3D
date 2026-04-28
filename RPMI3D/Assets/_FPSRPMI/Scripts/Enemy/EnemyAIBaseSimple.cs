using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAIBaseSimple : MonoBehaviour
{
    [Header("AI Config")]
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;

    private void Awake()
    {
        target = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(target.position);
        transform.LookAt(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Animacion de muerte si es que al final hay
            SceneManager.LoadScene(3);
        }
    }
}

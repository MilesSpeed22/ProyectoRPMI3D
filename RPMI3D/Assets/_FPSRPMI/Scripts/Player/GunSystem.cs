using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunSystem : MonoBehaviour
{
    #region General Variables
    [Header("General Variables")]
    [SerializeField] Camera fpsCam;
    [SerializeField] RaycastHit hit;
    [SerializeField] LayerMask interactableLayer;
    [SerializeField] AudioSource weaponSound;

    [Header("Interactable Stats")]
    public float range;
    public float shootingCooldown;
    public int damage;

    [Header("State Bools")]
    [SerializeField] bool shooting;
    [SerializeField] bool canShoot;

    [Header("Feedback and Graphics")]
    [SerializeField] GameObject muzzleFlash;
    #endregion

    private void Awake()
    {
        weaponSound = GetComponent<AudioSource>();
        canShoot = true;
    }

    private void Update()
    {
        Inputs();
    }

    void Inputs()
    {
        if (canShoot && shooting) Shoot();
    }

    void Shoot()
    {
        AudioManager.Instance.PlaySFX(3);
        canShoot = false;
        Vector3 direction = fpsCam.transform.forward;

        if (Physics.Raycast(fpsCam.transform.position, direction, out hit, range, interactableLayer)) 
        { 
            if (hit.collider.CompareTag("Enemy"))
            {
                TargetHealth enemyScript = hit.collider.GetComponent<TargetHealth>();
                enemyScript.TakeDamage(damage);

            }
        }
        if (!IsInvoking(nameof(ResetShoot)) && !canShoot)
        {
            Invoke(nameof(ResetShoot), shootingCooldown);
        } 
    }

    void ResetShoot()
    {
        canShoot = true;
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            muzzleFlash.SetActive(true);
            shooting = true;
        }
        if (context.canceled)
        {
            muzzleFlash.SetActive(false);
            shooting = false;
        }
    }
}



using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 50f;
    public float range = 1000f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    AudioSource shootingSound;
  
    void Start(){
        shootingSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    void Shoot(){
        muzzleFlash.Play();
        shootingSound.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}

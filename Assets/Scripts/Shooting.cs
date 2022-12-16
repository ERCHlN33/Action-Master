using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Shooting : MonoBehaviour
{

    [SerializeField]
    float coin;
    public Text coinText;
    public Text healthText;
    public Transform EnemyTarget;
    public Animator anim;
    public float ammoTimer;
    Weapon Weapon; 
    public GameObject dagger;
    public GameObject axe;
    public GameObject pickaxe;
    public GameObject clup;
    GameObject ammo;
    public static float Health = 100;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Weapon.selected)
        {
            this.gameObject.transform.position = new Vector3(0, 0, 0);
            Weapon.selected= false;
        }

        coinText.text = coin.ToString() + (" coin");
        healthText.text = Health.ToString();



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyTarget = other.gameObject.transform;
        }

        if (other.gameObject.CompareTag("Enemy"))
         {
             if (Weapon.picaxe)
             {
                 GameObject ammoObj = Instantiate(pickaxe, new Vector3(transform.position.x, 1, transform.position.z + 2), transform.rotation);
                 anim.SetTrigger("Throwing");
                 var rb = ammoObj.AddComponent<Rigidbody>();
                 rb.useGravity = false;
                 rb.velocity = Vector3.zero;
                 ammoObj.transform.DOMove(EnemyTarget.position, ammoTimer).SetEase(Ease.Linear);
              
            }
            /* if (Weapon.axe)
             {
                 GameObject ammoObj = Instantiate(axe, new Vector3(transform.position.x, 1, transform.position.z + 2), transform.rotation);
                 anim.SetTrigger("Throwing");
                 var rb = ammoObj.AddComponent<Rigidbody>();
                 rb.useGravity = false;
                 rb.velocity = Vector3.zero;
                 ammoObj.transform.DOMove(EnemyTarget.position, ammoTimer).SetEase(Ease.Linear);
             }*/
             if (Weapon.dagger)
             {
                 GameObject ammoObj = Instantiate(dagger, new Vector3(transform.position.x, 1, transform.position.z + 2), transform.rotation);
                 anim.SetTrigger("Throwing");
                 var rb = ammoObj.AddComponent<Rigidbody>();
                 rb.useGravity = false;
                 rb.velocity = Vector3.zero;
                 ammoObj.transform.DOMove(EnemyTarget.position, ammoTimer).SetEase(Ease.Linear);
             }
             if (Weapon.clup)
             {
                 GameObject ammoObj = Instantiate(clup, new Vector3(transform.position.x, 1, transform.position.z + 2), transform.rotation);
                 anim.SetTrigger("Throwing");
                 var rb = ammoObj.AddComponent<Rigidbody>();
                 rb.useGravity = false;
                 rb.velocity = Vector3.zero;
                 ammoObj.transform.DOMove(EnemyTarget.position, ammoTimer).SetEase(Ease.Linear);
             }
            if (other.gameObject.CompareTag("Coin"))
            {
                coin++;
                Destroy(other.gameObject);
            }
            if (other.gameObject.CompareTag("EnemyAmmo"))
            {
                Health--;




            }

        }

       
     }
   
}
    




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    public GameObject coin;
    Shooting Shooting;
    public Transform player;
    public GameObject ammo;
    public float enemyAmmoTimer;
    bool shooted=true;
    public float timer;
    public float fail=0.05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        

        if( this.gameObject.transform.position.z-player.transform.position.z<20 && this.gameObject.transform.position.z - player.transform.position.z >1)
        {
            timer -= Time.deltaTime;
            if (timer < 9)
            {
                timer = 12;
                GameObject ammoObj = Instantiate(ammo, transform.position, transform.rotation);
                var rb = ammoObj.AddComponent<Rigidbody>();
                rb.useGravity = false;
                rb.velocity = Vector3.zero;
                ammoObj.transform.DOMove(new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z), enemyAmmoTimer).SetEase(Ease.Linear);
               
            }
           
           


        }
    }
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.CompareTag("ammo"))
        {
            Destroy(other.gameObject);
            GameObject coinObj = Instantiate(coin, new Vector3(transform.position.x,1,transform.position.z), transform.rotation);
            var rb = coinObj.AddComponent<Rigidbody>();
            rb.useGravity = false;
            Destroy(this.gameObject);

           


        }

    }
   
}

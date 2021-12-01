using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLeft : MonoBehaviour
{

    public GameObject theBullet;
    public Transform barrelEnd;

    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 0.25f;
    public Animator anim;

    public bool fire = false;


    void Start()
    {
        anim = GetComponentInChildren<Animator>();


    }
    //press space to fire the main cannon
    private void Update()
    {

    }

    IEnumerator ShootingYield()
    {
        //code to let player put cool down on thier shots to simulate a reload
        yield return new WaitForSeconds(waitBeforeNextShot);
        shootAble = true;

    }
    // for spawning the shell on the tanks cannon
    public void Shootleft()
    {

        if(shootAble == true)
        {
            var bullet = Instantiate(theBullet, barrelEnd.position, barrelEnd.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
            Destroy(bullet, despawnTime);
            shootAble = false;
            StartCoroutine(ShootingYield());
        }
    }
}
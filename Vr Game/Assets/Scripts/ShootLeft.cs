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

    

    [SerializeField] public GameObject fire;
    [SerializeField] public GameObject water;
    [SerializeField] public GameObject noType;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        theBullet = noType;

    }
    //press space to fire the main cannon
    private void Update()
    {
        if (gameObject.tag == "WaterWand")
        {
            theBullet = water;
        }
        else if (gameObject.tag == "FireWand")
        {
            theBullet = fire;
        }
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
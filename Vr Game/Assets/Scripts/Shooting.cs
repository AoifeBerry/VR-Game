using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    private GameObject theBullet;
    public Transform barrelEnd;

    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot;
    public Animator anim;

    [SerializeField] public GameObject firewand;
        [SerializeField] public GameObject waterwand;
        [SerializeField] public GameObject earthwand;
        [SerializeField] public GameObject windwand;
    [SerializeField] public GameObject duckwand;
    [SerializeField] public GameObject fire;
    [SerializeField] public GameObject water;
    [SerializeField] public GameObject earth;
    [SerializeField] public GameObject wind;
    [SerializeField] public GameObject ducks;
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
            firewand.SetActive(false);
            waterwand.SetActive(true);
            windwand.SetActive(false);
            earthwand.SetActive(false);
            duckwand.SetActive(false);
            
        }
        else if (gameObject.tag == "FireWand")
        {
            theBullet = fire;
            firewand.SetActive(true);
            waterwand.SetActive(false);
            windwand.SetActive(false);
            earthwand.SetActive(false);
            duckwand.SetActive(false);
        }
        else if (gameObject.tag == "EarthWand")
        {
            theBullet = earth;
            firewand.SetActive(false);
            waterwand.SetActive(false);
            windwand.SetActive(false);
            earthwand.SetActive(true);
            duckwand.SetActive(false);
        }
        else if (gameObject.tag == "WindWand")
        {
            theBullet = wind;
            firewand.SetActive(false);
            waterwand.SetActive(false);
            windwand.SetActive(true);
            earthwand.SetActive(false);
            duckwand.SetActive(false);
        }
        else if (gameObject.tag == "DuckWand")
        {
            theBullet = wind;
            firewand.SetActive(false);
            waterwand.SetActive(false);
            windwand.SetActive(false);
            earthwand.SetActive(false);
            duckwand.SetActive(true);
        }
    }

    IEnumerator ShootingYield()
    {
        //code to let player put cool down on thier shots to simulate a reload
        yield return new WaitForSeconds(waitBeforeNextShot);
        shootAble = true;

    }
    // for spawning the shell on the tanks cannon
    void Shoot()
    {
        if (shootAble == true)
        {
            
            var bullet = Instantiate(theBullet, barrelEnd.position, barrelEnd.rotation);
            bullet.transform.Rotate(0f, 0f, 180f);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
            
            Destroy(bullet, despawnTime);
            shootAble = false;
            StartCoroutine(ShootingYield());
        }
        

    }
}
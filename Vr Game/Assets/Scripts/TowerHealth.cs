using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TowerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject textbox1;
    public GameObject textbox2;
    public GameObject textbox3;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }
   

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("EnemyFire"))
        {
            Debug.Log("FireEnemy");
            TakeDamage(5);
        }
        if (collision.gameObject.CompareTag("EnemyWater"))
        {
            Debug.Log("waterEnemy");
            TakeDamage(5);
        }
        if (collision.gameObject.CompareTag("EnemyAir"))
        {
            Debug.Log("AirEnemy");
            TakeDamage(5);
        }
    }
    // Update is called once per frame
 

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            textbox1.SetActive(true);
            StartCoroutine(EndScene());

        }
    }
    IEnumerator EndScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("EndScene");
    }
}

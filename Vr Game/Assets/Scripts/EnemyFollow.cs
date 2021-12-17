using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform Player;
    [SerializeField] float Speed;
    // Start is called before the first frame update
    void Start()
    {
        enemy.speed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
        enemy.speed = Speed;
    }
    public void SpeedDown()
    {
        Speed = 0.5f;
        StartCoroutine(SpeedUp());
    }
    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(6);
        Speed = 1.0f;
    }
}
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [Header("Movement")]
    public float fallSpeed = 1.2f;

    [Header("Reward")]
    public int recompensa = 0;

    [Header("Effect")]
    public GameObject particlePrefab;


    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Colisão com o chão
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
            SpawnEffect(transform.position);
        }

        //Colisão com o player
        if (collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);

    }

    void SpawnEffect(Vector3 position)
    {
        // Instantiate the prefab at the target position
        if(particlePrefab != null)
            Instantiate(particlePrefab, position, Quaternion.identity);
    }

    public int GetRecompensa()
        { return recompensa; }
}

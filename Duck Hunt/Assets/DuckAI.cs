using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAI : MonoBehaviour
{
    [SerializeField] bool flyRight = false;
    Vector3 position = Vector3.zero;
    [SerializeField] float movementSpeed;
    [SerializeField] float randomChance = 0.6f;

    Spawner Spawnerspawner;

    float time = 1f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        float rando = Random.value;
        if (rando > randomChance)
        {
            flyRight = !flyRight;
        }
    }

    // Update is called once per frame
    void Update()
    {
        position.y += movementSpeed * Time.deltaTime;

        if (flyRight)
        {
            position.x += movementSpeed/2 * Time.deltaTime;
        }
        else
        {
            position.x -= movementSpeed/2 * Time.deltaTime;
        }

        transform.position = position;

        if (time < 0)
        {
            float rando = Random.value;
            if (rando > randomChance)
            {
                flyRight = !flyRight;
            }
            time = 1f;
        }
        else
        {
            time -= Time.deltaTime;
        }

        if(position.y > 6)
        {
            Escape();
        }
    }

    public void Kill()
    {
        Destroy(this);
        Spawnerspawner.KilledDuck();
    }

    public void Escape()
    {
        Destroy(this);
        Spawnerspawner.EscapedDuck();
    }

    public void setSpawner(Spawner go)
    {
        Spawnerspawner = go;
    }
}

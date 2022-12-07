using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    Vector3 position = Vector3.zero;

    CircleCollider2D triggerCollider;

    DuckAI duckInCrosshair = null;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        triggerCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (duckInCrosshair != null)
            {
                duckInCrosshair.Kill();
            }
        }
    }

    public void moveUp()
    {
        position.y += movementSpeed * Time.deltaTime;
    }

    public void moveDown()
    {
        position.y -= movementSpeed * Time.deltaTime;
    }

    public void moveLeft()
    {
        position.x -= movementSpeed * Time.deltaTime;
    }

    public void moveRight()
    {
        position.x += movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        duckInCrosshair = other.GetComponent<DuckAI>();
        Debug.Log("Duck IN");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        duckInCrosshair = null;
        Debug.Log("Duck Out");
    }
}

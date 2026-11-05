using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputTEST1 : MonoBehaviour
{
    public SpriteRenderer sprite;
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position = new Vector3(transform.position.x + horizontal * speed * Time.deltaTime, transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, transform.position.y + vertical * speed * Time.deltaTime, transform.position.z);
    }
}

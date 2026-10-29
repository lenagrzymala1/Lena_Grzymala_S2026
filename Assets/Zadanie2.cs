using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    public List<GameObject> obiekty = new List<GameObject>();

    public Gradient gr;
    public float angle = 15;
    void Start()
    {
        SortObj();
    }

    void SortObj()
    {
        foreach (GameObject go in obiekty)
        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Sprite(go.GetComponent<SpriteRenderer>());
            }
            else if(go.GetComponent<MeshRenderer>() != null)
            {
                Cube(go.transform);
                Debug.Log(go.name);
            }
        }
    }

    void Sprite(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y);
    }

    void Cube(Transform tran)
    {
        tran.Rotate(angle * Time.deltaTime, 0, 0);
    }

    void Update()
    {
        SortObj();
    }
}

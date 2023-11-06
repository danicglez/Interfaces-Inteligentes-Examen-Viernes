using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class zombie_movement : MonoBehaviour
{
    public float speed = 1f;
    public delegate void message();
    public event message evento;

    public GameObject pizarra;
    private float distance = 3f;

    // Start is called before the first frame update
    void Start()
    {
        pizarra = GameObject.FindWithTag("pizarra");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
        if (Input.GetKeyDown("t"))
        {
            transform.position = new Vector3(4, -4, -2);
        }
        if (distance >= (transform.position.z - pizarra.transform.position.z))
        {
            if (evento != null)
            {
                evento();
            }
        }
    }
}

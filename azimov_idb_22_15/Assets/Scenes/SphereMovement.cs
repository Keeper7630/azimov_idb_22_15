using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SphereMovement : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI counter;

    private Rigidbody rb;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 100;
        counter.text = "������� 2\n�������: " + count.ToString();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.back * speed;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Testobj"))
        {
            --count;
            counter.text = "������� 2\n�������: " + count.ToString();
            transform.position = transform.position + new Vector3(0, 0, 15f);
        }
    }
}
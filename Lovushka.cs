using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lovushka : MonoBehaviour
{
    Rigidbody2D rb;

    public delegate void Delegate(string value);
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
            
    }

    private void OnTriggerEnter2d(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Plauer"))
        {
            rb.isKinematic = false;
        }    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Plauer"))
        {
            Debug.Log("GameOver");
        }
    }

    
    public void Shake(Delegate testDelegate)
    {
        testDelegate?.Invoke(_Shake);
    }

    private void TestDelegateMethod(string value)
    {
        Debug.Log(value);
    }

    private void TestDelegateMethod2(string value)
    {
        Debug.LogWarning(value);
    }

    private void TeseMethod(string y)
    {
        throw new System.NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<Superman> () != null)
        {
            GameController.instance.SupermanScored ();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float Speed=1;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(3f,7f);
        Destroy(gameObject , 5);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("updatting");
        Vector3 vector3 = new Vector3(0,-1*Speed*Time.deltaTime,0);
        transform.Translate(vector3);
        
    }
    private void OnMouseDown() {
        UIManger.clickedOnCounter++;
        Destroy(gameObject);
    }
}

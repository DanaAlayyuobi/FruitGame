using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerManeger : MonoBehaviour
{
    public GameObject[] objPreFap;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createObjs",0,0.5f);
        
    }

    // Update is called once per frame
    void createObjs() {
        int index = Random.Range(0, objPreFap.Length) ;
        Instantiate(objPreFap[index], RandomPositon(), Quaternion.identity);

    }

    private Vector3 RandomPositon() {

        float x = Random.Range(-10f, 10f);
        float y = Random.Range(6f, 10f);
        Vector3 vector3 = new Vector3(x, y, 0);
        return vector3;
    }
}

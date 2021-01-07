using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAreaController : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject ConePrefab;
    public GameObject CarPrefab;

    private GameObject unitychan;
    private float difference;
    // Start is called before the first frame update
    void Start()
    {

        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag")
        {
           
        }
        if (other.gameObject.tag == "TrafficConeTag")
        {
            
        }
    }
}

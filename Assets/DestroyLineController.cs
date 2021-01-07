using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLineController : MonoBehaviour
{
    //unitychanのオブジェクト
    private GameObject unitychan;
    //Unitychanとの距離
    private float deifference;
    // Start is called before the first frame update
    void Start()
    {
        //Unitychanのオブジェクトを取得
        unitychan = GameObject.Find("unitychan");
        //DestroyLineとUnitychanの距離を設定
        this.deifference = this.unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unitychanに一定の距離を保って移動
        this.transform.position = new Vector3(0f, this.transform.position.y, this.unitychan.transform.position.z - this.deifference);
    }


    //DestroyLineオブジェクトに当たったアイテムを破棄する
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="CoinTag")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag =="TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }
    }
    
    
}

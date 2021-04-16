using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        //キューブ同士の接触、キューブが地面についたとき
        if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            //効果音を鳴らす
            GetComponent<AudioSource>().Play();
        }

        //UnityChan2Dが接触したら
        if (collision.gameObject.tag == "UnityChan2D")
        {
            //効果音を鳴らさない
            GetComponent<AudioSource>().Stop();
        }
    }
}
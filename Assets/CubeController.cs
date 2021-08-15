using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2Dが呼ばれているか");
        if(collision.gameObject.tag == "CubePrefabTag")
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("if文が呼ばれているか");
        }
        if (collision.gameObject.tag == "groundTag")
        { 
            GetComponent<AudioSource>().Play();
            Debug.Log("a");
        }
    }
}

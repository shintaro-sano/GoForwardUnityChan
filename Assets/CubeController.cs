using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D���Ă΂�Ă��邩");
        if(collision.gameObject.tag == "CubePrefabTag")
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("if�����Ă΂�Ă��邩");
        }
        if (collision.gameObject.tag == "groundTag")
        { 
            GetComponent<AudioSource>().Play();
            Debug.Log("a");
        }
    }
}

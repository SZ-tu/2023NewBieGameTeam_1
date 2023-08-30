using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    [SerializeField] private float blockLifeTime;
    [SerializeField] private float blockLife;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (blockLife < 0)
        {
            //BlockLifeTime�b��ɃI�u�W�F�N�g������
            blockLifeTime = blockLifeTime - Time.deltaTime;
            if (blockLifeTime < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Board"))
        {
            blockLife = 1;
        }
        if (other.gameObject.CompareTag("Ha") && blockLife < 0)
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Chi") && blockLife < 0)
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Ya") && blockLife < 0)
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Block") && blockLife < 0)
        {
            Destroy(this.gameObject);
        }
    }
}

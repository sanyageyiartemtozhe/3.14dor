using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScr : MonoBehaviour
{
    [SerializeField] PlayerAttacking PA;
    Vector3 BulletEndDist;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        PA = GameObject.Find("Attack").GetComponent<PlayerAttacking>();
        BulletEndDist = transform.position + transform.forward * PA.trailDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == BulletEndDist)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.forward * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            // Decrease health
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}

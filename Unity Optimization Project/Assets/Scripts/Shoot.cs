using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;

    private BulletPool bulletPool;

    // Use this for initialization
    void Start()
    {
        bulletPool = GetComponent<BulletPool>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //GameObject go = GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
            GameObject go = bulletPool.GetBullet();
            go.transform.position = transform.position;
            go.GetComponent<Rigidbody>().velocity = transform.forward * 50;
            //Destroy(go, 3);  
            StartCoroutine(DestroyBullet(go));
        }
    }
    IEnumerator DestroyBullet(GameObject go)
    {
        yield return new WaitForSeconds(3);
        go.SetActive(false);
    }
}

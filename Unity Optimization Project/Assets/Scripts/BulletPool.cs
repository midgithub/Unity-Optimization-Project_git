using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour {

    public int poolCount = 30;

    public GameObject bulletPrefab;

    private List<GameObject> bulletList = new List<GameObject>();
    private void Start()
    {
        InitPool();
    }
    void InitPool()
    {
        for (int i = 0; i < poolCount; i++)
        {
            GameObject go = GameObject.Instantiate(bulletPrefab);
            bulletList.Add(go);
            go.SetActive(false);
            go.transform.parent = this.transform;
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject go in bulletList)
        {
            if (go.activeInHierarchy == false)
            {
                go.SetActive(true);
                return go;
            }
        }
        return null;
    }
}

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshConbiner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MeshFilter[] filters = GetComponentsInChildren<MeshFilter>();
        CombineInstance[] combiners = new CombineInstance[filters.Length];   
        for(int i=0;i<filters.Length;i++)
        {
            combiners[i].mesh = filters[i].sharedMesh;
            combiners[i].transform = filters[i].transform.localToWorldMatrix;
        }
        //合并后的Mesh
        Mesh finalMesh = new Mesh();
        finalMesh.CombineMeshes(combiners);
        this.GetComponent<MeshFilter>().sharedMesh = finalMesh;
	}
	
	
}

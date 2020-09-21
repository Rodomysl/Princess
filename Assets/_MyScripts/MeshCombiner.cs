using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyEngine
{
    // скрипт объединяет меши всех дочерних компонентов в один (например стену из кубиков) для повышения производительности
    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    [RequireComponent(typeof(MeshCollider))]
    public class MeshCombiner : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                CombineMeshes();
        }

        private void CombineMeshes()
        {
            MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
            CombineInstance[] combines = new CombineInstance[meshFilters.Length];

            for(int i = 0; i < meshFilters.Length; i++)
            {
                combines[i].mesh = meshFilters[i].sharedMesh;
                combines[i].transform = meshFilters[i].transform.localToWorldMatrix;
                meshFilters[i].gameObject.SetActive(false);
            }

            MeshFilter meshFilter = transform.GetComponent<MeshFilter>();
            meshFilter.mesh = new Mesh();
            meshFilter.mesh.CombineMeshes(combines);
            GetComponent<MeshCollider>().sharedMesh = meshFilter.mesh;
            transform.gameObject.SetActive(true);
        }
    }
}

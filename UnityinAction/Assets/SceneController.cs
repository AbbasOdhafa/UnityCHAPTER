using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate a new copy of the enemyPrefab
        GameObject enemyPrefabInstance = Instantiate(enemyPrefab) as GameObject;

        // Set the initial color to green
        enemyPrefabInstance.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);

            Renderer enemyRenderer = enemy.GetComponent<Renderer>();
            if (enemyRenderer != null)
            {
                // Generate a random color
                Color randomColor = new Color(Random.value, Random.value, Random.value);

                // Assign the random color to the material
                enemyRenderer.material.color = randomColor;
            }
        }
    }
}
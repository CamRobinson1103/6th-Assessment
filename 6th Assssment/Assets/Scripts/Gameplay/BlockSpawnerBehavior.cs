using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawnerBehavior : MonoBehaviour
{
    //The lowest y position allowed
    public float yMin;
    //The highest y position allowed
    public float yMax;
    //Time between pipe spawn
    public float TimeInterval;
    public bool GameOver = false;
    //Pipe reference
    public GameObject BlockRef;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBlock());
    }

    public IEnumerator SpawnBlock()
    {
        float randX = 0;
        while (!GameOver)
        {
            //Find a random spawn position for the pipe
            randX = Random.Range(yMin, yMax);
            Vector3 spawnPosition = new Vector3(transform.position.x, randX, transform.position.z);

            //Spawn in an instance of the pipe prefab at the given position with a default rotation
            GameObject PIPE = Instantiate(BlockRef, spawnPosition, new Quaternion());
            BlockMovementBehavior moveScript = PIPE.GetComponent<BlockMovementBehavior>();
            moveScript.StartCos = Random.Range(-1, 1);

            //Wait for the given time interval before resuming the function
            yield return new WaitForSeconds(TimeInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

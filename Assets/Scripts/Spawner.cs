using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject[] _block;

    private int _num;
    private float spawnTime = 3;
    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        BlockSpawer();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BlockSpawer()
    {
        _num = Random.Range(0, _block.Length);
        GameObject BlockController = Instantiate(_block[_num], transform.position, transform.rotation);

        BlockController.AddComponent<PlayerController>();
    }
}

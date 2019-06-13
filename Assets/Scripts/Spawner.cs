using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject[] _block;

    [SerializeField]
    GameObject _blockParent;
    
    private int _num;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BlockSpawner()
    {
        _num = Random.Range(0, _block.Length);
        GameObject BlockController = Instantiate(_block[_num], transform.position, transform.rotation);


        BlockController.transform.parent = _blockParent.transform;
        BlockController.AddComponent<PlayerController>();

    }
}

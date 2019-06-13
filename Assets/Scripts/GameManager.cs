using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    GameObject _blockParent;

    private Component[] _blocks;

    [SerializeField]
    GameObject _spawner;

    // Start is called before the first frame update
    void Start()
    {
        _spawner.GetComponent<Spawner>().BlockSpawner();
    }

    // Update is called once per frame
    void Update()
    {

        _blocks = _blockParent.GetComponentsInChildren<PlayerController>(true);

        if(_blocks.Length == 0)
        {
            _spawner.GetComponent<Spawner>().BlockSpawner();
        }

        /*        for(int i = 0; i < _blocks.Length; i++)
                    if (_blocks[i] != null)
                    {
                        Debug.Log(_blocks[i]);
                        return;
                    }else if(i == _blocks.Length - 1)
                    {
                        _spawner.GetComponent<Spawner>().BlockSpawner();
                    }
         */
    }
}

using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnDelay = 2f;

    private float _timeAfterSpawn;
    private int _spawnPoint = 0;

    private void Start()
    {
        _timeAfterSpawn = _spawnDelay;
    }

    private void Update()
    {
        SpawnEnemys();
    }

    private void SpawnEnemys()
    {
        if (_timeAfterSpawn <= 0)
        {
            if (_spawnPoint >= _spawnPoints.Length)
            {
                _spawnPoint = 0;
            }

            Instantiate(_template, _spawnPoints[_spawnPoint].transform.position, Quaternion.identity);
            _spawnPoint++;
            _timeAfterSpawn = _spawnDelay;

        }
        else
        {
            _timeAfterSpawn -= Time.deltaTime;
        }
    }
}

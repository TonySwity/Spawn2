using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnDelay = 2f;

    private float _timeAfterSpawn;
    private int _numberSpawnPoint = 0;

    private void Start()
    {
        _timeAfterSpawn = _spawnDelay;
    }

    private void Update()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        if (_timeAfterSpawn <= 0)
        {
            if (_numberSpawnPoint >= _spawnPoints.Length)
            {
                _numberSpawnPoint = 0;
            }

            Instantiate(_template, _spawnPoints[_numberSpawnPoint].transform.position, Quaternion.identity);
            _numberSpawnPoint++;
            _timeAfterSpawn = _spawnDelay;

        }
        else
        {
            _timeAfterSpawn -= Time.deltaTime;
        }
    }
}

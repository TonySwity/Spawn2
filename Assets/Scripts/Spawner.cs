using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _startTimeSpawns = 2f;

    private float _timeSpawns;
    private int _spawnPoint = 0;

    private void Start()
    {
        _timeSpawns = _startTimeSpawns;
    }

    private void Update()
    {
        SpawnEnemys();
    }

    private void SpawnEnemys()
    {
        if (_timeSpawns <= 0)
        {
            if (_spawnPoint >= _spawnPoints.Length)
            {
                _spawnPoint = 0;
            }

            Instantiate(_template, _spawnPoints[_spawnPoint].transform.position, Quaternion.identity);
            _spawnPoint++;
            _timeSpawns = _startTimeSpawns;

        }
        else
        {
            _timeSpawns -= Time.deltaTime;
        }
    }
}

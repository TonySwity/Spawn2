using UnityEngine;

public class TwoSpawnEnemys : MonoBehaviour
{
    [SerializeField] private GameObject _template;

    private Vector2[] _spawnPosition = { new Vector2(-7f, 4f), new Vector2(7f, 4f) };
    
    private void Start()
    {
        InvokeRepeating("InstantiateEnemys1", 2, 4); 
        InvokeRepeating("InstantiateEnemys2", 0, 4);
    }

    private void InstantiateEnemys1()
    {
        Instantiate(_template, _spawnPosition[0], Quaternion.identity);
    }

    private void InstantiateEnemys2()
    {
        Instantiate(_template, _spawnPosition[1], Quaternion.identity);
    }

}

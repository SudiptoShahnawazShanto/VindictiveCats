using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private float _timeAfterEnemiesDied;
    private Enemy[] _enemies;
    

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;
        }
  
        _timeAfterEnemiesDied += Time.deltaTime;

        if(_timeAfterEnemiesDied > 2)
        {
            if (_nextLevelIndex == 2) _nextLevelIndex = 1;
            else _nextLevelIndex++;
            string nextLevelName = "Level" + _nextLevelIndex;
            SceneManager.LoadScene(nextLevelName);
        }  
    }
}

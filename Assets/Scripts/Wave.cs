using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wave", menuName = "My project (2)/Wave", order = 0)]
public class Wave : ScriptableObject {
    
    public List<GameObject> enemy;
    public int enemyPerWave;
    public Wave nextWave;
}

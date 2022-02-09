using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject unitPrefab;

    static GameManager _instance;
    public static GameManager instance{
        get{
            return _instance;
        }
    }

    List<Unit> allies;
    List<Unit> enemies;

    void Awake(){
        _instance = this;
    }

    void Start()
    {
        initBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initBattle(){

        allies = new List<Unit>(5);
        //allies
        for(int i = 0; i < 5; ++i){
            Unit u = Instantiate<GameObject>(unitPrefab).GetComponent<Unit>();
            u.unit = Resources.Load<UnitScriptableObject>("Units/Knight");
            allies.Add(u);    
        }
        enemies = new List<Unit>(5);
        //enemies
        for(int i = 0; i < 5; ++i){
            Unit u = Instantiate<GameObject>(unitPrefab).GetComponent<Unit>();
            u.unit = Resources.Load<UnitScriptableObject>("Units/Bandit");
            enemies.Add(u);    
        }
        
    }
}

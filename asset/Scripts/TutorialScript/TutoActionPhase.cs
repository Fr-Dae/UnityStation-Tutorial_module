using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoActionPhase : Tutorial
{
    public GameObject TutoBot;
    public Transform SpawnPoint;
    public Tutorial TutoParent;
    
    ///change phase + send message
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 8)
        {
            TutoParent.TutoPhase = this.TutoPhase;
            
            if(TutoPhase != Phase.SpawnMove)
            {
                Message(Tutorial.BotGO);
                if(this.DeleteGO)
                    Destroy(this.gameObject);
            }
        }
    }

    ///starting phase
    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 8 && TutoPhase == Phase.SpawnMove)
        {
            SpawnTutoBot();
        }
    }

    ///SPAWN PHASE
    private void SpawnTutoBot()
    {
        if(GameObject.Find("TutoBot") != null)
            Destroy(this.gameObject);
        else
        {
            SpawnResult bot = Spawn.ServerPrefab(TutoBot, SpawnPoint.position, null, Quaternion.identity);
            Tutorial.BotGO = bot.GameObject;
            Tutorial.BotGO.GetComponent<Systems.MobAIs.MobFollow>().StartFollowing(PlayerList.Instance.InGamePlayers[0].GameObject);
            Tutorial.BotGO.GetComponent<TutoBot>().Tuto = TutoParent;
            this.Message(bot.GameObject);
            GameObject GO1 = GameObject.Find("NetworkTabs (Top Right windows)");
            GameObject GO2 = GameObject.Find("AdminUI");
            GO1.SetActive(false);
            GO2.SetActive(false);
        }

        if(this.DeleteGO)
            Destroy(this.gameObject);
    }
}

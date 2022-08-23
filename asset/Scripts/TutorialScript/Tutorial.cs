using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using Messages.Server.SoundMessages;

public class Tutorial : MonoBehaviour
{

    public static GameObject BotGO;
    public bool DeleteGO;
    public enum Phase
    {
        SpawnMove,
        Equip,
        Id,
        PdaInId,
        Light,
        Mask,
        NoAir,
        Food,
        FireArm,
        Heal,
        Farm,
        Evac,
        Leave

    }

    public Phase TutoPhase;

    public static LangBot langBot;
    private void Start()
    {
        //load languages file
        langBot = new LangBot(Path.Combine(Application.streamingAssetsPath, "languages/Lang_Bot_"+GameManager.Instance.language+".xml"), GameManager.Instance.language);
        //UI.ControlTabs.Instance.gameObject.SetActive(false);
    }

    ///Send message to chat depending on the phase
    public void Message(GameObject GO)
    {
        if(TutoPhase != Phase.Leave)
        {
            string message = Tutorial.langBot.GetString(TutoPhase.ToString());
            Chat.AddLocalMsgToChat(message, GO);
            
            AudioSourceParameters audioSourceParameters = new AudioSourceParameters(pitch: UnityEngine.Random.Range(0.8f, 1.2f));
            switch(TutoPhase)
            {
                case Phase.PdaInId :
                    SoundManager.PlayNetworkedAtPos(CommonSounds.Instance.BreakStone, PlayerList.Instance.InGamePlayers[0].GameObject.RegisterTile().WorldPosition, audioSourceParameters, sourceObj: gameObject);
                break;
                case Phase.Light :
                    SoundManager.PlayNetworkedAtPos(CommonSounds.Instance.ElectricShock, PlayerList.Instance.InGamePlayers[0].GameObject.RegisterTile().WorldPosition, audioSourceParameters, sourceObj: gameObject);
                break;
                case Phase.NoAir :
                    SoundManager.PlayNetworkedAtPos(CommonSounds.Instance.ExplosionDistant1, PlayerList.Instance.InGamePlayers[0].GameObject.RegisterTile().WorldPosition, audioSourceParameters, sourceObj: gameObject);
                break;
                case Phase.Evac :
                    SoundManager.PlayNetworkedAtPos(CommonSounds.Instance.ExplosionCreak1, PlayerList.Instance.InGamePlayers[0].GameObject.RegisterTile().WorldPosition, audioSourceParameters, sourceObj: gameObject);
                break;
            }
        }
        else
        {
            GameManager.Instance.onTuto = false;
            GameManager.Instance.DisconnectExpected = true;
            CustomNetworkManager.Instance.StopHost();
            SceneManager.LoadScene("Lobby");
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class NetworkManager : MonoBehaviour {

    private const string typeName = "Robot Game";
    private const string gameName = "Robot Game";
    GameObject[] spawnPoints;

    NetworkView nView;
    List<string> playerNames = new List<string>();
    List<GameObject> playerSpawns = new List<GameObject>();
    bool shwMainMenu = true;
    bool shwServerLobby;
    bool startGame;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        if (Application.loadedLevel == 0)
        {

            playerNames.Clear();

        }
    }
    void Start()
    {

        nView = GetComponent<NetworkView>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); 
        }
    }
    private void StartServer()
    {
        Network.InitializeServer(50, 2500, !Network.HavePublicAddress());
        MasterServer.RegisterHost(typeName, gameName);
    }
    void OnServerInitialized()
    {

        Debug.Log("Server Initializied");
    }
    private void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
    }

    void OnConnectedToServer()
    {
        Debug.Log("Server Joined");
        nView.RPC("ConnectedToLobby", RPCMode.All, "Player");
    }
    void OnGUI()
    {
        if (!Network.isClient && !Network.isServer)
        {
            if (shwMainMenu)
            {
                if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
                {
                    shwMainMenu = false;
                    shwMainMenu = false;
                    shwServerLobby = true;
                }
                if (GUI.Button(new Rect(100, 250, 250, 100), "Refresh Hosts"))
                {
                    RefreshHostList();
                }
                if (hostList != null)
                {
                    for (int i = 0; i < hostList.Length; i++)
                    {
                        if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName))
                            JoinServer(hostList[i]);
                    }
                }
            }
        }
        if (shwServerLobby)
        {
            for (int i = 0; i < playerNames.Count; i++)
            {

                GUI.Label(new Rect(50, 170 + (i * 25), 250, 500), playerNames[i]);
            }
            GUI.TextArea(new Rect(50, 170, 250, playerNames.Count * 25), "");


            if (!startGame)
            {
                if (GUI.Button(new Rect(50, 50, 250, 100), "Start Server"))
                {

                    startGame = true;
                    //MasterServer.RegisterHost(typeName, gameName);
                    StartServer();
                    //nView.RPC("StartGame", RPCMode.All);
                }
            }

            if (startGame)
            {
                if (GUI.Button(new Rect(50, 50, 250, 100), "Start Game"))
                {
                    shwServerLobby = false;
                    nView.RPC("StartGame", RPCMode.All, 1);


                    playerNames.Add("Player");
                    
                }
            }
        }
    }

    private HostData[] hostList;

    private void RefreshHostList()
    {
        MasterServer.RequestHostList(typeName);
    }

    void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        if (msEvent == MasterServerEvent.HostListReceived)
            hostList = MasterServer.PollHostList();
    }

    [RPC]
    void ConnectedToLobby(string playName)
    {
        playerNames.Add(playName);
    }
    [RPC]
    void StartGame(int mapNum)
    {


        Application.LoadLevel(mapNum);

        StartCoroutine(WaitToJoin());
    }
    
    IEnumerator WaitToJoin()
    {
        yield return new WaitForSeconds(3);
        SpawnPlayer();
    }

    public GameObject playerPrefab;


    List<GameObject> pSpawn = new List<GameObject>();


    
    void SpawnPlayer()
    {
        try
        {
            Debug.Log(Application.loadedLevel.ToString());
            GameObject[] spawn = GameObject.FindGameObjectsWithTag("Spawn");
            int spawnIndex = Random.Range(0, spawn.Length);
            Network.Instantiate(playerPrefab, new Vector3(spawn[spawnIndex].transform.position.x, spawn[spawnIndex].transform.position.y, spawn[spawnIndex].transform.position.z), Quaternion.identity, 0);
        }
        catch
        {
            SpawnPlayer(); 
        }
            //Network.Destroy(spawn);
    }
}

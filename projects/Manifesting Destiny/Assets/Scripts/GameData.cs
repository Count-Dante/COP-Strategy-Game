[System.Serializable]
public class GameData
{
    public string time;
    public string scene;

    public GameData(string timeS, string sceneS)
    {
        scene = sceneS;
        time = timeS;
    }
}
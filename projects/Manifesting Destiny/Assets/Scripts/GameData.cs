[System.Serializable]
public class GameData
{
    public float defensePoints;
    public float expansionPoints;
    public float remainingTime;
    public string time;

    public int wood;
    public int gold;
    public int food;

    public GameData(float remainingTimeF, float defensePointsF, float expansionPointsF, int woodI, int goldI, int foodI, string timeS)
    {

        remainingTime = remainingTimeF;
        defensePoints = defensePointsF;
        expansionPoints = expansionPointsF;

        wood = woodI;
        gold = goldI;
        food = foodI;
        time = timeS;

    }
}
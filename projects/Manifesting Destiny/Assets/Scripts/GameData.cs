[System.Serializable]
public class GameData
{
    public float defensePoints;
    public float expansionPoints;

    public int wood;
    public int gold;
    public int food;

    public GameData(float defensePointsF, float expansionPointsF, int woodI, int goldI, int foodI)
    {

        defensePoints = defensePointsF;
        expansionPoints = expansionPointsF;

        wood = woodI;
        gold = goldI;
        food = foodI;

    }
}
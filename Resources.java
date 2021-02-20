import ResourceManager.java;

// Harvest 1 Gold = 30% Chance
// Harvest 2 Gold = 30% Chance
// Harvest 3 Gold = 30% Chance
// Harvest 4 Gold = 10% Chance
public static void harvestGold()
{
      set delay

      int randomNumber = randomNumberGenerator();
      int goldAmount = getGold();

      if (randomNumber <= 30)
      {
            setGold(goldAmount + 1);
      }

      else if (randomNumber <= 60)
      {
            setGold(goldAmount + 2);
      }

      else if (randomNumber <= 90)
      {
            setGold(goldAmount + 3);
      }

      else
      {
            setGold(goldAmount + 4);
      }
}

// Harvest 1 Wood = 30% Chance
// Harvest 2 Wood = 30% Chance
// Harvest 3 Wood = 30% Chance
// Harvest 4 Wood = 10% Chance
public static void harvestWood()
{
      int randomNumber = randomNumberGenerator();

      if (randomNumber <= 30)
      {
            wood += 1;
      }

      else if (randomNumber <= 60)
      {
            wood += 2;
      }

      else if (randomNumber <= 90)
      {
            wood += 3;
      }

      else
      {
            wood += 4;
      }
}

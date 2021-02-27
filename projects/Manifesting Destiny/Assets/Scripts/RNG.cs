using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNG : MonoBehaviour
{
      // Get random number from 1 - 100 (inclusive).
      public static int randomNumberGenerator()
      {
            return UnityEngine.Random.Range(1,100);
      }
}

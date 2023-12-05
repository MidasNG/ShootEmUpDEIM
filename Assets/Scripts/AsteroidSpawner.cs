using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private string Side;
    [SerializeField] private AsteroidBehaviour Asteroid;
    [SerializeField] private sfxController sfxController;
    [SerializeField] private GameLogic gameLogic;
    private float timeSinceLastSpawn = 0;

    void Update()
    {
        timeSinceLastSpawn = Mathf.Clamp(timeSinceLastSpawn + Time.deltaTime, 0, 1.5f);
        if (Side == "T" && timeSinceLastSpawn == 1.5)
        {
            Instantiate(Asteroid, new Vector2(Random.Range(-7f, 7f), 5f), Quaternion.Euler(0, 0, Random.Range(-125f, -45f)), transform).SetSFXControllerAndGameLogic(sfxController, gameLogic);
        }

        if (Side == "B" && timeSinceLastSpawn == 1.5)
        {
            Instantiate(Asteroid, new Vector2(Random.Range(-7f, 7f), -5f), Quaternion.Euler(0, 0, Random.Range(125f, 45f)), transform).SetSFXControllerAndGameLogic(sfxController, gameLogic);
        }

        if (Side == "L" && timeSinceLastSpawn == 1.5)
        {
            Instantiate(Asteroid, new Vector2(-7f, Random.Range(-5f, 5f)), Quaternion.Euler(0, 0, Random.Range(-45f, 45f)), transform).SetSFXControllerAndGameLogic(sfxController, gameLogic);
        }

        if (Side == "R" && timeSinceLastSpawn == 1.5)
        {
            Instantiate(Asteroid, new Vector2(7f, Random.Range(-5f, 5f)), Quaternion.Euler(0, 0, Random.Range(-125f, -215f)), transform).SetSFXControllerAndGameLogic(sfxController, gameLogic);
        }

        if (timeSinceLastSpawn == 1.5) timeSinceLastSpawn = 0;
    }
}

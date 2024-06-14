using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image Health;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        Health.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

﻿using UnityEngine;
using System.Collections;
using TMPro;

public class SimulationStats : Singleton<SimulationStats>
{
    public TextMeshProUGUI numberOfCells;
    public TextMeshProUGUI nutrientLevelText;
    public TextMeshProUGUI antibioticText;

    private bool isAntibioticPresent;

    public float agarNutrientLevel;

    public UISriptable UISettings;

    public int cellCount;


    private void Awake()
    {
        agarNutrientLevel = UISettings.agarLevel;
        isAntibioticPresent = false;
        cellCount = UISettings.numberOfCells;
    }


    // Start is called before the first frame update
    void Start()
    {
        // TODO: Keep antibiotic message?
        numberOfCells.text = "Number of cells: " + cellCount;

        nutrientLevelText.text = "Agar level: " + agarNutrientLevel.ToString();

        antibioticText.text = "Is antibiotic present: " + isAntibioticPresent.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        changeUIWithAgarLevel();
        updateNumberOfCells();
    }


    private void changeUIWithAgarLevel()
    {
        nutrientLevelText.text = "Agar level: " + agarNutrientLevel.ToString();
    }

    private void updateNumberOfCells()
    {
        numberOfCells.text = "Number of cells: " + cellCount;
    }

}

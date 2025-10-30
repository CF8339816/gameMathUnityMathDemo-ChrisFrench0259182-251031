using System.Collections;
using System.Collections.Generic;

using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class mathDemo : MonoBehaviour
{
    [Header("Chest Type")]
    [SerializeField] int WoodChest = 0;
    [SerializeField] int BronzeChest = 0;
    [SerializeField] int SilverChest = 0;
    [SerializeField] int GoldChest = 0;
    [SerializeField] int PlatinumChest = 0;
    public TextMeshProUGUI ChestsCount;
    [SerializeField] int CommonLootCount = 0;
    [SerializeField] int UncommonLootCount = 0;
    [SerializeField] int RareLootCount = 0;
    [SerializeField] int EpicLootCount = 0;
    [SerializeField] int LegendaryLootCount = 0;

    [Header("Wooden Chest")]
    [SerializeField] int WoodChestCommon = 0;
    [SerializeField] int WoodChestUncommon = 0;
    [SerializeField] int WoodChestRare = 0;
    [SerializeField] int WoodChestEpic = 0;
    [SerializeField] int WoodChestLegendary = 0;
    public TextMeshProUGUI LootWood;
    [SerializeField] int WoodenChestCounts = 0;

    [Header("Bronze Chest")]
    [SerializeField] int BronzeChestCommon = 0;
    [SerializeField] int BronzeChestUncommon = 0;
    [SerializeField] int BronzeChestRare = 0;
    [SerializeField] int BronzeChestEpic = 0;
    [SerializeField] int BronzeChestLegendary = 0;
    public TextMeshProUGUI LootBronze;
    [SerializeField] int BronzeChestCounts = 0;


    [Header("Silver Chest")]
    [SerializeField] int SilverChestCommon = 0;
    [SerializeField] int SilverChestUncommon = 0;
    [SerializeField] int SilverChestRare = 0;
    [SerializeField] int SilverChestEpic = 0;
    [SerializeField] int SilverChestLegendary = 0;
    public TextMeshProUGUI LootSilver;
    [SerializeField] int SilverChestCounts = 0;



    [Header("Gold Chest")]
    [SerializeField] int GoldChestCommon = 0;
    [SerializeField] int GoldChestUncommon = 0;
    [SerializeField] int GoldChestRare = 0;
    [SerializeField] int GoldChestEpic = 0;
    [SerializeField] int GoldChestLegendary = 0;
    public TextMeshProUGUI LootGold;
    [SerializeField] int GoldChestCounts = 0;



    [Header("Platinum Chest")]
    [SerializeField] int PlatinumChestCommon = 0;
    [SerializeField] int PlatinumChestUncommon = 0;
    [SerializeField] int PlatinumChestRare = 0;
    [SerializeField] int PlatinumChestEpic = 0;
    [SerializeField] int PlatinumChestLegendary = 0;
    public TextMeshProUGUI LootPlatinum;
    [SerializeField] int PlatinumChestCounts = 0;



    //[SerializeField] int Platinum_Chest_Drops = Platinum.Count{0};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LootRoll();
        }

    }


    //m0
    void LootRoll()
    {
        int Max = WoodChest + BronzeChest + SilverChest + GoldChest + PlatinumChest;
        int whatChest = Random.Range(1, Max + 1);
        if (whatChest <= PlatinumChest)
        {
            PlatinumChestCounts++;
            PlatinumLoot();
        }
        if (whatChest <= GoldChest)
        {
            GoldChestCounts++;
            GoldLoot();
        }
        if (whatChest <= SilverChest)
        {
            SilverChestCounts++;
           SilverLoot();
        }
        if (whatChest <= BronzeChest)
        {
            BronzeChestCounts++;
            BronzeLoot();
        }
        if (whatChest <= WoodChest)
        {
            WoodenChestCounts++;
            WoodenLoot();
        }
        ChestsCount.text = "Wood Chest:" + WoodenChestCounts + "   Bronze Chest:" + BronzeChestCounts + "  Silver Chest:" + SilverChestCounts + "   Gold Chest:" + GoldChestCounts + "   Platinum Chest:" + PlatinumChestCounts +"\n"+
        "Common Loot:" + CommonLootCount + "   Uncommon Loot:" + UncommonLootCount + "   Rare Loot:" + RareLootCount + "   Epic Loot:" + EpicLootCount + "   Legendary Loot" + LegendaryLootCount;


    }


    //m1
    void WoodenLoot()
    {

        int Max = WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary;
        int woodLoot = Random.Range(1, Max + 1);
        if (woodLoot <= WoodChestLegendary)
        {
            LegendaryLootCount++;
            LootWood.text = "Wooden Chest, Legendary Loot";
        }
        if (woodLoot <= WoodChestEpic)
        {
            EpicLootCount++;
            LootWood.text = "Wooden Chest, Epic Loot";
        }
        if (woodLoot <= WoodChestRare)
        {
            RareLootCount++;
            LootWood.text = "Wooden Chest, Rare Loot";
        }
        if (woodLoot <= WoodChestUncommon)
        {
            UncommonLootCount++;
            LootWood.text = "Wooden Chest, Uncommon Loot";
        }
        if (woodLoot <= WoodChestCommon)
        {
            CommonLootCount++;
            LootWood.text = "Wooden Chest, Common Loot";
        }
        
    }


    //m2
    void BronzeLoot()
    {
        int Max = BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary;
        int bronzeLoot = Random.Range(1, Max +1);
        if (bronzeLoot <= BronzeChestLegendary)
        {
            LegendaryLootCount++;
            LootBronze.text = "Bronze Chest, Legendary Loot";
        }
        if (bronzeLoot <= BronzeChestEpic)
        {
            EpicLootCount++;
            LootBronze.text = "Bronze Chest, Epic Loot";
        }
        if (bronzeLoot <= BronzeChestRare)
        {
            RareLootCount++;
            LootBronze.text = "Bronze Chest, Rare Loot";
        }
        if (bronzeLoot <= BronzeChestUncommon)
        {
            UncommonLootCount++;
            LootBronze.text = "Bronze Chest, Uncommon Loot";
        }
        if (bronzeLoot <= BronzeChestCommon)
        {
            CommonLootCount++;
            LootBronze.text = "Bronze Chest, Common Loot";
        }

    }

    //m3
    void SilverLoot()
    {
        int Max = SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary;
        int silverLoot = Random.Range(1, Max + 1);
        if (silverLoot <= SilverChestLegendary)
        {
            LegendaryLootCount++;
            LootSilver.text = "Silver Chest, Legendary Loot";
        }
        if (silverLoot <= SilverChestEpic)
        {
            EpicLootCount++;
            LootSilver.text = "Silver Chest, Epic Loot";
        }
        if (silverLoot <= SilverChestRare)
        {
            RareLootCount++;
            LootSilver.text = "Silver Chest, Rare Loot";
        }
        if (silverLoot <= SilverChestUncommon)
        {
            UncommonLootCount++;
            LootSilver.text = "Silver Chest, Uncommon Loot";
        }
        if (silverLoot <= SilverChestCommon)
        {
            CommonLootCount++;
            LootSilver.text = "Silver Chest, Common Loot";
        }

    }

    //m4
    void GoldLoot()
    {
        int Max = GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic + GoldChestLegendary;
        int goldLoot = Random.Range(1, Max + 1);
        if (goldLoot <= GoldChestLegendary)
        {
            LegendaryLootCount++;
            LootGold.text = "Gold Chest, Legendary Loot";
        }
        if (goldLoot <= GoldChestEpic)
        {
            EpicLootCount++;
            LootGold.text = "Gold Chest, Epic Loot";
        }
        if (goldLoot <= GoldChestRare)
        {
            RareLootCount++;
            LootGold.text = "Gold Chest, Rare Loot";
        }
        if (goldLoot <= GoldChestUncommon)
        {
            UncommonLootCount++;
            LootGold.text = "Gold Chest, Uncommon Loot";
        }
        if (goldLoot <= GoldChestCommon)
        {
            CommonLootCount++;
            LootGold.text = "Gold Chest, Common Loot";
        }

    }

    //m5 
    void PlatinumLoot()
    {
        int Max = PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare + PlatinumChestEpic + PlatinumChestLegendary;
        int platinumLoot = Random.Range(1, Max + 1);
        if (platinumLoot <= PlatinumChestLegendary)
        {
            LegendaryLootCount++;
            LootPlatinum.text = "Platinum Chest, Legendary Loot";
        }
        if (platinumLoot <= PlatinumChestEpic)
        {
            EpicLootCount++;
            LootPlatinum.text = "Platinum Chest, Epic Loot";
        }
        if (platinumLoot <= PlatinumChestRare)
        {
            RareLootCount++;
            LootPlatinum.text = "Platinum Chest, Rare Loot";
        }
        if (platinumLoot <= PlatinumChestUncommon)
        {
            UncommonLootCount++;
            LootPlatinum.text = "Platinum Chest, Uncommon Loot";
        }
        if (platinumLoot <= PlatinumChestCommon)
        {
            CommonLootCount++;
            LootPlatinum.text = "Platinum Chest, Common Loot";
        }

    }

}

# My_RPG_Game
My first c# RPG console application.
There are some missing parts I was not able to integrate like final attributes calculation of equiped items & weapons.
Unfortunately XUnit testing did not made it into this release due to time constrains.

## Getting Started

Clone to a local directory.
Open solution in Visual Studio

Run

### Prerequisites

.NET Framework

Visual Studio 2017/19 OR Visual Studio Code

### Usage of methods
Below you will find a few example how to use the provided classes and methods:

- Example to instantiate a warrier character:

```
    CharacterManager.Charactertypes.Warrior MyWarrior = new CharacterManager.Charactertypes.Warrior()
    {
        Name = "MyWarrior",
    };
```


- Example to show base stats:

```
    MyWarrior.BaseStats();
```


- Example to level up:

```
    MyWarrior.LevelUp();
```


- Example to instantiate a weapon

```
    WeaponManager.WeaponTypes MyWeapon = new WeaponManager.WeaponTypes()
    {
        Name = "Sword",
        RequiredLvl = 1,
        Slot = WeaponManager.AllowedWeaponsSlots.Weapon,
        BaseDamage = 1,
        AttacksPerSecond = 1,
        MyWeapons = CharacterManager.Charactertypes.AllowedWeapons.Swords,
    };

    MyWarrior.EquipMyWeapon(MyWeapon);
```


- Esample to instantiate an armor

```
    ArmorManager.ArmorTypes MyClothArmor = new ArmorManager.ArmorTypes()
        {
            Name = "Mail",
            RequiredLvl = 1,
            Slot = ArmorManager.AllowedArmorSlots.Head,  
            MyArmor = CharacterManager.Charactertypes.AllowedArmor.Mail,
        };

        MyWarrior.EquipMyArmor(MyClothArmor);
```


## Authors

***Thomas Bauer** [ThomasBdev675](https://github.com/ThomasBdev675)
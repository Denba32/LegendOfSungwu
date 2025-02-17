
using System;

public interface IDamagable
{
    void Damage(float damage);
}
public class Define
{
    public enum SceneType
    {
        None,
        StartScene,
        StoryScene,
        MainScene,
        CaveScene,
        BossStage
    }
    public enum EquipmentType
    {
        PrimaryWeapon,
        SecondaryWeapon,
        Armor,
        ResourceTool
    }

    [Flags]
    public enum EquipStatus
    {
        Nothing = 0,
        LeftHand = 1 << 0,
        RightHand = 1 << 1,
        Both = LeftHand | RightHand
    }

    public enum ItemType
    {
        None,
        Consumable,
        Weapon,
        Armor,
        Resource
    }

    public enum ConsumableItemType
    {
        Portion,
    }

    public enum ConsumableValueType
    {
        Health,
        Stamina,
        Hunger,
    }

    public enum ResourceType
    {
        None,
        Wood,
        Rock,
    }

    public enum RewardType
    {
        None,
        Gold,
        Weapon,
        Armor,
        Consumable,
        Resource
    }

    public enum SoundType
    {
        Bgm,
        Effect,
        Voice,
        Hit,
        Max
    }

    public enum EnemyType
    {
        Stump,
        Mushroom,
        Boss
    }

    public enum LeverType
    {
        Normal,
        Special

    }
}
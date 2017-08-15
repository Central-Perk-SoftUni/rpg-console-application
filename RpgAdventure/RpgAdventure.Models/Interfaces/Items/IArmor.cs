using RpgAdventure.Models.Enums;

namespace RpgAdventure.Models.Interfaces.Items
{
    public interface IArmor : IItem
    {
        ArmorMaterial Material { get; set; }
        ArmorType Type { get; set; }
    }
}
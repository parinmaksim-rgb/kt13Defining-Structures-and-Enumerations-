namespace KT13_Задание_на_структуры_и_перечисления
{
    public struct Item
    {
        public string Name;
        public ItemRarity Rarity;
        public ItemSlot Slot;

        public override string ToString()
        {
            return $"{Name} ({Rarity}, {Slot})";
        }
    }
}
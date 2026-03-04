using System;
using System.Xml.Linq;
Console.WriteLine("=== 인벤토리 시스템 테스트 ===");
Console.WriteLine();
Inventory inven = new Inventory();
Weapon Sword = new Weapon("불꽃 검",25,500);
inven.AddItem(Sword);
inven.AddItem(new Weapon("얼음 활", 20, 450));
inven.AddItem(new Potion("체력 물약", 100, 50));
inven.AddItem(new Potion("마나 물약", 50, 80));
inven.ShowInfo();
Console.WriteLine();
Console.WriteLine("=== 타입 확인 테스트 ===");
Console.WriteLine($"sword의 타입: {Sword.GetType().Name}");
Console.WriteLine($"sword.GetType() == typeof(weapon): {Sword.GetType()==typeof(Weapon)}");
Console.WriteLine($"sword.GetType() == typeof(item): {Sword.GetType()==typeof(Item)}");
Console.WriteLine($"sword is Item: {Sword is Item}");
class Item
{
    public string Name;
    public int Price;
    public override string ToString()
    {
        return $"Name = {Name}, Price = {Price}";
    }
}

class Weapon : Item
{
    private int _Damage;
    public Weapon(string name,int damage,int price)
    {
        _Damage = damage;
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"Weapon {{ Name = {Name}, Price = {Price}, Damage = {_Damage} }}";
    }
}
class Potion : Item
{
    private int _Health;
    public Potion(string name, int Health, int price)
    {
        _Health = Health;
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"Potion {{ Name = {Name}, Price = {Price}, HealAmount = {_Health} }}";
    }
}
class Inventory
{
    private object[] Itemslot = new object[10];
    private int SlotCount;

    public void AddItem(object item)
    {
        if (Itemslot.Length > SlotCount)
        {
            Itemslot[SlotCount++] = item;
        }
        else
        {
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine("[인벤토리 내용]");
        for (int i = 0; i < SlotCount; i++)
        {
            Console.WriteLine($"슬롯 {i+1}: {Itemslot[i]} [{Itemslot[i].GetType().Name}]");
        }

    }
}
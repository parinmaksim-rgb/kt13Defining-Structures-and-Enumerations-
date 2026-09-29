Вариант 2. RPG-предмет
1 enum ItemRarity { Common, Rare, Epic, Legendary } и enum ItemSlot { Weapon, Armor, Accessory }.
2 struct Item { string Name; ItemRarity Rarity; ItemSlot Slot; } с переопределённым ToString(), например "Меч Дракона (Legendary, Weapon)".
3 Создайте массив или список из 5 предметов (вручную).
4 Прочитайте один предмет из коллекции в локальную переменную, измените у копии Rarity, и выведите оба значения, доказав, что коллекция не изменилась.
5 Реализуйте разбор строки в ItemRarity через Enum.TryParse — продемонстрируйте на корректном ("Epic") и некорректном ("Mythic") значении.

Ограничения
Доказательство независимости копии обязательно должно идти через чтение элемента коллекции (массива или списка) в отдельную переменную — а не через копирование двух независимо созданных локальных переменных, как на прошлом занятии. Именно поведение при чтении из коллекции — предмет проверки в этом задании.

Результаты и проверочные ключи
<img width="1540" height="292" alt="image" src="https://github.com/user-attachments/assets/f12336e3-71dc-4a51-81a1-80e84b1bc2cb" />

<img width="694" height="1275" alt="image" src="https://github.com/user-attachments/assets/a13767e2-df8f-47bd-bbcc-88196d30bcde" />

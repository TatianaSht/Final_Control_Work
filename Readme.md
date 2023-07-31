# Итоговая контрольная работа по основному блоку

## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*\
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]\
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]\
[“Russia”, “Denmark”, “Kazan”] → []



# Текстовое описание решения
## При решении задачи были использованы функции:
- ***FillAray*** - заполнение массива данными, введенными пользователем
- ***ArrayOfLengthNumber***
    -  подсчет количества строк массива, размер которых меньше либо равен 3
    - создание нового массива из количества строк массива, размер которых меньше либо равен 3
- ***PrintArray*** - вывод массива в консоль

## Алгоритм решения:
- Ввод пользователем количества элементов массива
- Создание массива строк, введенных пользователем в указанном им количестве
- Создание нового массива из строк, длина которых меньше либо равна 3
- Вывод в консоль массива строк, введенных пользователем
- Вывод в консоль нового массива строк, длина которых меньше либо равна 3
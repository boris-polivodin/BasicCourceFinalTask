# GeekBrains. Итоговое задание по основному блоку.
## Содержание задания

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)

4. Написать программу, решающую поставленную задачу:

* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк
, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    * Примеры:

    * [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

    * [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

    * [“Russia”, “Denmark”, “Kazan”] → []

5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
## Описание решения
>При решении задачи наибольшей сложностью оказался выбор варианта получения начального массива.

>Автозаполнение массива предполагало случайный выбор длины массива, случайный выбор длины элементов массива и, самое неприятное, заполнение элементов случайными символами - в общем, пришлось отказаться.

>Далее рассматривался наиболее удобный для пользователя вариант ввода элементов строкой, разделяя их пробелами. Но тогда строки с пробелами, наподобие “computer science”, рассматривались бы как два разных элемента массива. То же самое и с другими разделителями. Заключение же элементов в кавычки сводило в ноль все удобства ввода данных строкой. И кстати, кавычки вокруг элементов при выводе массивов ведь не принципиальны? 

>Вот и остался лишь вариант с заданием размера массива и построчнымм вводом элементов в цикле. В этом же цикле можно было сразу же считать количество строк с длиной не более 3, затем создавать результирующий массив соответствующей длины и заполнять его повторно обходя начальный массив. Но все упростил метод FindAll в классе Array.
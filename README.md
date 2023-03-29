# FinalWork
## Задача : 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
# Представлено 2 алгоритма решения: 
## Метод **MakeFilteredArrPoorMemoryUsage** 
## и метод **MakeFilteredArr**.
## Описание алгоритмов решения:
## Для работы порграммы объявляется массив строк, подлежащий фильтрации.
### *1-й Алгоритм реализован в методе MakeFilteredArrPoorMemoryUsage. В методе объявляется второй массив такой же длины, как и массив, подлежащий фильтрации. Объявляется переменная doubleI, которая будет счётчиком заполненных элементов второго массива. В цикле проверяется длина каждой строки, входящей в массив, и при соотвитствии условию задачи(длина строки меньше либо равна 3 символа), значение такой строки присваивается очередному элементу второго массива и увеличивается на 1 значение переменной doubleI. Таким образом, при не выполнении условия, пустые элементы расположатся не в середине массива, а в конце, после "заполненных". Метод возвращает отфильтрованный массив. Недостаток метода - двойной расход памяти вне зависимости от наличия/отсутствия подходящих элементов, пустые элементы в массиве.*
###
### __*2-й Алгоритм реализован в методе MakeFilteredArr. В методе объявляется второй массив с нулевой длиной. При переборе циклом исходного массива, при нахождении элемента, соответствующего условию задачи, длина второго массива увеличивается на 1 и последней ячейке второго массива присваивается значение найденного элемента. Метод возвращает отфильтрованный массив реальной длины, без пустых ячеек.*__

 + Для работы программы реализован метод по изготовлению строки для печати массива MakeStringToPrintArray. В цикле, перебором элементов массива, с помощью конкатенации собирается строка, удобная для печати, причём последний элемент добавляестя в строку отдельно для того, чтобы после него не печатался разделитель.
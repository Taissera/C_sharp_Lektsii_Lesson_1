﻿/* Код для программы сложения двух чисел
* Определяем и уточняем условия: 
1. на каком языке программирования нужно написать приложение?
После уточнения языка программа, техническое задание или функциональные требования, предъявляемые к этому приложению, звучат, как «написать программу на языке С#, 
которая складывает два числа»
2. на какой платформе должна быть написана программа?
заказчик сказал, что это приложение должно работать на компьютерах под управлением Windows и Mac OS. Соответственно, наши функциональные требования звучат, 
как «написать программу на языке С# работающую на Windows и на Mac OS, которая складывает два числа
3. мы должны чётко представлять, откуда у нас берутся данные
Производим уточнения, и оно звучит, как «написать программу на языке С# для Windows и Mac OS, в которой пользователь вводит два числа, или числа генерируются 
автоматически, или считываются из файла. Дальше получаем их сумму»
4. Что значит «получаем сумму»? После того как складываем числа, мы должны показать их сразу в терминал или, быть может, нужно сохранить куда-то в базу данных 
или отправить какому-то телеграмм бот или ещё куда-то? Нужно понимать, что с этой суммой дальше делать. Соответственно, снова производим уточнение, добавляем 
что-то и после этого можем приниматься к написанию программы.
5. Но и это не всё. Проблема в том, что, с какими числами мы работаем? Из курса математики вы помните, что есть натуральные, вещественные или рациональные числа и т. д. 
Так с какими именно числами наше приложение должно работать. Ограничимся уточнением целых чисел. Следующим этапом по аналогии с предыдущими проектами мы с вами 
должны будем описать алгоритм, последовательность действий или блок-схему.*/

/*int numberA = 3;
int numberВ = 5;
Console.WriteLine(numberA + numberВ );

/* Итак, начнём с определения переменной. Пусть первая переменная называется numberA в неё положим конкретное значение, допустим, 3. 
На следующем этапе необходимо сказать компьютеру, сколько памяти нужно выделить и определить, каким это число является. 
По аналогии с математикой, если это целое число, значит, множество Z, а если вещественное число, то множество R и т. д. 
Для компьютерных программ примерно то же самое. При хранении различных чисел используются разные типы данных.
Тип данных для целых чисел называется int (целое число). Мы ввели первое число. Дальше сделаем numberВ. Отмечу, что в наименование 
переменных допускается использование больших и маленьких латинских букв. Использовать можно и цифры, но они не должны стоять на первом месте, например,
можно указать number2. Но 2number мы точно делать не можем, поэтому тоже будьте внимательнее.
Помимо этого, можно использовать символы подчёркивания « _ », но в языке С# для именования переменных это не принято. Дальше возьмём конкретное число 5 
и покажем на экране Console.WriteLine. Чтобы таким образом вывести сумму. Запустим и посмотрим, что будет действительно сумма. Видим 8. */

/*int numberC = 31;
int numberD = 5;
int result = numberC + numberD;
Console.WriteLine(result);

/* Можно было использовать промежуточную переменную. Создать некоторую дополнительную переменную (контейнер) result и положить в неё сумму. 
А потом показывать её в консоле. 
Перезапустим. Опять же изменим значение. Например, 31 здесь поставим. И спустя какое-то время мы с вами наблюдаем сумму чисел. 
Вроде бы всё. Сравним с нашей блок схемой. Убедимся, что определили numberА и numberВ , показали сумму. 
Также мы добавили дополнительный шаг — сохранение результатов в промежуточную переменную. Можно было этого и не делать. */

/* Генератор псевдослучайных чисел
Random().Next()
Random().Next(min,max) = диапазон от min до max-1 */

/*int numberE = new Random().Next(1,10);
int numberF = new Random().Next(1,10);
int result = numberE + numberF;
Console.WriteLine(result);
*/

//Выведем построчно

int numberE = new Random().Next(1,10);
Console.WriteLine(numberE);
int numberF = new Random().Next(1,10);
Console.WriteLine(numberF);
int result = numberE + numberF;
Console.WriteLine(result);


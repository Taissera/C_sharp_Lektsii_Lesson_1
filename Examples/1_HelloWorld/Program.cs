﻿Console.WriteLine("Hello, World!"); 
/*Console - это команда, позволяющая работать с основным окном терминала
Writeline - необх. для непосредственного вывода "чего-то" в окно терминала, например текст в круглых скобках)
чтобы запустить и проверить работоспособность приложения, необходимо ввести команду "dotnet run"

нужно убедиться, что работает именно текущий проект  и внести изменения
изменим фразу на "2 Hello, world" */

Console.WriteLine("2 Hello, World!"); 

/* Рекомендации по VSC:
1. Автосохранение (но могут быть зависания)
2. Шрифты (terminal font)

Итого, новые команды:
* Dotnet new console — эта команда нужна, чтобы создать новый проект
* Dotnet run — эта команда нужна, чтобы запустить проект. Позднее я покажу, что будет, если у вас возникают какие-то ошибки, как нужно будет действовать и каким образом их чинить.
* Через Console мы обращаемся к окну терминала
* С помощью «WriteLine» можем в консоли данные выводить

## Приветствие пользователя
Помним, что в первую очередь мы рисуем алгоритм, а затем пишем по нему код 
Начало --> Ввод usernam --> вывод "Привет, " --> Вывод username --> Конец

запушим наши измения в репозиторий */
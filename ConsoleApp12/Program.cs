//Решить задачи на С# и выгрузить проект в удаленный репозиторий с помощью Git Bush.
//Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
//На вход будет подаваться число (сумма вклада). 
//При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
//Отработав, программа должна вывести общую сумму с начисленными процентами. 
//Для решения этой задачи воспользуемся выражением Convert.ToDouble(Console.ReadLine()), 
//которое нам пригодится для получения вводимого с клавиатуры числа.

Console.WriteLine("Введите сумму вклада: ");
int summa = int.Parse(Console.ReadLine());
double d, all = 0;
if(summa < 100)
{
    d = (Convert.ToDouble(summa) * 0.05) / 100;
    all = summa + d;
    Console.WriteLine(all);
}
else if(summa > 100 & summa < 200)
{
    d = (Convert.ToDouble(summa) * 0.07) / 100;
    all = summa + d;
    Console.WriteLine(all);
}
else if(summa > 200)
{
    d = (Convert.ToDouble(summa) * 0.1) / 100;
    all = summa + d;
    Console.WriteLine(all);
}
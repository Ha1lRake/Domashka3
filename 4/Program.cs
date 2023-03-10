﻿// // Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. На вход будет подаваться число (сумма вклада).
//  При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
//  Отработав, программа должна вывести общую сумму с начисленными процентами.


Console.WriteLine("Введите сумму вклада");

double deposit =Convert.ToInt32(Console.ReadLine());

if(deposit < 100001)
{
    deposit = (deposit * 1.05);
}
else if ((deposit > 99999) && (deposit < 200001))
{
    deposit = (deposit * 1.07);
}
else if (deposit > 299999)
{
    deposit = (deposit * 1.1);
}

Console.WriteLine(deposit);
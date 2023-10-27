
#region task1
// 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir
Console.WriteLine("Eded daxil edin:");
int num = int.Parse(Console.ReadLine());
string result = $"7{num}8";
int count = 0;
while (num > 0)
{
    num /= 10;
    count++;
    
}
if (count == 4)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("seçdiyiniz eded şertleri ödemir");
}

#endregion

#region task2
//3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. 
Console.WriteLine("ededi daxil ediin:");
int num2 = int.Parse(Console.ReadLine());
string result2 = $"{num}{num}";
int count2= 0;
while (num2> 0)
{
    num2 /= 10;
    count2++;
}
if (count2== 3)
{
    Console.WriteLine(result2);
}
else
{
    Console.WriteLine("Secdiyiniz eded sertleri odemir");
}

#endregion

#region task3
//5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
Console.WriteLine("ededi daxil edin:");
int num3 = int.Parse(Console.ReadLine());
int count3 = 0;
double result3 = num3 * 18 / 100 * 3 / 100;
while (num3 > 0)
{
    num3 /= 10;
    count3++;

}
if (count3 == 5)
{
    Console.WriteLine(result3);
}
else
{
    Console.WriteLine("eded sertleri odemir");
}


#endregion


#region task 4
//3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
int num4 = int.Parse(Console.ReadLine());
string result4 = $"{num4}7";
int resultT = Convert.ToInt32(result4);
int count4 = 0;
int calculate = 0;
while (num4 > 0)
{
    num4 /= 10;
    count4++;
}
if (count4 == 3)
{
    calculate = (resultT * 7) / 100;
    Console.WriteLine(calculate);
}
else
{
    Console.WriteLine("daxil edilen eded şertleri ödemir");
}
#endregion

#region task5
//4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir.
//Alinan cavabin 44 % tap.
Console.WriteLine("ededi daxil edin:");
int num5 = int.Parse(Console.ReadLine());
int count5 = 0;
string result5 = $"4{num5}44";
int resulT5 = Convert.ToInt32(result5);
int end = resulT5 * 44 / 100;
while (num5 > 0)
{
    num5 /= 10;
    count5++;
}
if (num5 == 4)
{
    Console.WriteLine(end);
}
#endregion

#region task6
//4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap.
//Alinan cavabin kvadratini tap.
Console.WriteLine("ededi daxil edin:");
int num6 = int.Parse(Console.ReadLine());
int count6 = 0;
int result6 = num6 * 20 / 100 * 10 / 100;
while (num6 > 0)
{
    num6 /= 10;
    count6++;
}
if (count6 == 4)
{
    Console.WriteLine(result6);
}
else
{
    Console.WriteLine("sertleri odemir");
}
#endregion

#region task7
//2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir.
//Neticenin 5 % tap
Console.WriteLine("ededleridaxil edin:");
int num7 = int.Parse(Console.ReadLine());
int nuM7 = int.Parse(Console.ReadLine());
int count7 = 0;
int counT7 = 0;
int result7 = num7 + nuM7;
string add = $"5{result7}5";
int Add = Convert.ToInt32(add);
int end2 = 0;
while (num7 > 0 && nuM7 > 0)
{
    num7 /= 10;
    count7++;
    nuM7 /= 10;
    counT7++;
}
if (count7 == 5 && counT7 == 5)
{
    end2 = Add * 5 / 100;
    Console.WriteLine(end2);
}
else
{
    Console.WriteLine("sertleri odemir");
}
#endregion




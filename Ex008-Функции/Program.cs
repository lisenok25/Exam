﻿//нахождение мах из 9 чисел

//функция
int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}

//ввод данных

int a1=15;
int b1=55;
int c1=16;
int a2=125;
int b2=1225;
int c2=145;
int a3=135;
int b3=14;
int c3=19;

//вычисления

//int max1 = Max(a1, b1, c1);
//int max1 = Max(a2, b2, c2);
//int max1 = Max(a3, b3, c3);
//int max1 = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
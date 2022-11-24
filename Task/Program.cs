﻿/*Написать программу, которая из имеющегося массива строк формируют массив из строк, 
длина которых мееньше либо ровна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] array1 = new string[5] {"Hello", "2", "world", "1234", "^,^"};
string[] array2 = new string[array1.Length];

void DoArrayFromArray (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
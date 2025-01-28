// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int arrayLength = 5;
string[] studentList = new string[arrayLength];

studentList[0] = "Aung AUng";
studentList[1] = "Kaung";

//for(int i = 0; i < studentList.Length; i++ )
//{
//    Console.WriteLine("Room Number:" + i);
//    Console.WriteLine(studentList[i]);
//}
int i = 0;
while (i < studentList.Length)
{
    Console.WriteLine("Room Number:" + i);
    Console.WriteLine(studentList[i]);
    i++;
}

int j = 0;
do
{
    Console.WriteLine("Room Number:" + j);
    Console.WriteLine(studentList[j]);
    j++;
}
while (j < studentList.Length);


int k = 4;

do
{
    Console.WriteLine("Room Number:" + k);
    Console.WriteLine(studentList[k]);
    k--;
}
while (k >= 0);

foreach (string student in studentList)
{
    Console.WriteLine(student);
}
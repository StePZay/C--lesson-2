Console.WriteLine("Введите число от 1 до 7, где 1 - это понедельник, 2 - вторник ... 7 - воскресенье: ");
int input = Convert.ToInt32(Console.ReadLine());
if (input > 5){
    Console.WriteLine("Это выходной день");
}
else {
    Console.WriteLine("Это будний день");
}
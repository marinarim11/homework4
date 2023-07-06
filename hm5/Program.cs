int a = Int32.Parse(Console.ReadLine());
int s = 0;
while (a > 0) {
    s += a % 10;
    a /= 10;
}
Console.WriteLine(s);

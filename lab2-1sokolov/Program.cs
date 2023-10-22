int x = 237;

int x1 = x% 10;
int x2 = (x - x1) / 10;
int x3 = (x2- (x2%10))/10;


int y = x - x3 * 100;
int q = y * 10 + x3;

Console.WriteLine($"x = {q}");
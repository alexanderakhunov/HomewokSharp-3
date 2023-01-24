double[] coordX = new double[2];
double[] coordY = new double[2];
double[] coordZ = new double[2];

System.Console.WriteLine("Введите координаты х: ");
coordX[0] = Convert.ToInt32(Console.ReadLine());
coordX[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y: ");
coordY[0] = Convert.ToInt32(Console.ReadLine());
coordY[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты z: ");
coordZ[0] = Convert.ToInt32(Console.ReadLine());
coordZ[1] = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(coordZ[0]-coordY[0]-coordX[0],2) + Math.Pow(coordZ[1]-coordY[1]-coordX[1],2));
System.Console.WriteLine(S);
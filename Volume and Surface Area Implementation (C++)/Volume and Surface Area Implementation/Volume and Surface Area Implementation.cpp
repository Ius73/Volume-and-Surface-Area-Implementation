#include <iostream>
#include <cmath>
using namespace std;
void cube_volume_area(double x, double y, double z)
{
	double result;
	result = x * y * z;
	cout << "the volume of the cube is " << result << "m\n";
	result = ((x * y) * 2) + ((x * z) * 2) + ((z * y) * 2);
	cout << "the surface area of the cube is " << result << "m\n";
}
void sphere_volume_area(double r)
{
	double result;
	const double pi = 3.14159265359;
	result = (4 / 3) * pi * (pow(r, 3));
	cout << "the volume of the sphere is " << result << "m\n";
	result = 4 * pi * (pow(r, 2));
	cout << "the surface area of the sphere is " << result << "m\n";
}
char check_continue()
{
	char con;
	cout << "do you want to continue? Y/N: "; cin >> con;
	return con;
}
void main()
{
	char user_shape;
	double x;
	double y;
	double z;
	double r;
	int counter = 0;
	while (true)
	{
		cout << "insert:\n";
		cout << "C for Cube\n";
		cout << "S for Sphere\n";
		cout << "E for Exit\n";
		cin >> user_shape;
		if (user_shape == 'C' || user_shape == 'c')
		{
			cout << "insert the length of x: "; cin >> x;
			cout << "insert the length of y: "; cin >> y;
			cout << "insert the length of z: "; cin >> z;
			cube_volume_area(x, y, z);
			counter++;
		}
		else if (user_shape == 'S' || user_shape == 's')
		{
			cout << "insert the radius: "; cin >> r;
			sphere_volume_area(r);
			counter++;
		}
		else if (user_shape == 'E' || user_shape == 'e')
		{
			break;
		}
		else
		{
			cout << "error,";
			continue;
		}
		if (counter == 3)
		{
			char c = check_continue();
			if (c == 'Y' || c == 'y')
			{
				counter = 0;
			}
			else if (c == 'N' || c == 'n')
			{
				break;
			}
			else
			{
				check_continue();
			}
		}
	}
}
#include <iostream>
#include <math.h>
using namespace std;

extern "C"
__declspec(dllexport)
double
__cdecl
CalculateCircleLength(double Radius)
{
	return (2 * 3.14 * Radius);
}
extern "C"
__declspec(dllexport)
double
__cdecl
CalculateCircleArea(double Radius)
{
	return 3.14 * pow(Radius, 2);
}

extern "C"
__declspec(dllexport)
double
__cdecl
CalculateRectangleLength(double P1X, double P1Y, double P2X, double P2Y)
{
	return ((abs(P1X - P2X) + abs(P1Y - P2Y)) * 2);
}

extern "C"
__declspec(dllexport)
double
__cdecl
CalculateRectangleArea(double P1X, double P1Y, double P2X, double P2Y)
{
	return (abs(P1X - P2X) * abs(P1Y - P2Y));
}

extern "C"
__declspec(dllexport)
double
__cdecl
CalculateLineLength(double P1X, double P1Y, double P2X, double P2Y)
{
	return sqrt(pow((P1X - P2X), 2) + pow((P1Y - P2Y), 2));
}

int main()
{
	return 0;
}
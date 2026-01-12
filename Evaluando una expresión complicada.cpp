#include <bits/stdc++.h>
#include <iostream>
#include <cmath>
using namespace std;

int main() {
    double x, y, z;
    cin >> x >> y >> z;

    double numerador = pow((2 * y + z), 2.8) - z;
    double denominador = x + y - (x / z);
    double resultado = numerador / denominador;

    cout << resultado << endl;

    return 0;
}
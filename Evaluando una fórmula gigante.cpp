#include <bits/stdc++.h>
#include <iostream>
using namespace std;


int main() {
    double x, y, z;
    cin >> x >> y >> z;

    double numerador = ((2 * x + y) / z) * (pow(y, 3) - z);
    double denominador = ((x + 2 * y + 3 * z) / (z - 2 * y - 3 * x)) 
                          + pow(x, 2) + pow(z, 2);

    double resultado = numerador / denominador;

    cout << resultado << endl;

    return 0;
}

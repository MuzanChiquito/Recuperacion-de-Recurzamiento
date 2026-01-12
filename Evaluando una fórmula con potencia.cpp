#include <bits/stdc++.h>
#include <iostream>
#include <cmath>
using namespace std;

int main() {
    double x, y, z;
    cin >> x >> y >> z;

    double a = 2 * x + y - z;
    double resultado = (7 + pow(a, a)) / a;

    cout << resultado << endl;

    return 0;
}


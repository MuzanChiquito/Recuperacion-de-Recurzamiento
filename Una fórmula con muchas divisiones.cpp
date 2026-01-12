#include <bits/stdc++.h>
#include <iostream>
#include <cmath>
using namespace std;

int main() {
    double x, y;
    cin >> x >> y;

    double parteA = (pow(x, 3) + pow(x, 2)) / (pow(y, 2) - y);
    double parteB = (x / y) + 5;
    double z = (parteA - parteB) / (2 * x);

    cout << z << endl;

    return 0;
}

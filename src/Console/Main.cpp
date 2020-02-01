#include <iostream>
#include "NativeLib.h"
using namespace std;

int main()
{
    int result = add(1, 2);
    cout << result << endl;
    write_line("Hello World!");

    return 0;
}
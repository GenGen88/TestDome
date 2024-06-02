#include <vector>
#include <iostream>

class GamePlatform
{
public:
    static double calculateFinalSpeed(double initialSpeed, const std::vector<int>& inclinations)
    {
        double output = initialSpeed;
        for(int incline : inclinations)
        {
            output -= incline;
            if (output <= 0) {
                return 0;
            }
        }
        return output;
    }
};
#ifndef RunTests
int main()
{
    std::cout << GamePlatform::calculateFinalSpeed(60.0, { 0, 30, 0, -45, 0 });
    return 0;
}
#endif
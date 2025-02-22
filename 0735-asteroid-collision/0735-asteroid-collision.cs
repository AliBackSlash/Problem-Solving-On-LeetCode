public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
      Stack<int> stack = new Stack<int>();

foreach (int asteroid in asteroids)
{
    bool destroyed = false;

    while (stack.Count > 0 && asteroid < 0 && stack.Peek() > 0)
    {
        if (stack.Peek() < -asteroid)
        {
            stack.Pop();
            continue;
        }
        else if (stack.Peek() == -asteroid)
        {
            stack.Pop();
        }
        destroyed = true;
        break;
    }

    if (!destroyed)
    {
        stack.Push(asteroid);
    }
}

return stack.Reverse().ToArray();
    }
}
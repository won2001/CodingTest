namespace CodingTest1
{
    public class Solution32
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            return num1 == num2 ? 1 : -1;
            return answer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }

        
    }
}
//두 수의 차이를 구하라

//두 수의 곱을 구하라
public class Solution
{
    public int solution(int num1 = 2, int num2 = 4)
    {
        int answer = num1 * num2;
        return answer;
    }
}
//두 수의 몫 구하기
public class Solution2
{
    public int solution(int num1 = 10, int num2 = 5)
    {
        int answer;
        return answer = num1 / num2;
    }
}
//두 수의 나머지 구하기
public class Solution3
{
    public int solution(int num1, int num2)
    {
        return num1 % num2;
    }
}
//나이 구하기
//머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다.
//2022년 기준 선생님의 나이 age가 주어질 때,
//선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요
public class Solution4
{
    public int solution(int age)
    {
        //int answer = 2023 - age;
        var answer = 2023 - age;
        //var 사용법 var키워드를 사용하면 var키워드 뒤에 문자열이든 정수든 실수든
        //무엇을 넣던 간에 상관이없음 즉 var의 기능은 변수의 자료형을 자동으로 저장하는 것
        //주의사항 선언과 동시에 초기화작업이 필요하고 지역 변수로 선언해야함

        return answer;
    }
}
//숫자 비교하기
//정수 num1과 num2가 매개변수로 주어집니다.
//두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
public class Solution5
{
    public int solution(int num1, int num2)
    {
        //? 연산자 굳이 if/ else 코드를 넣지않고 변수에 바로 조건을 넣어 값을 할당할수 있다.
        //주의사항 모아니면 도 식의 처리에만 가급적 물음표 연산자를 이용하는 것이 바람직하다.
        return num1 == num2 ? 1 : -1;
    }
    //if를 사용했을때
    /* public int solution(int num1, int num2) 
    {
         int answer = 0;
        if(num1 == num2)
        {
            answer = 1;
        }
        else if (num1 != num2)
        {
            answer = -1;
        }
        return answer;
    }*/
}
//두 수의 나눗셈 구하기
public class Solution6
{
    public int solution(int num1, int num2)
    {
        int answer = 0;

        answer = num1 * 1000 / num2;

        return answer;
    }
    //다른사람 풀이
    /*public class Solution
    {
        public int solution(int num1, int num2)
        {
            return (int)((float)num1 / num2 * 1000);

        }
    }*/
}
//배열의 평균값
//정수 배열 numbers가 매개변수로 주어집니다.
//numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
public class Solution7
{
    public double solution(int[] numbers)
    {
        double answer = 0;
        int num = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            num += numbers[i];
        }

        answer = (double)num / (double)numbers.Length;
        return answer;
    }
    //다른사람 풀이
    /*public class Solution
    {
        public double solution(int[] numbers)
        {
            return numbers.Average();
        }
    }*/

    /*public class Solution
    {
        public double solution(int[] numbers)
        {
            double answer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            answer /= numbers.Length;
            return answer;
        }
    }*/
}



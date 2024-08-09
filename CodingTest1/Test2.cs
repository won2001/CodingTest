namespace CodingTest1
{
    //배열 뒤집기
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            Array.Reverse(num_list);
            return num_list;
        }
    }
    //다른사람 풀이
    /*public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[num_list.Length];
            int K = 0;
            for (int i = num_list.Length - 1; i >= 0; i--)
            {
                answer[K] = num_list[i];
                K++;
            }
            return answer;
        }
    }*/
    //정수 배열 array가 매개변수로 주어질 때, 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
    public class Solution1
    {
        public int[] solution(int[] array)
        {
            int[] answer = new int[2];
            int max = answer[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (answer[0] < array[i])
                {
                    answer[0] = array[i]; //큰 수
                    answer[1] = i;
                }
            }
            return answer;
        }
    }
    //다른사람 풀이
    /*using System;
      using System.Linq;    //System.Linq 네임스페이스를 사용해야 Array.IndexOf 메서드를 사용가능합니다.

    public class Solution
    {
        public int[] solution(int[] array)
        {
            //Array.IndexOf 메서드는 지정한 개체를 검색하여 1차원 배열 또는 배열의 요소 범위에서 처음으로 일치하는 인덱스를 반환합니다.
            int[] answer = new int[2] { array.Max(), Array.IndexOf(array, array.Max()) };
            return answer;
        }
    }*/

    //중앙값 구하기
    //중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다.
    //예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 정수 배열 array가 매개변수로 주어질 때, 중앙값을 return 하도록 solution 함수를 완성해보세요.
    public class Solution2
    {
        public int solution(int[] array)
        {
            int answer = 0;

            Array.Sort(array);//Array.Sort 메서드란 1차원 배열의 요소를 정렬합니다.
            answer = array[array.Length / 2]; //array배열을 2나누기를 해서 중앙 값 위치

            return answer;
        }
    }

    //문자열 내 마음대로 정렬하기
    //문제 설명
    //문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다.
    //예를 들어 strings가["sun", "bed", "car"] 이고 n이 1이면 각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.

    //제한 조건
    //strings는 길이 1 이상, 50이하인 배열입니다.
    //strings의 원소는 소문자 알파벳으로 이루어져 있습니다.
    //strings의 원소는 길이 1 이상, 100이하인 문자열입니다.
    //모든 strings의 원소의 길이는 n보다 큽니다.
    //인덱스 1의 문자가 같은 문자열이 여럿 일 경우, 사전순으로 앞선 문자열이 앞쪽에 위치합니다.


    public class Solution3
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];
            for ( int i = 0; i < strings.Length; i++)
            {
                answer[i] = (strings[i][n]) + strings[i];//n맨 앞으로 꺼내기
            }
            Array.Sort(answer);//n기준으로 정렬
            for ( int i = 0; i < strings.Length; i++)
            {
                answer[i] = answer[i].Substring(1);
            }
            return answer;
        }
    }

    //문제 https://school.programmers.co.kr/learn/courses/30/lessons/1844
    //가중치가 없으니 BFS 사용
    //5x5 크기의 맵을(정점들) 만들고
    //처음 시작지점을 만든다음
    //모든 정점을 확인한 후
    //다음으로 탐색해야할 정점을 확인하고
    //연결되어 있는 정점
    //찾은적 없는 정점
    //탐색 여부를 체크
    //탐색하게 되는 정점 체크
    //탐색해야하는 정점 큐를 이용한 대기열 추가
}

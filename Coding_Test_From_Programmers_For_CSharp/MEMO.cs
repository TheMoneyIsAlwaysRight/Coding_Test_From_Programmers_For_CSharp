using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

// 새롭게 알게 된 함수 혹은 잊어먹기 쉬운 함수 기록

/*
 * <Extension> : 확장 메서드
 * <Static> : 정적 메서드
 * <High_Version> : C# 혹은 .NET의 최신 환경에서만 사용가능.
 * 
************************************** <<System>> ********************************************************************************

    -문자열 관련-

                String.Substring(int index) : 문자열의 특정 인덱스부터 문자열 끝까지의 부분문자열 추출 -> string형으로 반환.
                -> instance.Substring(start_Index);

                String.Substring(int start_index ,int Length)  : 문자열의 특정 인덱스부터 특정길이 만큼의 부분문자열 추출 -> string형으로 반환.
                -> instance.Substring(start_Index,Length);

                String.StartsWith(string word): 문자열이 이 문자열로 시작하는지 검사 -> bool형 반환.
                -> instance.StartWith("word");

                String.Replace(char old_value,char new_Value) : 문자열의 모든 old_value 문자를 new_Value 문자로 바꾼 문자열 반환 -> string형 반환
                ->instance.Replace(old_value,new_Value);

                String.Replace(String old_value,String new_Value) : 문자열의 모든 old_value 문자열을 new_Value 문자열로 바꾼 문자열 반환 -> string형 반환
                ->instance.Replace(old_value,new_Value);

                String.ToLower() : 문자열의 모든 대문자를 소문자로 바꾼 새 문자열 생성 -> string형 반환
                -> instance.ToLower();

                String.ToUpper() : 문자열의 모든 소문자를 대문자로 바꾼 새 문자열 생성 -> string형 반환 
                -> instance.ToUpper();

   <Static>     String.Concat(params string[] value) : 매개변수의 문자열들 혹은 문자열 배열의 모든 요소들을 연결한 새로운 문자열 생성, params 연산자 덕분에 매개변수 제한 X -> string형 반환
                ->String.Concat("Hello","World");

   <Static>     String.IsNullOrEmpty(String value) : 매개변수의 문자열이 빈 문자열("")이거나, null인지 검사하여, 전자일 경우 True, 아닐경우 false 반환.
                ->String.IsNullorEmpty(word);

<High_Version>  String.StartsWith(char letter): 문자열이 이 문자로 시작하는지 검사 -> bool형 반환.
                -> instance.StartsWith('s'); 

    -배열 관련-

   <Static>     Array.Sort(Array arrayName) : IComparable 구현된 각 요소의 CompareTo 메서드를 통해 정렬 알고리즘으로 그 배열을 재정렬.
                -> Array.Sort(arrayName);

   <Static>     Array.IndexOf(Array arrayName, Object value): 순차탐색 후 먼저 나오는 value의 인덱스 반환. 없으면 -1 반환.
                -> Array.IndexOf(instance,value);

   <Static>     Array.IndexOf(Array arrayName, Object value,int start_index) : 특정 인덱스부터 순차탐색 후 먼저 나오는 value의 인덱스 반환. 없으면 -1 반환.
                -> Array.IndexOf(instance,value,start_index);

   <Static>     Array.Reverse(Array arrayName) : 배열의 모든 요소를 역순으로 뒤집는다.        
                ->Array.Reverse(arrayName);

   <Static>     Array.Resize<T>(ref Array<T> arrayName,int size) : 그 배열을 참조해서(ref) 크기를 size만큼으로 조절. size보다 큰 index에 있던 데이터들은 전부 삭제됨.
                ->Array.Resize(ref arrayName,size);

    -변환 관련-
                               
   <Static>     Convert.ToString(int value,int number) : 주어진 값을 문자열로 변환할 건데, 먼저 값을 number(2,8,10,16)진법으로 변환하고 이를 문자열로 반환한다.
                ->Convert.ToString(value,Number);

   <Static>     Convert.ToInt32(Object value) : 매개변수의 객체을 int형으로 변환 -> int형 반환.
                ->Convert.ToInt32(value);

   <Static>     Convert.ToInt32(Object value,int Number) : Number(2,8,10,16만 가능)진법으로 표현된 주어진 문자열 등(value)을 10진수인 int형으로 변환한다.
                ->Convert.ToInt32(value,Number);                            // "1010"(2진수로 표현된 문자열) ---> 10 (10진수 정수형 값) 

   <Static>     Convert.ToDouble(Object value) : 매개변수의 객체을 double형으로 변환 -> double형 반환.
                ->Convert.ToDouble(value);

   <Static>     Int32.TryParse(String value,out int result) : 첫번째 매개변수의 문자열을 int형으로 변환을 시도하고, 성공유무에 따라 bool형으로 반환, 성공시 out 파라미터의 result에 값 반환. 실패시 result는 0 반환.
                ->Int32.TryParse(instance,out int result)

    -객체 관련-
                Object.Equals(Object) : 이 객체와 매개변수의 객체가 같은지 검사 -> bool형 반환.
                -> instance.Equals(other_instance);
    
   <Static>     Object.Equals(Object,Object) : 매개변수의 두 객체가 같은지 검사 -> bool형 반환.
                -> ex : Object.Equals(IsEqual, IsEquals);




************************************** <<System.Linq>> ****************************************************************************************************

  <Extension>   Enumerable.Any(this System.Collections.Generic.IEnumerable source) : 시퀀스에 요소가 하나라도 있는지 검사 -> bool형 반환.
                ->arrayName.Any();
                ->Enumerable.Any(arrayName);

  <Extension>   Enumerable.Any(this System.Collections.Generic.IEnumerable source, Func<TSource,bool> predicate) : 시퀀스에 특정 조건에 맞는 요소가 있는지 검사 - > bool형 반환.         
                ->instance.Any(item => item > 0);
                ->Enumerable.Any(arrayName,item => item > 0);

  <Extension>   Enumerable.ToList(this System.Collections.Generic.IEnumerable source) : IEnumerable<T>에서 List<T>를 생성 -> List<T>로 반환.
                ->arrayName.ToList();
                ->Enumerable.ToList(arrayName);

  <Extension>   Enumerable.Distinct(this IEnumerable source) : 컬렉션에서 중복된 요소를 제거한 새로운 시퀀스를 반환. ->IEnumerable<TSource>형 반환 이를 ToList등으로 변환해 사용가능.
                -> arrayName.Distinct();
                -> Enumerable.Distinct(arrayName);

  <Extension>   Enumerable.FirstOrDefault(this IEnumerable, Func<TSource,Boolean>, TSource) : 컬렉션에서 람다식에 부합하는 요소가 있으면 반환 없을 경우, 그 컬렉션의 기본값 객체 반환.
                -> Dictionary.FirstOrDefault(item, item => item.GetComponent().IsClear) => 딕셔너리 요소탐색에 람다식 사용가능


****************************************<<System.Collections.Generic>> ************************************************************************************************


                List<T>.ToArray() : 컬렉션의 요소들을 새 배열에 복사하고 그 배열을 반환. ->   T[]형 반환.
                -> instance_List.ToArray();



************************************************<<System.Text>>************************************************************************************************
    ->좀 더 R%D 필요.

                Encoding.ASCII.GetChars(Byte[]) : 바이트 배열을 디코딩하여 Char형 문자 배열로 변환한다.

                Encoding.ASCII.GetBytes(String string) :  해당 문자열을 ASCII 인코딩된 바이트 배열로 변환한다.


 
 **********************************************정리 안된  목록들************************************************************************
                Split
 
 
 
 
 */

public class MEMO
{
}


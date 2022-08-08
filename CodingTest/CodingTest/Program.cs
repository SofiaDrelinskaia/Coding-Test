using CodingTest;

// Problem 1

//Test 1
List<int> problem1_input1 = new List<int>(new int[] { 1, 2, 3 });
List<int> problem1_result1 = Methods.Map<int, int>(problem1_input1, x => x + 1);

//Test 2
List<int> problem1_input2 = new List<int>(new int[] { 1, 2, 3 });
List<string> problem1_result2 = Methods.Map<int, string>(problem1_input2, x => x.ToString());

//Test 3
List<bool> problem1_input3 = new List<bool>();
List<bool> problem1_result3 = Methods.Map<bool, bool>(problem1_input3, null);


// Problem 2

//Test 1
List<int> problem2_input1 = new List<int>(new int[] { 1, 2, 3 });
int problem2_result1 = Methods.Fold(problem2_input1, 0, (sum, x) => sum + x);

//Test 2
List<int> problem2_input2 = new List<int>(new int[] { 1, 2, 3 });
string problem2_result2 = Methods.Fold(problem2_input2, "", (str, x) => str + x.ToString());

//Test 3
List<int> problem2_input3 = new List<int>();
int problem2_result3 = Methods.Fold(problem2_input3, 0, null);


// Problem 3

//Test 1
List<int> problem3_input1 = new List<int>(new int[] { 1, 2, 3 });
List<int> problem3_result1 = Methods.Map2<int, int>(problem3_input1, x => x + 1);

//Test 2
List<int> problem3_input2 = new List<int>(new int[] { 1, 2, 3 });
List<string> problem3_result2 = Methods.Map2<int, string>(problem3_input2, x => x.ToString());

//Test 3
List<bool> problem3_input3 = new List<bool>();
List<bool> problem3_result3 = Methods.Map2<bool, bool>(problem3_input3, null);

Console.WriteLine("FINISH"); //Установить в этой строке точку останова и посмотреть состояние всех переменных
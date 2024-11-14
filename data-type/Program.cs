int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 =  value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
float result3 = (value3/value1);
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");






























// string[] values = { "12,3", "45", "ABC", "11", "DEF" };

// float result = 0;
// string frase = "";

// foreach (var value in values)
// {
//     float number;  
//     bool validacao = float.TryParse(value, out number);

//     if (validacao == false)
//     {
//     //Regra 1: Se o valor for alfabético, concatene-o para formar uma mensagem.
//     frase = frase + value;

//     }
//     else 
//     {
//         //Regra 2: se o valor for numérico, adicione-o ao total.
//         result += number;
//     }
    
// }

// Console.WriteLine("Message: " + frase);
// Console.WriteLine("Total: " + result);










































// // string value = "bad";
// // int result = 0;
// // if (int.TryParse(value, out result))
// // {
// //    Console.WriteLine($"Measurement: {result}");
// // }
// // else
// // {
// //    Console.WriteLine("Unable to report the measurement.");
// // }
// // if (result > 0)
// // Console.WriteLine($"Measurement (w/ offset): {50 + result}");











































































// // int[] data;
// // Console.WriteLine("");
// // Console.WriteLine("Floating point types:");
// // Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// // Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// // Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");






// // // Console.WriteLine("Signed integral types:");

// // // Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// // // Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// // // Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// // // Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// // // Console.WriteLine("");
// // // Console.WriteLine("Unsigned integral types:");

// // // Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// // // Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// // // Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// // // Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");





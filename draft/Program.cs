// // // string[] pallets = [ "B14", "A11", "B12", "A13" ];

// // // Console.WriteLine("Sorted...");
// // // Array.Sort(pallets);
// // // foreach (var pallet in pallets)
// // // {
// // //     Console.WriteLine($"-- {pallet}");
// // // }

// // // Console.WriteLine("");
// // // Console.WriteLine("Reversed...");
// // // Array.Reverse(pallets);
// // // foreach (var pallet in pallets)
// // // // {
// // // //     Console.WriteLine($"-- {pallet}");
// // // // }

// // // string[] pallets = ["B14", "A11", "B12", "A13"];
// // // Console.WriteLine("");

// // // // Console.WriteLine($"Before: {pallets[0]}");
// // // // Array.Clear(pallets, 0, 2);
// // // // Console.WriteLine($"After: {pallets[0]}");

// // // Console.WriteLine($"Before: {pallets[0].ToLower()}");
// // // Array.Clear(pallets, 0, 2);
// // // if (pallets[0] != null)
// // //     Console.WriteLine($"After: {pallets[0].ToLower()}");

// // // Array.Clear(pallets, 0, 2);
// // // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// // // foreach (var pallet in pallets)
// // // {
// // //     Console.WriteLine($"-- {pallet}");
// // // }
// // string[] pallets = [ "B14", "A11", "B12", "A13" ];
// // Console.WriteLine("");

// // Array.Clear(pallets, 0, 2);
// // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// // Console.WriteLine("");
// // Array.Resize(ref pallets, 6);
// // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// // pallets[4] = "C01";
// // pallets[5] = "C02";

// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// // Console.WriteLine("");
// // Array.Resize(ref pallets, 3);
// // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// // string value = "abc123";
// // char[] valueArray = value.ToCharArray();
// // Array.Reverse(valueArray);
// // // string result = new string(valueArray);
// // string result = String.Join(",", valueArray);
// // Console.WriteLine(result);

// // string[] items = result.Split(',');
// // foreach (string item in items)
// // {
// //     Console.WriteLine(item);
// // // }

// // string pangram = "The quick brown fox jumps over the lazy dog";
// // char[] pangramReverse = pangram.ToCharArray();
// // Console.WriteLine(pangramReverse);
// // Console.WriteLine("");
// // Array.Reverse(pangramReverse);
// // Console.WriteLine(pangramReverse);
// // string result = new string(pangramReverse);
// // string [] items = result.Split(' ');
// // foreach (string item in items) 
// // {
// // //     Console.WriteLine(item);
// // // } 


// // string pangram = "The quick brown fox jumps over the lazy dog";

// // // Step 1
// // string[] message = pangram.Split(' ');

// // //Step 2
// // string[] newMessage = new string[message.Length];

// // // Step 3
// // for (int i = 0; i < message.Length; i++)
// // {
// //     char[] letters = message[i].ToCharArray();
// //     Array.Reverse(letters);
// //     newMessage[i] = new string(letters);
// // }

// // //Step 4
// // string result = String.Join(" ", newMessage);
// // Console.WriteLine(result);

// // string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// //Analisar as IDs e Armazenar em um pedido.

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] items = orderStream.Split(',');
// Array.Sort(items);

// foreach (var item in items)
// {
//     if (item.Length == 4)
//     {
//         Console.WriteLine(item);
//     }
//     else
//     {
//         Console.WriteLine(item + "\t- Error");
//     }
// }


// // foreach (string newOrderItem in newOrder)
// // {
// //     char[] chars = orderStream.ToCharArray();
// //     string result = new string(chars);
// //     Console.WriteLine(result);
// //     if (newOrderItem < )

// //     Console.WriteLine(newOrderItem);
// // }




string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] message = orderStream.Split(',');
Array.Sort(message);
foreach (string messageItem in message)
{
    if (messageItem.Length != 4)
    {
        Console.WriteLine(messageItem + "\t-\tError");
    }
    else {
        Console.WriteLine(messageItem);
    }
}
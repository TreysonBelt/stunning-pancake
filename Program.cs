// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.ResetColor();

int[] num = new int[6]{
    4, 3, 2, 1, 5, 6
};
int repetition = 1;
int i;
for(i = 0; i < num.Length; i++){
    Console.ResetColor();
    if (repetition == 1)
        if (num[i] % 2 == 0){
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(num[i]);
        }
        else{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(num[i]);
        }
    else{
                if (num[i] % 2 == 0){
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(num[i]);
        }
        else{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(num[i]);
        }
        repetition = 0;
    }
    repetition ++;
}
var j = false;
while (j == false){
    Console.WriteLine("lol");
    string blah = Console.ReadLine("");
    if (blah == "d"){
        break;
    }
}
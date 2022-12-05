// See https://aka.ms/new-console-template for more information

{
   /* List of upcomming variables 
    sbyte testSbyte = 1;
    long testLong = 1;
    ulong testUlong = 1;
    double testDouble = 1;
    float testFloat = 1;
    char testChar = '\u006A'; */


    // checking operands type of int with unary, binary and ternary conditional operator.


    // int vs unary operators
    int c;
    int a = 5;
    int b = 6;
    c = ++b;
    c = b--;
    a++;
    b--;


    // int vs binary operators
    c = a + b;
    c = b * a;
    c = a += b -= 1;
    c = (a % 2) * (b / 3);


    // int vs bitwise operators
    Console.WriteLine(a & b); 
    Console.WriteLine(a | b);
    Console.WriteLine(~ b);
    c = a ^ b;
    c = a >> b;


    //int vs assignment operations
    c += b;
    c -= b;
    c *= b;
    c /= b;
    c %= b;


    // int vs assignment operations inside bitwice operations
    c &= b; 
    c |= b;
    c <<= b;
    c >>= b;
    c ^= b;
    c |= b;


    // int vs boolean operations
    bool g = a == b;
    g = (a > b) | (b < c);
    g = a != 10;
    g = b >= c;
    g = a < b;
    g = a == b;


    // int vs the ternary conditional operator
    Console.WriteLine("Для продолжения нажмите Y");
    string isQuit = Console.ReadLine();
    int gameOver = isQuit == "Y" ? ( a + b ) : ( b - a );
    Console.WriteLine(isQuit);



    // checking operands type of unit with unary, binary and ternary conditional operator.

    // uint vs unary operators
    uint thirdUint;
    uint firstUint = 2;
    uint secondUint = 101;
    // thirdUint = ++secondUint;
   //  thirdUint = secondUint--;
    firstUint++;
    secondUint--;


    // uint vs binary operators
    thirdUint = firstUint + secondUint;
    thirdUint = secondUint * firstUint;
    thirdUint = firstUint += secondUint -= 1;
    thirdUint = (firstUint % 2) * (secondUint / 3);


    // uint vs bitwise operators
    Console.WriteLine(firstUint & secondUint);
    Console.WriteLine(firstUint | secondUint);
    Console.WriteLine(~secondUint);
    thirdUint = firstUint ^ secondUint;
    // thirdUint = firstUint >> secondUint; cannot be applied to opperands of type uint and uint.


    // uint vs assignment operations
    thirdUint += secondUint;
    thirdUint -= secondUint;
    thirdUint *= secondUint;
    thirdUint /= secondUint;
    thirdUint %= secondUint;


    // uint vs assignment operations inside bitwice operations
    thirdUint &= secondUint;
    thirdUint |= secondUint;
    // thirdUint <<= secondUint; cannot be applied to opperands of type uint and uint.
    // thirdUint >>= secondUint; cannot be applied to opperands of type uint and uint.
    thirdUint ^= secondUint;
    thirdUint |= secondUint;


    // uint vs boolean operations
    bool boolUint = firstUint == secondUint;
    boolUint = (firstUint > secondUint) | (secondUint < thirdUint);
    boolUint = firstUint != 10;
    boolUint = secondUint >= thirdUint;
    boolUint = firstUint < secondUint;
    boolUint = firstUint == secondUint;


    // uint vs the ternary conditional operator
    Console.WriteLine("Для продолжения нажмите Y");
    isQuit = Console.ReadLine();
    uint playAgain = isQuit == "Y" ? (firstUint + secondUint) : (secondUint - firstUint);
    Console.WriteLine(isQuit);



    // checking operands type of short with unary, binary and ternary conditional operator.

    // short vs unary operators
    short thirdShort;
    short firstShort = 2;
    short secondShort = 101;
    thirdShort = ++secondShort;
    thirdShort = secondShort--;
    firstShort++;
    secondShort--;


    // short vs binary operators
    thirdShort = checked( (short) (firstShort + secondShort));
    thirdShort = checked( (short) (secondShort * firstShort));
    thirdShort = firstShort += secondShort -= 1;
    thirdShort = checked( (short) (firstShort % 2 * secondShort / 3));


    // short vs bitwise operators
    Console.WriteLine(firstShort & secondShort);
    Console.WriteLine(firstShort | secondShort);
    Console.WriteLine(~secondShort);
    thirdShort = checked( (short) (firstShort ^ secondShort));
    thirdShort = checked( (short) (firstShort >> secondShort)); 


    // short vs assignment operations
    thirdShort += secondShort;
    thirdShort -= secondShort;
    thirdShort *= secondShort;
    thirdShort /= secondShort;
    thirdShort %= secondShort;


    // short vs assignment operations inside bitwice operations
    thirdShort &= secondShort;
    thirdShort |= secondShort;
    thirdShort <<= secondShort; 
    thirdShort >>= secondShort; 
    thirdShort ^= secondShort;
    thirdShort |= secondShort;


    // short vs boolean operations
    bool boolShort = firstShort == secondShort;
    boolShort = (firstShort > secondShort) | (secondShort < thirdShort);
    boolShort = firstShort != 10;
    boolShort = secondShort >= thirdShort;
    boolShort = firstShort < secondShort;
    boolShort = firstShort == secondShort;


    // short vs the ternary conditional operator
    Console.WriteLine("Для продолжения нажмите Y");
    isQuit = Console.ReadLine();
    short playContinue = (short) (isQuit == "Y" ? (firstShort + secondShort) : (secondShort - firstShort)); 
    Console.WriteLine(isQuit);


    
    // checking operands type of ushort with unary, binary and ternary conditional operator.

    
    // ushort vs unary operators
    ushort thirdUshort;
    ushort firstUshort = 2;
    ushort secondUshort = 101;
    thirdUshort = ++secondUshort;
    thirdUshort = secondUshort--;
    firstUshort++;
    secondShort--;


    // ushort vs binary operators
    thirdUshort = checked((ushort)(firstUshort + secondUshort));
    thirdUshort = checked((ushort)(secondUshort * firstUshort));
    thirdUshort = firstUshort += secondUshort -= 1;
    thirdUshort = checked((ushort)(firstUshort % 2 * secondUshort / 3));


    // ushort vs bitwise operators
    Console.WriteLine(firstUshort & secondUshort);
    Console.WriteLine(firstUshort | secondUshort);
    Console.WriteLine(~secondUshort);
    thirdUshort = checked((ushort)(firstUshort ^ secondUshort));
    thirdUshort = checked((ushort)(firstUshort >> secondUshort));


    // short vs assignment operations
    thirdUshort += secondUshort;
    thirdUshort -= secondUshort;
    thirdUshort *= secondUshort;
    thirdUshort /= secondUshort;
    thirdUshort %= secondUshort;


    // ushort vs assignment operations inside bitwice operations
    thirdUshort &= secondUshort;
    thirdUshort |= secondUshort;
    thirdUshort <<= secondUshort;
    thirdUshort >>= secondUshort;
    thirdUshort ^= secondUshort;
    thirdUshort |= secondUshort;


    // ushort vs boolean operations
    bool boolUshort = firstUshort == secondUshort;
    boolShort = (firstUshort > secondUshort) | (secondUshort < thirdUshort);
    boolShort = firstUshort != 10;
    boolShort = secondUshort >= thirdUshort;
    boolShort = firstUshort < secondUshort;
    boolShort = firstUshort == secondShort;


    // ushort vs the ternary conditional operator
    Console.WriteLine("Для продолжения нажмите Y");
    isQuit = Console.ReadLine();
    ushort continuePlay = (ushort)(isQuit == "Y" ? (firstUshort + secondUshort) : (secondUshort - firstUshort));
    Console.WriteLine(isQuit);



   
    // checking operands type of bool with unary, binary and ternary conditional operator.


    // bool vs unary operators
    bool thirdBool;
    bool firstBool;
    bool secondBool;
    /* thirdBool = ++secondBool;
    thirdBool = secondBool--;
    firstBool++;
    secondBool--;


    // bool vs binary operators - cannot be applied to operand type bool
    thirdBool = firstBool + secondBool;
    thirdBool = secondBool * firstBool;
    thirdBool = firstBool += secondBool -= 1;
    thirdBool = firstBool % 2 * secondBool / 3; 


    // bool vs bitwise operators - cannot be applied to operand type bool
    Console.WriteLine(firstBool & secondBool); */
    Console.WriteLine(firstBool | secondBool); // uncorrect output: taking |-operator as a logical bool-operator, but not the bitwice one.
    /* Console.WriteLine(~secondBool); 
    thirdBool = firstBool ^ secondBool;
    thirdBool = firstBool >> secondBool; */


    // bool vs assignment operations - cannot be applied to operand type bool
    /* thirdBool += secondBool;
    thirdBool -= secondBool;
    thirdBool *= secondBool;
    thirdBool /= secondBool;
    thirdBool %= secondBool; */


    // bool vs assignment operations inside bitwice operations
    thirdBool &= secondBool; // uncorrect output: taking &-operator as a logical bool-operator, but not the bitwice one.
    thirdBool |= secondBool; // uncorrect output: taking &-operator as a logical bool-operator, but not the bitwice one.
    /* thirdBool <<= secondBool;
     thirdBool >>= secondBool;  - cannot be applied to operand type bool */
    thirdBool ^= secondBool; // uncorrect output: taking operator as a logical bool-operator, but not the bitwice one.
    thirdBool |= secondBool; // uncorrect output: taking operator as a logical bool-operator, but not the bitwice one.


    // bool vs boolean operations - cannot be applied to operand type bool */
    bool boolTest;
    /* boolTest = (firstBool > secondBool) | (secondBool < thirdBool);
    boolTest = firstBool != 10;
    boolTest = secondBool >= thirdBool;
    boolTest = firstBool < secondBool; */
    boolTest = firstBool == secondBool;
    boolTest = (6 > 1) | (5 < 10);
    while (firstBool != true) Console.WriteLine("Pew - pew!");


    // bool vs the ternary conditional operator
    Console.WriteLine("Для продолжения нажмите Y");
    isQuit = Console.ReadLine();
    // bool keepPlay = isQuit == "Y" ? "Спасибо за игру" : "Продолжим!"; - cannot convert string to bool, convertation needed
    Console.WriteLine(isQuit);



    
    // checking operands type of byte with unary, binary and ternary conditional operator.

    // byte vs unary operators
    byte thirdByte;
    byte firstByte = 2;
    byte secondByte = 101;
    thirdByte = ++secondByte;
    thirdByte = secondByte--;
    firstByte++;
    secondByte--;


    // byte vs binary operators
    thirdByte = checked((byte)(firstByte + secondByte));
    thirdByte = checked((byte)(secondByte * firstByte));
    thirdByte = firstByte += secondByte -= 1;
    thirdByte = checked((byte)(firstByte % 2 * secondByte / 3));


    // byte vs bitwise operators
    Console.WriteLine(firstByte & secondByte);
    Console.WriteLine(firstByte | secondByte);
    Console.WriteLine(~secondByte);
    thirdByte = checked((byte)(firstByte ^ secondByte));
    thirdByte = checked((byte)(firstByte >> secondByte));


    // byte vs assignment operations
    thirdByte += secondByte;
    thirdByte -= secondByte;
    thirdByte *= secondByte;
    thirdByte /= secondByte;
    thirdByte %= secondByte;


    // byte vs assignment operations inside bitwice operations
    thirdByte &= secondByte;
    thirdByte |= secondByte;
    thirdByte <<= secondByte;
    thirdByte >>= secondByte;
    thirdByte ^= secondByte;
    thirdByte |= secondByte;


    // byte vs boolean operations
    bool boolByte = firstByte == secondByte;
    boolByte = (firstByte > secondByte) | (secondByte < thirdByte);
    boolByte = firstByte != 10;
    boolByte = secondByte >= thirdByte;
    boolByte = firstByte < secondByte;
    boolByte = firstByte == secondByte;


    // byte vs the ternary conditional operator
    Console.WriteLine("Для продолжения нажмите Y");
    isQuit = Console.ReadLine();
    byte isPlaying = (byte)(isQuit == "Y" ? (firstByte + secondByte) : (secondByte - firstByte));
    Console.WriteLine(isQuit);


}



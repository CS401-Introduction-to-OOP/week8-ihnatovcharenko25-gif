using Week8;

var letter1 = new Letter("123", 0.1);
letter1.PrintInfo();
Console.WriteLine(letter1.CalculateCost());

var parcel1 = new Parcel("1321", 10, "10*10*20");
parcel1.PrintInfo();
Console.WriteLine(parcel1.CalculateCost());

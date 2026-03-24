using Week8;

var letter1 = new Letter("123", 0.1);
letter1.PrintInfo();
//Console.WriteLine(letter1.CalculateCost());
var letter2 = new Letter("223", 0.2);

var parcel1 = new Parcel("1321", 10, "10*10*20");
parcel1.PrintInfo();
//Console.WriteLine(parcel1.CalculateCost());
var parcel2 = new Parcel("2321", 5, "20*10*15");



var myCargo = new CargoContainer<DeliveryItem>();
myCargo.Add(letter1);
myCargo.Add(letter2);
myCargo.Add(parcel1);
myCargo.Add(parcel2);

Console.WriteLine($"Total cost: {myCargo.GetTotalCost()}");
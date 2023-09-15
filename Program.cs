using rodeStoel;

Stoel rodeStoel = new Stoel("rood", 60, -10);
Console.WriteLine(rodeStoel.kleurtje());
Console.WriteLine("De stoel heeft een zithoogte van: " + rodeStoel.getZithoogte());
Console.WriteLine("De stoel na het verstellen heeft een zithoogte van: " + rodeStoel.verstellen());
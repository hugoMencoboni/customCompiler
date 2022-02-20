using Core;

Console.WriteLine("**************************************************");
Console.WriteLine("Hello, welcome to this new custom custom compiler!");
Console.WriteLine("**************************************************");
Console.WriteLine("");

while(true) {
    Console.Write(">");

    var rawCommande = Console.ReadLine();
    if(string.IsNullOrEmpty(rawCommande)) continue;

    var commande = new Commande(rawCommande);
    var result = commande.Execute();
    Console.WriteLine(result);
}

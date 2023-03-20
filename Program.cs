
int somme(int a,int b)
{
    return a + b;
}
int produit(int a, int b)
{
    return a * b;
}

int oppose(int a)
{
    return -a;
}

#region main
int nba = 9;
int nbb = 31;
int nbc = -7;
Console.WriteLine("Salut le nouveau utilisateur");
Console.WriteLine($"la somme = {somme(nba, nbb)}");
Console.WriteLine($"la multiplication = {produit(nba, nbb)}");
Console.WriteLine($"l'opposé de {nbc} est : {oppose(nbc)}");
#endregion



int somme(int a,int b)
{
    return a + b;
}
int produit(int a, int b)
{
    return a * b;
}

#region main
int nba = 9;
int nbb = 31;
Console.WriteLine($"la somme = {somme(nba, nbb)}");
Console.WriteLine($"la multiplication = {produit(nba, nbb)}");
#endregion

